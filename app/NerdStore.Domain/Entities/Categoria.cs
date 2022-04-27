using NerdStore.Core.Validations;
using System;
using System.Collections.Generic;

namespace NerdStore.Domain.Entities
{
    public class Categoria : EntityBase
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }
        public Categoria(Guid id, string nome, int codigo)
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
            Validar();
        }

        private void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "Nome não preenchido");
            Validacoes.ValidarSeIgual(Codigo, 0, "Codigo não pode ser igual a zero");
        }

        public ICollection<Produto> Produtos { get; private set; }

        public void SetaListaDeProdutos(ICollection<Produto> produtos)
        {
            Produtos = produtos;
        }

        public void AdicionaProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void RemoveProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

    }
}
