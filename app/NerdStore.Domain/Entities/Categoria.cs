using System;
using System.Collections.Generic;

namespace NerdStore.Domain.Entities
{
    public class Categoria : EntityBase
    {
        public Categoria(Guid id, string nome, string codigo)
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
        }

        public string Nome { get; private set; }
        public string Codigo{ get; private set; }

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
