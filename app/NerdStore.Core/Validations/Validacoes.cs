﻿using NerdStore.Core.Exceptions;
using System.Text.RegularExpressions;

namespace NerdStore.Core.Validations
{
    public class Validacoes
    {
        public static void ValidarSeIgual(object objet1, object objet2, string mensagem)
        {
            if (objet1.Equals(objet2)) { throw new DomainException(mensagem); }
        }

        public static void ValidarSeDiferente(object objet1, object objet2, string mensagem)
        {
            if (!objet1.Equals(objet2)) { throw new DomainException(mensagem); }
        }

        public static void ValidarCaracteres(string valor, int maximo, string mensagem)
        {
            var length = valor.Trim().Length;
            if (length > maximo) { throw new DomainException(mensagem); }
        }
        public static void ValidarCaracteres(string valor, int minimo, int maximo, string mensagem)
        {
            var lenght = valor.Trim().Length;
            if (lenght < minimo || lenght > maximo) { throw new DomainException(mensagem); }
        }

        public static void ValidarExpressao(string pattern, string valor, string mensagem)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(valor)) { throw new DomainException(mensagem); }
        }

        public static void ValidarSeVazio(string valor, string mensagem)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new DomainException(mensagem);
        }

        public static void ValidarSeNulo(object objet1, string mensagem)
        {
            if (objet1 == null) { throw new DomainException(mensagem); }
        }

        public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) { throw new DomainException(mensagem); }
        }

        public static void ValidarMinimoMaximo(float valor, float minimo, float maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) { throw new DomainException(mensagem); }
        }

        public static void ValidarMinimoMaximo(decimal valor, decimal minimo, decimal maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) { throw new DomainException(mensagem); }
        }

        public static void ValidarSeMenorIgualMinimo(decimal valor, int minimo, string mensagem)
        {
            if (valor <= minimo) { throw new DomainException(mensagem); }
        }

        public static void ValidarSeMenorQue(decimal valor, decimal minimo, string mensagem)
        {
            if (valor < minimo)
                throw new DomainException(mensagem);
        }

        public static void ValidarSeFalso(bool boolValor, string mensagem)
        {
            if (boolValor) { throw new DomainException(mensagem); }
        }

        public static void ValidarSeVerdadeiro(bool boolValor, string mensagem)
        {
            if (!boolValor) { throw new DomainException(mensagem); }
        }
    }
}
