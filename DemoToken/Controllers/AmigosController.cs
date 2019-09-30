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

        // GET: api/Amigos
        [HttpGet]
        public List<Amigo> Get()
        {

            return _iamigosService.GetAmigos();
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


    //[HttpPost]
    //public List<Amigo> GetUsers()
    //{
    //    //return Json(new
    //    //{
    //    var AmigosList = from u in _iamigosService.GetAmigos()
    //                     select new { Nome = u.Nome, Id = u.Id };

    //    //});
    //    var amigos = _iamigosService.GetAmigos();
    //    return amigos;
    //}


    public class Resposta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
