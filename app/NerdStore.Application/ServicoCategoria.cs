using NerdStore.Application.Interfaces;
using NerdStore.Domain.Entities;
using NerdStore.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace NerdStore.Application
{
    public class ServicoCategoria : ServicoBase, IServicoCategoria
    {
        private readonly ICategoriaRepositorio _repositorio;
        private readonly INotificador _notificador;

        public ServicoCategoria(ICategoriaRepositorio repositorio, 
            INotificador notificador) : base(notificador)
        {
            _repositorio = repositorio;
            _notificador = notificador;
        }

        public void Atualizar(Categoria categoria)
        {
            
        }

        public void Excluir(Categoria categoria)
        {
            
        }

        public void Excluir(Guid id)
        {
            
        }

        public void Inserir(Categoria categoria)
        {
            if (categoria.Id == Guid.Empty)
                NotificarErro("Id inválido");

            if (string.IsNullOrWhiteSpace(categoria.Nome))
                NotificarErro("Nome não preenchido");

        }

        public Categoria Obter(Guid id)
        {
            if (id == Guid.Empty)
            {
                NotificarErro("Id inválido");
            }

            return _repositorio.Obter(id);
        }

        public Categoria Obter(int codigo)
        {
            if (codigo == 0)
            {
                NotificarErro("Código inválido");
                return null;
            }
            

            return _repositorio.Obter(codigo);
        }

        public ICollection<Categoria> Obter()
        {
            return _repositorio.Obter();
        }
    }
}
