using DesafioDeProjetoBootcampMRV.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeProjetoBootcampMRV.Repository
{
    class RepositorySerie : IRepository<Serie>
    {
        private List<Serie> ListaDeSeries = new List<Serie>();
        public void Add(Serie serie)
        {
            ListaDeSeries.Add(serie);
        }

        public void Atualizar(int id, Serie serie)
        {
            ListaDeSeries[id] = serie;
        }

        public void Excluir(int id)
        {
            ListaDeSeries[id].Excluir();

        }

        public List<Serie> Lista()
        {
            return ListaDeSeries;
        }

        public Serie RetornarPorId(int id)
        {
            return ListaDeSeries[id];
        }
    }
}
