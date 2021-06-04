using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidUtility
{
    public class Config
    {
        private static string _file = "avd.cfg";

        //Método que cria o arquivo txt caso ele não exista, Void por que não retorna nada.
        private static void verifyFile()
        {
            if (!File.Exists(_file))//Verifica se o arquivo existe, retorna true, neguei a condição, então se o arquivo não existir ele entra no IF.
            {
                File.Create(_file);//Cria um arquivo, no caso, cria o arquivo informado na variável _file.
            }
        }
        public static void writeData(String avd_id)
        {
            verifyFile(); //Chama nosso método que cria o arquivo caso ele não exista.

            StreamWriter streamW = new StreamWriter(_file);
            /*Criamos um novo objeto do tipo StreamWriter, passamos o nome do nosso arquivo.
             * o true informa que deve continuar gravando no arquivo, isto quer dizer que ele não vai limpar e escrever tudo de novo.
             * Se remover o true toda vez que for gravar uma informação nosso arquivo será limpado e as informações anteriores serão perdidas.
             */

            streamW.WriteLine("AVD_ID=" + avd_id);
            /*Através do objeto streamW acessamos o método WriteLine e passamos os textos que queremos gravar.
             * 
             */

            streamW.Close();//Sempre que terminarem de ler e gravar em um arquivo é necessário fecha-lo, isto evita mutios erros.
        }

        public static string readFile()
        {

            string text = ""; //Criamos uma variável que vai armazenar o resultado da nossa consulta no arquivo.

            verifyFile(); //Chamamos novamente nosso método, caso o arquivo não exista ele cria, pois se o arquivo não existir e ele tentar ler vai travar o sistema

            StreamReader streamR = new StreamReader(_file); //Criamos um novo objeto que acessa os métods de leitura, passamos o arquivo que quremos ler.

            text = streamR.ReadLine(); // Variavel Text recebe a leitura do arquivo.
            /*Neste exemplo ele vai ler apenas a primeira linha.
             * Caso queria retornar todas, basta usar.
             * 
                while(streamR.EndOfStream == false){
                 text += streamR.ReadLine();
                }
             * 
             * Se for retornar todos os valores, o recomendavel é que grave cada linha em um vetor.
             */

            streamR.Close(); // Finaliza o uso do nosso arquivo.

            return text; //Retorna nossa variável com o texto do arquivo.
        }
    }
}
