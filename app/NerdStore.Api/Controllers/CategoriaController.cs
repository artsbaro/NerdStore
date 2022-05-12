using Microsoft.AspNetCore.Mvc;
using NerdStore.Application.Interfaces;
using NerdStore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace NerdStore.Api.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IServicoCategoria _servicoCategoria;
        public CategoriaController(IServicoCategoria servicoCategoria)
        {
            _servicoCategoria = servicoCategoria;
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
            return Ok(obj);
        }

        //[HttpGet("{codigo}")]
        //public ActionResult Get(int codigo) // Inplementacao 'correta'
        //{
        //    try
        //    {
        //        if (codigo == 0)
        //        {
        //            return BadRequest("Código inválido");
        //        }

        //        var obj = _servicoCategoria.Obter(codigo);
        //        return Ok(obj);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new StatusCodeResult(500);
        //    }
        //}

        [HttpGet("{codigo}")]
        public ActionResult Get(int codigo) // Inplementacao 'correta'
        {
            try
            {
                var list = new List<Categoria>();

                for (int i = 0; i < 5; i++)
                {
                    var obj = _servicoCategoria.Obter(codigo);
                    list.Add(obj);
                }
                return Ok(list);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
