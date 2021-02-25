using DesafioDeProjetoBootcampMRV.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeProjetoBootcampMRV.Repository
{
    public interface IRepository<T>
    {
        void Add(Serie serie);
    }
}
