using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class EscritorLetra : EscritorBase
    {
        public override void Escrever(int linhas)
        {
            EscreveArquivo(linhas);
        }

        private void EscreveArquivo(int linhas)
        {
            //Declaração do método StreamWriter passando o caminho e nome do arquivo que deve ser salvo
            StreamWriter writer = new StreamWriter(@"c:\temp\letra.txt");
            DateTime ini = DateTime.Now;
            
            for (int i = 0; i < linhas; i++)
            {
                writer.WriteLine(string.Format("{0} - Hello World", i));
            }
            DateTime fim = DateTime.Now;
            writer.WriteLine(ini.ToString("dd/MM/yyyy HH:mm:ss"));
            writer.WriteLine(fim.ToString("dd/MM/yyyy HH:mm:ss"));
            writer.WriteLine(DateTime.Compare(ini, fim));
            writer.Write("FIM");

            writer.WriteLine(); 

            //Fechando o arquivo
            writer.Close();

            //Limpando a referencia dele da memória
            writer.Dispose();
        }
    }
}
