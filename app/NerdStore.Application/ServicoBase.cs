using NerdStore.Application.Interfaces;
using NerdStore.Application.Notificacoes;

namespace NerdStore.Application
{
    public abstract class ServicoBase
    {
        private readonly INotificador _notificador;

        protected ServicoBase(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void NotificarErro(string errorMsg)
        {
            _notificador.Handle(new Notificacao(errorMsg));
        }
    }
}
