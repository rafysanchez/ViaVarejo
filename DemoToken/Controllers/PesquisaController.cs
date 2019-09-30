using ViaVarejo.Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;
using ViaVarejo.Dominio.Entidades;
using System.Collections.Generic;

namespace AmigosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesquisaController : ControllerBase
    {
        IAmigosService _iamigosService;

        public PesquisaController(IAmigosService iamigosService)
        {
            _iamigosService = iamigosService;
        }

        [HttpGet]
        public List<Amigo> Get(int Id)
        {
            
            return _iamigosService.proximos(Id);
        }

    }
}