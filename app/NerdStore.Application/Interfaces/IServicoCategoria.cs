using NerdStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Application.Interfaces
{
    public interface IServicoCategoria
    {
        Categoria Obter(Guid id);
        Categoria Obter(int codigo);
        ICollection<Categoria> Obter();
        void Inserir(Categoria categoria);
        void Atualizar(Categoria categoria);
        void Excluir(Categoria categoria);
        void Excluir(Guid id);
    }
}
