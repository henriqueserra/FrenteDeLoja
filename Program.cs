using FrenteDeLoja_V001.Bibliotecas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeLoja_V001
    {
    internal class Program
        {
        private static void Main(string[] args)
            {
            Arquivos arquivos = new Arquivos();
            arquivos.Diretorioorigem=@"E:\Balde\";
            //arquivos.Extensaoarquivos=".xml";
            arquivos.Tentativasleitura=1000;

            var diretorios = arquivos.ListarArquivos(".xml");

            foreach (var item in diretorios)
                {
                Console.WriteLine(item);
                }

            //var resultado = arquivos.TestarArquivo("AD35190432538916000196590006371110000133339717");

            //var arquivoxml = arquivos.CarregaArquivo("AD35190432538916000196590006371110000133339717");
            //foreach (var linha in arquivoxml)
            //    {
            //    Console.WriteLine(linha);
            //    }

            Console.ReadLine();
            }
        }
    }