using Microsoft.AspNetCore.Mvc;
using NerdStore.Api.Controllers;
using NerdStore.Application.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NerdStore.Api.V1.Controllers
{
    [Route("v1/[controller]")]
    public class ValuesController : MainController
    {
        private readonly INotificador _notificador;

        public ValuesController(INotificador notificador) : base(notificador)
        {
            _notificador = notificador;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult Get()
        {
            return CustomResponse(new string[] { "value1", "value2" });
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return CustomResponse("Value1");
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            return CustomResponse();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            return CustomResponse();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return CustomResponse();
        }
    }
}
