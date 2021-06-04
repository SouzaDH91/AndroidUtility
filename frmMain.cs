using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace AndroidUtility
{
    public partial class frmMain : Form
    {
        public static TextBox avd { get; set; }
        public frmMain()
        {
            InitializeComponent();
            avd = tbAVDID;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnExecutar.Enabled = false;
            Verificacoes();

            if (Config.readFile() != null)
            {
                String[] avd = Config.readFile().Split('=');

                tbAVDID.Text = avd[1];
            }
        }

        // AVD_ID = Pixel_2_-_Android_8.1
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (tbAVDID.Text != String.Empty && Config.readFile() != null)
            {
                String[] avd = Config.readFile().Split('=');

                if (avd[1] == tbAVDID.Text)
                {
                    tbAVDID.Text = Config.readFile();
                    this.startAvd();
                }
                else
                {
                    Config.writeData(tbAVDID.Text);
                    this.startAvd();
                }
            }
            else if (tbAVDID.Text.Length > 0 && Config.readFile() == null)
            {
                Config.writeData(tbAVDID.Text);
                this.startAvd();
            }
            else
            {
                MessageBox.Show("Informe o AVD_ID!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startAvd()
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = ComandoCompleto(avd.Text);
            p.Start();
        }

        // Metodo que verica se o programa está instalado
        public static bool IsSoftwareInstalled(string softwareName)
        {
            var registryUninstallPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            var registryUninstallPathFor32BitOn64Bit = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

            if (Is32BitWindows())
                return IsSoftwareInstalled(softwareName, RegistryView.Registry32, registryUninstallPath);

            var is64BitSoftwareInstalled = IsSoftwareInstalled(softwareName, RegistryView.Registry64, registryUninstallPath);
            var is32BitSoftwareInstalled = IsSoftwareInstalled(softwareName, RegistryView.Registry64, registryUninstallPathFor32BitOn64Bit);

            return is64BitSoftwareInstalled || is32BitSoftwareInstalled;
        }

        private static bool Is32BitWindows() => Environment.Is64BitOperatingSystem == false;

        private static bool IsSoftwareInstalled(string softwareName, RegistryView registryView, string installedProgrammsPath)
        {
            var uninstallKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView)
                                                  .OpenSubKey(installedProgrammsPath);

            if (uninstallKey == null)
                return false;

            return uninstallKey.GetSubKeyNames()
                               .Select(installedSoftwareString => uninstallKey.OpenSubKey(installedSoftwareString))
                               .Select(installedSoftwareKey => installedSoftwareKey.GetValue("DisplayName") as string)
                               .Any(installedSoftwareName => installedSoftwareName != null && installedSoftwareName.Contains(softwareName) && softwareName != String.Empty);
        }

        // Metodo que verifica se a variável de ambiente está configurada
        public static bool CheckEV(string ea)
        {
            if (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable(ea)))
            {
                Console.WriteLine(Environment.GetEnvironmentVariable(ea));
                return true;
            }
            return false; 
        }

        // Inicializa verificações
        public void Verificacoes()
        {
            // JavaJDK
            if (IsSoftwareInstalled("Java SE Development Kit"))
            {
                lblRetornoJavaJDK.Text = "OK";
                lblRetornoJavaJDK.ForeColor = Color.Green;
                btnExecutar.Enabled = true;

                // Variável de ambiente JAVA_HOME
                if (CheckEV("JAVA_HOME"))
                {
                    lblJavaHome.Text = "OK";
                    lblJavaHome.ForeColor = Color.Green;
                    btnExecutar.Enabled = true;
                }
                else
                {
                    lblJavaHome.Text = "Não configurado";
                    lblJavaHome.ForeColor = Color.Red;
                    btnExecutar.Enabled = false;
                }
            }
            else
            {
                lblRetornoJavaJDK.Text = "Não instalado";
                lblRetornoJavaJDK.ForeColor = Color.Red;
                btnExecutar.Enabled = false;
            }

            // Android Studio
            if (IsSoftwareInstalled("Android Studio"))
            {
                lblAndroidStudio.Text = "OK";
                lblAndroidStudio.ForeColor = Color.Green;
                btnExecutar.Enabled = true;

                // Variável de ANDROID_HOME
                if (CheckEV("ANDROID_HOME"))
                {
                    lblAndroidHome.Text = "OK";
                    lblAndroidHome.ForeColor = Color.Green;
                    btnExecutar.Enabled = true;
                }
                else
                {
                    lblAndroidHome.Text = "Não configurado";
                    lblAndroidHome.ForeColor = Color.Red;
                    btnExecutar.Enabled = false;
                }
            }
            else
            {
                lblAndroidStudio.Text = "Não instalado";
                lblAndroidStudio.ForeColor = Color.Red;
                btnExecutar.Enabled = false;
            }
        }

        public String ComandoCompleto(String avdid)
        {
            return @"/c " + Environment.GetEnvironmentVariable("ANDROID_HOME") + @"\emulator\emulator.exe -avd " + avdid + " -dns-server 8.8.8.8";
        }

        private void btnExecutar_MouseHover(object sender, EventArgs e)
        {
            lblComando.Text = Environment.GetEnvironmentVariable("ANDROID_HOME") + @"\emulator\" + "\n" + "emulator.exe -avd " + tbAVDID.Text + "\n" + "-dns-server 8.8.8.8";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
