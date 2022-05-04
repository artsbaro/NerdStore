using NerdStore.Domain.Entities;
using NerdStore.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Infra.Repositories
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private ICollection<Categoria> _categorias = new List<Categoria>
        {
            new Categoria("Desktop", 1),
            new Categoria("Notebooks", 2),
            new Categoria("Tablets", 3),
            new Categoria("Smartphones", 4),
            new Categoria("Mascaras", 5),
            new Categoria("TVs", 6),
            new Categoria("Som", 7),
            new Categoria("Papelaria", 8),
            new Categoria("Vestuário", 9),
            new Categoria("Tenis", 10),
            new Categoria("Sapatos", 11),
            new Categoria("Masculino", 12),
            new Categoria("Feminino", 13)
        };

        public void Atualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Categoria Obter(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Categoria> Obter()
        {
            return _categorias;
        }
    }
}
