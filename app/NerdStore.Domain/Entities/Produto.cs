using NerdStore.Core.Validations;
using NerdStore.Domain.VO;
using System;

namespace NerdStore.Domain.Entities
{
    public class Produto : EntityBase
    {
        public Guid CategoriaId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public string Imagem { get; private set; }
        public uint QuantidadeEstoque { get; private set; }
        public Dimensoes Dimensoes { get; private set; }
        public Categoria Categoria { get; private set; }

        public Produto(Guid id,
            Guid categoriaId,
            string nome,
            string descricao,
            bool ativo,
            decimal valor,
            DateTime dataCadastro,
            string imagem,
            uint quantidadeEstoque,
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

            Validar();
        }

        private void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "Nome não preenchido");
            Validacoes.ValidarSeVazio(Descricao, "Descricao não preenchido");
            Validacoes.ValidarSeIgual(CategoriaId, Guid.Empty ,"Categoria não preenchido");
            Validacoes.ValidarSeMenorQue(Valor, 1, "Valor não pode ser menor do que 1");
            Validacoes.ValidarSeVazio(Imagem, "Imagem não preenchido");
        }

        public void Ativar() => Ativo = true;

        public void Desativar() => Ativo = false;

        public void AlterarCategoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }

        public void AlterarDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentNullException("Descricao", "Descricao nao preenchido");

            Descricao = descricao;
        }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade <= 0)
                return;

            if(!PossuiEstoque(quantidade))
                throw new ArgumentException("QuantidadeEstoque", "Estoque insuficiente");

            QuantidadeEstoque -= (uint)quantidade;
        }

        private bool PossuiEstoque(int quantidade)
        {
            return QuantidadeEstoque >= quantidade;
        }

        public void ReporEstoque(int quantidade)
        {
            if (quantidade <= 0)
                return;

            QuantidadeEstoque += (uint)quantidade;
        }
    }
}