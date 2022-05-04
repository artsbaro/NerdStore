using NerdStore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace NerdStore.Domain.Repositories
{
    public interface ICategoriaRepositorio
    {
        Categoria Obter(Guid id);
        ICollection<Categoria> Obter();
        void Inserir(Categoria categoria);
        void Atualizar(Categoria categoria);
        void Excluir(Categoria categoria);
        void Excluir(Guid id);
    }
}
