using Microsoft.AspNetCore.Mvc;
using NerdStore.Api.Controllers;
using NerdStore.Application.Interfaces;
using NerdStore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace NerdStore.Api.V1.Controllers
{
    [Route("v1/[controller]")]

    public class CategoriaController : MainController
    {
        private readonly IServicoCategoria _servicoCategoria;
        private readonly INotificador _notificador;

        public CategoriaController(IServicoCategoria servicoCategoria, INotificador notificador) : base(notificador)
        {
            _servicoCategoria = servicoCategoria;
            _notificador = notificador;
            // inst A
        }

        //[HttpGet]
        //public ICollection<Categoria> Get()
        //{
        //    CategoriaRepositorio repositorio = new CategoriaRepositorio(); // Criando uma dependencia, acoplando (SOLID)
        //    return repositorio.Obter();
        //}

        //[HttpGet]
        //public ICollection<Categoria> Get() // Inplementacao 'correta'
        //{
        //    return _repositorio.Obter();
        //}

        [HttpGet]
        public ActionResult Get() // Inplementacao 'correta'
        {
            var obj = _servicoCategoria.Obter();
            return CustomResponse(obj);
        }

        [HttpGet("{codigo}")]
        public ActionResult Get(int codigo) // Inplementacao 'correta'
        {
            try
            {
                if (codigo == 0)
                {
                    NotificarErro("Codigo inválido");
                    return CustomResponse();
                }

                var obj = _servicoCategoria.Obter(codigo);
                return CustomResponse(obj);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
