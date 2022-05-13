using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NerdStore.Application.Interfaces;
using NerdStore.Application.Notificacoes;
using System;
using System.Linq;


namespace NerdStore.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotificador _notificador;

        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(
                    new
                    {
                        Success = true,
                        Data = result
                    });
            }

            return BadRequest(
                new
                {
                    Success = false,
                    Erros = _notificador.ObterNotificacoes().Select(n => n.Mensagem)
                });
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid) NotificaErroModelinvalida(modelState);
            return CustomResponse();
        }

        protected void NotificaErroModelinvalida(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                var errorMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotificarErro(errorMsg);
            }
        }

        protected void NotificarErro(string errorMsg)
        {
            _notificador.Handle(new Notificacao(errorMsg));
        }

        private bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }
    }
}
