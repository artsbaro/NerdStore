﻿namespace NerdStore.Application.Notificacoes
{
    // Domain Notification
    public class Notificacao
    {
        public string Mensagem { get; }
        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
