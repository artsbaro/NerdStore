using System;

namespace NerdStore.Domain.Entities
{
    public class Produto : EntityBase
    {
        public Produto(Guid id, 
            Guid categoriaId, 
            string nome, 
            string descricao, 
            bool ativo, 
            decimal valor, 
            DateTime dataCadastro, 
            string imagem, 
            int quantidadeEstoque, 
            Dimensoes dimensoes, 
            Categoria categoria)
        {
            Id = id;
            CategoriaId = categoriaId;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            DataCadastro = dataCadastro;
            Imagem = imagem;
            QuantidadeEstoque = quantidadeEstoque;
            Dimensoes = dimensoes;
            Categoria = categoria;
        }


        public Guid CategoriaId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Imagem { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public Dimensoes Dimensoes { get; private set; }
        public Categoria Categoria { get; private set; }
    }
}