namespace AndroidUtility
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblAndroidHome = new System.Windows.Forms.Label();
            this.lblAndroidStudio = new System.Windows.Forms.Label();
            this.lblJavaHome = new System.Windows.Forms.Label();
            this.lblRetornoJavaJDK = new System.Windows.Forms.Label();
            this.lblJavaJDK = new System.Windows.Forms.Label();
            this.lblVariavelAndroidHome = new System.Windows.Forms.Label();
            this.blbAndroidStudio = new System.Windows.Forms.Label();
            this.lblVariavelJavaHome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAVDID = new System.Windows.Forms.TextBox();
            this.lblAVDId = new System.Windows.Forms.Label();
            this.lblComandoExecutado = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.fbdPastaAndroidSDK = new System.Windows.Forms.FolderBrowserDialog();
            this.lblComando = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblAndroidHome);
            this.gbInfo.Controls.Add(this.lblAndroidStudio);
            this.gbInfo.Controls.Add(this.lblJavaHome);
            this.gbInfo.Controls.Add(this.lblRetornoJavaJDK);
            this.gbInfo.Controls.Add(this.lblJavaJDK);
            this.gbInfo.Controls.Add(this.lblVariavelAndroidHome);
            this.gbInfo.Controls.Add(this.blbAndroidStudio);
            this.gbInfo.Controls.Add(this.lblVariavelJavaHome);
            this.gbInfo.Location = new System.Drawing.Point(12, 41);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(519, 173);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // lblAndroidHome
            // 
            this.lblAndroidHome.AutoSize = true;
            this.lblAndroidHome.Location = new System.Drawing.Point(340, 134);
            this.lblAndroidHome.Name = "lblAndroidHome";
            this.lblAndroidHome.Size = new System.Drawing.Size(13, 17);
            this.lblAndroidHome.TabIndex = 7;
            this.lblAndroidHome.Text = "-";
            // 
            // lblAndroidStudio
            // 
            this.lblAndroidStudio.AutoSize = true;
            this.lblAndroidStudio.Location = new System.Drawing.Point(169, 101);
            this.lblAndroidStudio.Name = "lblAndroidStudio";
            this.lblAndroidStudio.Size = new System.Drawing.Size(13, 17);
            this.lblAndroidStudio.TabIndex = 6;
            this.lblAndroidStudio.Text = "-";
            // 
            // lblJavaHome
            // 
            this.lblJavaHome.AutoSize = true;
            this.lblJavaHome.Location = new System.Drawing.Point(313, 63);
            this.lblJavaHome.Name = "lblJavaHome";
            this.lblJavaHome.Size = new System.Drawing.Size(13, 17);
            this.lblJavaHome.TabIndex = 5;
            this.lblJavaHome.Text = "-";
            // 
            // lblRetornoJavaJDK
            // 
            this.lblRetornoJavaJDK.AutoSize = true;
            this.lblRetornoJavaJDK.Location = new System.Drawing.Point(217, 31);
            this.lblRetornoJavaJDK.Name = "lblRetornoJavaJDK";
            this.lblRetornoJavaJDK.Size = new System.Drawing.Size(13, 17);
            this.lblRetornoJavaJDK.TabIndex = 4;
            this.lblRetornoJavaJDK.Text = "-";
            // 
            // lblJavaJDK
            // 
            this.lblJavaJDK.AutoSize = true;
            this.lblJavaJDK.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJavaJDK.Location = new System.Drawing.Point(19, 28);
            this.lblJavaJDK.Name = "lblJavaJDK";
            this.lblJavaJDK.Size = new System.Drawing.Size(189, 20);
            this.lblJavaJDK.TabIndex = 3;
            this.lblJavaJDK.Text = "Instalação Java JDK:";
            // 
            // lblVariavelAndroidHome
            // 
            this.lblVariavelAndroidHome.AutoSize = true;
            this.lblVariavelAndroidHome.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavelAndroidHome.Location = new System.Drawing.Point(19, 131);
            this.lblVariavelAndroidHome.Name = "lblVariavelAndroidHome";
            this.lblVariavelAndroidHome.Size = new System.Drawing.Size(315, 20);
            this.lblVariavelAndroidHome.TabIndex = 2;
            this.lblVariavelAndroidHome.Text = "Variável de ambiente ANDROID_HOME:";
            // 
            // blbAndroidStudio
            // 
            this.blbAndroidStudio.AutoSize = true;
            this.blbAndroidStudio.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbAndroidStudio.Location = new System.Drawing.Point(19, 98);
            this.blbAndroidStudio.Name = "blbAndroidStudio";
            this.blbAndroidStudio.Size = new System.Drawing.Size(144, 20);
            this.blbAndroidStudio.TabIndex = 1;
            this.blbAndroidStudio.Text = "Android Studio:";
            // 
            // lblVariavelJavaHome
            // 
            this.lblVariavelJavaHome.AutoSize = true;
            this.lblVariavelJavaHome.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavelJavaHome.Location = new System.Drawing.Point(19, 60);
            this.lblVariavelJavaHome.Name = "lblVariavelJavaHome";
            this.lblVariavelJavaHome.Size = new System.Drawing.Size(288, 20);
            this.lblVariavelJavaHome.TabIndex = 0;
            this.lblVariavelJavaHome.Text = "Variável de ambiente JAVA_HOME:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tbAVDID
            // 
            this.tbAVDID.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAVDID.Location = new System.Drawing.Point(15, 252);
            this.tbAVDID.Name = "tbAVDID";
            this.tbAVDID.Size = new System.Drawing.Size(516, 29);
            this.tbAVDID.TabIndex = 6;
            // 
            // lblAVDId
            // 
            this.lblAVDId.AutoSize = true;
            this.lblAVDId.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVDId.Location = new System.Drawing.Point(12, 231);
            this.lblAVDId.Name = "lblAVDId";
            this.lblAVDId.Size = new System.Drawing.Size(144, 18);
            this.lblAVDId.TabIndex = 5;
            this.lblAVDId.Text = "Informe o AVD ID:";
            // 
            // lblComandoExecutado
            // 
            this.lblComandoExecutado.AutoSize = true;
            this.lblComandoExecutado.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandoExecutado.Location = new System.Drawing.Point(12, 302);
            this.lblComandoExecutado.Name = "lblComandoExecutado";
            this.lblComandoExecutado.Size = new System.Drawing.Size(200, 18);
            this.lblComandoExecutado.TabIndex = 7;
            this.lblComandoExecutado.Text = "Comando a ser executado:";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutar.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(337, 392);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(194, 51);
            this.btnExecutar.TabIndex = 9;
            this.btnExecutar.Text = "Iniciar Emulador";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            this.btnExecutar.MouseHover += new System.EventHandler(this.btnExecutar_MouseHover);
            // 
            // lblComando
            // 
            this.lblComando.AutoSize = true;
            this.lblComando.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComando.Location = new System.Drawing.Point(12, 329);
            this.lblComando.Name = "lblComando";
            this.lblComando.Size = new System.Drawing.Size(18, 20);
            this.lblComando.TabIndex = 8;
            this.lblComando.Text = " ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 453);
            this.Controls.Add(this.lblComando);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lblComandoExecutado);
            this.Controls.Add(this.tbAVDID);
            this.Controls.Add(this.lblAVDId);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android Utility";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblJavaJDK;
        private System.Windows.Forms.Label lblVariavelAndroidHome;
        private System.Windows.Forms.Label blbAndroidStudio;
        private System.Windows.Forms.Label lblVariavelJavaHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lblAVDId;
        private System.Windows.Forms.Label lblComandoExecutado;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lblRetornoJavaJDK;
        private System.Windows.Forms.Label lblJavaHome;
        private System.Windows.Forms.Label lblAndroidStudio;
        private System.Windows.Forms.Label lblAndroidHome;
        private System.Windows.Forms.FolderBrowserDialog fbdPastaAndroidSDK;
        private System.Windows.Forms.Label lblComando;
        private System.Windows.Forms.TextBox tbAVDID;
    }
}

