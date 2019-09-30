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
   
    [Route("api/[controller]")]
    [ApiController]
    public class AmigosController : ControllerBase
    {
        IAmigosService _iamigosService;
        public AmigosController(IAmigosService iamigosService)
        {
            _iamigosService = iamigosService;
        }

        [Authorize]
        public List<Amigo> Proximos(Amigo amigo)
        {
            return _iamigosService.proximos(amigo);
        }


        [HttpPost]
        public  List<Amigo> GetUsers()
        {
            //return Json(new
            //{
            var AmigosList = from u in _iamigosService.GetAmigos()
                             select new { Nome = u.Nome, Id = u.Id };

            //});
            var amigos = _iamigosService.GetAmigos();
            return amigos;
        }



        // GET: api/Amigos
        [HttpGet]
        public List<Amigo> Get()
        {
            System.Threading.Thread.Sleep(5000);

            return _iamigosService.GetAmigos();
        }

        // GET: api/Amigos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }


        // POST: api/Amigos
        [Authorize]
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
        [Authorize]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [Authorize]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
