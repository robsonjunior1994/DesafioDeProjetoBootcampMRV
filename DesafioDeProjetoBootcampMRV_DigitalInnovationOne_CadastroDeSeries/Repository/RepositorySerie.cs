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

    }
}
