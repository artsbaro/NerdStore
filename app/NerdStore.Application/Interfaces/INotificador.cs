using NerdStore.Application.Notificacoes;
using System.Collections.Generic;

namespace NerdStore.Application.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
