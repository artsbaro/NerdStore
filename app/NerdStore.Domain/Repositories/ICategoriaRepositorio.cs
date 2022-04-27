using NerdStore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace NerdStore.Domain.Repositories
{
    public interface ICategoriaRepositorio
    {
        public Categoria Obter(Guid id);
        public ICollection<Categoria> Obter();
        public void Inserir(Categoria categoria);
        public void Atualizar(Categoria categoria);
        public void Excluir(Categoria categoria);
        public void Excluir(Guid id);
    }
}
