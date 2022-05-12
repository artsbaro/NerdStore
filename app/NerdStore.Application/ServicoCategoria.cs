using NerdStore.Application.Interfaces;
using NerdStore.Domain.Entities;
using NerdStore.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace NerdStore.Application
{
    public class ServicoCategoria : IServicoCategoria
    {
        private readonly ICategoriaRepositorio _repositorio;

        public ServicoCategoria(ICategoriaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

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
            return _repositorio.Obter(id);
        }

        public Categoria Obter(int codigo)
        {
            return _repositorio.Obter(codigo);
        }

        public ICollection<Categoria> Obter()
        {
            return _repositorio.Obter();
        }
    }
}
