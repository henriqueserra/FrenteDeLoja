using Library;
using ModelosXml;
using System;

namespace FrenteDeLoja_V001
    {
    internal class Program
        {
        private static void Main()
            {
            var listadearquivos = Library.NfeDadosBasicos.CarregaListaArquivos(@"E:\Balde\");
            foreach (var arquivo in listadearquivos)
                {
                if (!Library.NfeDadosBasicos.PodeSerLido(arquivo))
                    {
                    Console.WriteLine("Aqruivo {0}, não pode ser lido ", arquivo);
                    }
                ModelosXml.NfeDadosBasicos nota = new ModelosXml.NfeDadosBasicos(arquivo);
                if (nota.CarregaDados())
                    {
                    Console.WriteLine("Lida nota : {0}", nota.NCFe);
                    if (!Library.NfeDadosBasicos.TestaDB(nota.NCFe))
                        {
                        Console.WriteLine("A nota {0}, pode ser incluída na base {1}", nota.NCFe, nota.Data);
                        string comandoparainclusao = ModelosXml.NfeDadosBasicos.GeraComandoInclusao(nota);
                        if (Library.NfeDadosBasicos.ExecutaSql(comandoparainclusao))
                            {
                            Console.WriteLine("Nota incluida com sucesso");
                            }
                        }
                    else
                        {
                        Console.WriteLine("A nota {0}, já esta no Banco de dados e não será processada", nota.NCFe);
                        }
                    }
                else
                    {
                    Console.WriteLine("Item {0} não foi processado ", nota.NCFe);
                    Console.ReadLine();
                    }
                }

            Console.ReadLine();
            }
        }
    }