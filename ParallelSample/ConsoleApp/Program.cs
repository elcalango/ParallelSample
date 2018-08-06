using Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = Console.ReadKey().Key.ToString();
            Console.Write(opcao);

            List<EscritorBase> listaEventos = new List<EscritorBase>();

            foreach (var escritor in Dicionario.ClasseEscritor)
            {
                listaEventos.Add((EscritorBase)Activator.CreateInstance(Dicionario.ClasseEscritor[escritor.Key]));
            }
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            listaEventos.ForEach(a => a.Escrever(5000000));
            stopwatch.Stop();

            Console.WriteLine($"Tempo passado: {stopwatch.Elapsed}");

            stopwatch.Restart();
            Parallel.ForEach(listaEventos, a => a.Escrever(5000000));
            Console.WriteLine($"Tempo passado: {stopwatch.Elapsed}");
            stopwatch.Stop();

            Console.WriteLine("FIM");
            Console.ReadKey();
        }
    }
}
