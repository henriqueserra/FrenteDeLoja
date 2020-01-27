using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeLoja_V001.Bibliotecas
    {
    public class Arquivos
        {
        public string Diretoriodestino { get; set; }
        public string Diretorioorigem { get; set; }

        //public string Extensaoarquivos { get; set; }
        public List<string> Listadearquivos { get; set; }

        /// <summary>
        /// Valor incial Default esta configurado para 1000ms
        /// </summary>
        /// <value>1000</value>
        public int Tentativasleitura { get; set; }

        public bool TestarArquivo(string arquivo)
            {
            string diretorioorigem = Diretorioorigem;
            //string extensao = Extensaoarquivos;
            int tentativas = Tentativasleitura;
            string path = diretorioorigem+arquivo;
            bool teste2 = false;
            int contagem = 1;
            while (contagem<=tentativas&&teste2==false)
                {
                try
                    {
                    string[] balde1 = File.ReadAllLines(path);
                    teste2=true;
                    }
                catch (IOException)
                    {
                    contagem++;
                    teste2=false;
                    }
                }
            if (teste2)
                {
                return true;
                }
            else
                {
                return false;
                }
            }

        public List<string> ListarArquivos(string extensao)
            {
            return Directory.EnumerateFiles(Diretorioorigem, "*"+extensao, SearchOption.TopDirectoryOnly).ToList();
            }

        public string[] CarregaArquivo(string arquivo)
            {
            string diretorio = this.Diretorioorigem;
            //string extensao = this.Extensaoarquivos;
            string path = diretorio+arquivo;
            string[] lido = File.ReadAllLines(path);
            return lido;
            }

        public bool MoverArquivo(string arquivo)
            {
            string pathorigem = Diretorioorigem+arquivo;
            string pathdestino = Diretoriodestino+arquivo;
            if (this.TestarArquivo(arquivo))
                {
                if (File.Exists(pathdestino))
                    {
                    return false;
                    }
                else
                    {
                    File.Move(pathorigem, pathdestino);
                    return true;
                    }
                }
            return false;
            }
        }
    }