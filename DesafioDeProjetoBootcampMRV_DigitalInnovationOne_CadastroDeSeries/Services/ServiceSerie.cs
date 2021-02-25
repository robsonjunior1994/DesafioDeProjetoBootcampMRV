using DesafioDeProjetoBootcampMRV.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeProjetoBootcampMRV.Services
{
     static class ServiceSerie
    {
         public static void Adicionar(List<Serie> Series)
        {
            int cont = 0;
            foreach (var item in Enum.GetValues(typeof(Genero)))
            {
                //Console.WriteLine($"{item}, {Enum.GetName(typeof(Genero),item)}");
                cont++;
                Console.WriteLine($"#{cont} - {item}");
            }
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
    }
}
