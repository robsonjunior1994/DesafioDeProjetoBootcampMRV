using DesafioDeProjetoBootcampMRV.Models;
using DesafioDeProjetoBootcampMRV.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeProjetoBootcampMRV.Services
{
     static class ServiceSerie
    {
         public static void Adicionar(RepositorySerie Series)
        {
            ListarGeneros();

            int genero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da série:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o ano da série:");
            string ano = Console.ReadLine();

            Console.WriteLine("Digite a descrição da série:");
            string descricao = Console.ReadLine();

            Serie serie = new Serie((Genero)genero, titulo, descricao, ano);

            Series.Add(serie);

            return;
        }

        private static void ListarGeneros()
        {
            int cont = 0;
            foreach (var item in Enum.GetValues(typeof(Genero)))
            {
                //Console.WriteLine($"{item}, {Enum.GetName(typeof(Genero),item)}");
                cont++;
                Console.WriteLine($"#{cont} - {item}");
            }
        }

        public static void Listar(RepositorySerie Series)
        {
            string status;

            foreach (var s in Series.Lista())
            {
                Console.WriteLine($"#ID: {s.Id}, Título: {s.Titulo}, Gênero: {s.Genero}," +
                    $" Descrição: {s.Descricao}, status: {status = (s.Deletado == true ? "deletada" : "ativa")}");  
            }
        }

        public static void Excluir(int id, RepositorySerie Series)
        {
            Series.Excluir(id);
        }

        public static Serie BuscarPorId(int id, RepositorySerie Series)
        {
            string status;
            var s = Series.RetornarPorId(id);
            Console.WriteLine($"#ID: {s.Id}, Título: {s.Titulo}, Gênero: {s.Genero}," +
                    $" Descrição: {s.Descricao}, status: { status = (s.Deletado == true ? "deletada" : "ativa")}");

            return s;
        }

        public static void Atualizar(int id, RepositorySerie Series)
        {
            var serie = BuscarPorId(id, Series);

            ListarGeneros();
            int genero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da série:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o ano da série:");
            string ano = Console.ReadLine();

            Console.WriteLine("Digite a descrição da série:");
            string descricao = Console.ReadLine();

            serie.Atualizar(titulo,descricao,ano,(Genero)genero);

            Series.Atualizar(id, serie);
        }
    }
}
