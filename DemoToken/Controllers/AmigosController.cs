using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViaVarejo.Dominio.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViaVarejo.Dominio.Entidades;
using Microsoft.AspNetCore.Authorization;

namespace AmigosApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AmigosController : ControllerBase
    {
        IAmigosService _iamigosService;
        public AmigosController(IAmigosService iamigosService)
        {
            _iamigosService = iamigosService;
        }
        // GET: api/Amigos
        [HttpGet]
        public List<Amigo> Get()
        {
            return _iamigosService.GetAmigos();
        }

        // GET: api/Amigos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        
        // POST: api/Amigos
        [HttpPost]
        public ActionResult<Amigo> PostAmigo(Amigo amigo)
        {
            try
            {
                _iamigosService.InsertAmigo(amigo);
                return Ok();
            }
            catch 
            {

                return BadRequest();
            }

        }

        // PUT: api/Amigos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
