using DesafioDeProjetoBootcampMRV.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeProjetoBootcampMRV.Repository
{
    public interface IRepository<T>
    {
        void Add(Serie serie);
        List<T> Lista();
        void Excluir(int id);
        Serie RetornarPorId(int id);
        void Atualizar(int id, Serie serie);
    }
}
