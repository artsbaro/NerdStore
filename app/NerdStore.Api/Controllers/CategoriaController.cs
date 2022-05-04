using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Domain.Entities;
using NerdStore.Domain.Repositories;
using NerdStore.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace NerdStore.Api.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepositorio _repositorio;
        public CategoriaController(ICategoriaRepositorio repositorio)
        {
            _repositorio = repositorio;
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
            var obj = _repositorio.Obter();
            return Ok(obj);
        }

        [HttpGet("{id}")]
        public ActionResult Get(Guid id) // Inplementacao 'correta'
        {
            try
            {
                if (id == Guid.Empty)
                {
                    return BadRequest("Id inválido");
                }

                var obj = _repositorio.Obter(id);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
