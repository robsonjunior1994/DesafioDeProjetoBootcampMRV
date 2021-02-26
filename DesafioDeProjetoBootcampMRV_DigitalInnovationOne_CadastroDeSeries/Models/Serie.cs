using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeProjetoBootcampMRV.Models
{
    public class Serie : Midia
    {
        public static int Index { get; private set; }
        public Genero Genero { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public string Ano { get; private set; }
        public bool Deletado { get; private set; }

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
