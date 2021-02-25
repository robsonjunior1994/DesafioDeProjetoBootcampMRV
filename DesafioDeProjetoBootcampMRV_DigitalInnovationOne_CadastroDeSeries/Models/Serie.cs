using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeProjetoBootcampMRV.Models
{
    public class Serie : Midia
    {
        private static int Index { get; set; }
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private string Ano { get; set; }
        private bool Deletado { get; set; }

        public Serie(Genero genero, string titulo, string descricao, string ano)
        {
            Index++;
            this.Id = Index;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Deletado = false;
        }

    }
}
