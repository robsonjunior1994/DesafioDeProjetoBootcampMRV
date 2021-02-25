using DesafioDeProjetoBootcampMRV.Models;
using DesafioDeProjetoBootcampMRV.Services;
using System;
using System.Collections.Generic;

namespace DesafioDeProjetoBootcampMRV
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Serie> Series = new List<Serie>();
            string opcao = "";

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("1 - Listar séries");
                        break;

                    case "2":
                        Console.WriteLine("Escolha o gênero por numero:");
                        ServiceSerie.Adicionar(Series);
                        break;

                    case "3":
                        Console.WriteLine("3 - Atualizar série");
                        break;

                    case "4":
                        Console.WriteLine("4 - Excluir série");
                        break;

                    case "5":
                        Console.WriteLine("5 - Visualizar série");
                        break;

                    case "C":
                        Console.WriteLine("C - Limpar Tela");
                        break;

                    case "X":
                        Console.WriteLine("X - SAIR");
                        break;

                }

                opcao = ObterOpcaoDoUsuario();
            }
        }

        private static string ObterOpcaoDoUsuario()
        {
            Console.WriteLine("Digite uma opção:");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - SAIR");
            return Console.ReadLine();
        }
    }
}
