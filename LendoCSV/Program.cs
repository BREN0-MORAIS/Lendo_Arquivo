using System;
using System.Collections.Generic;
using System.IO;

namespace LendoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Linhas = new List<string>();
            using (StreamReader arquivo = new StreamReader(@"C:\_DEV\SistemaIntegracao\View\Txt\geo_bairro.csv")) ;
            {
                using (
                StreamReader arquivo = File.OpenText(@"C:\_DEV\SistemaIntegracao\View\Txt\geo_bairro.csv"))
                {
                    string Linha = arquivo.ReadLine();
                    while (true)
                    {
                        if (Linha != null)
                        {
                            Console.WriteLine(Linha);
                            Linha = arquivo.ReadLine();
                            Linhas.Add(Linha);
                        }
                    }
                    foreach (var item in Linhas)
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadKey();
                }
            }
        }  } }
