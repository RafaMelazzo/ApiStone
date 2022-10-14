using ApiStone.Models;
using ApiStone.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace ApiStone.Controllers
{
    [ApiController]
    [Route("/Clientes")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            var clientes = ClienteSingleton.GetInstancia().Clientes();
            return StatusCode(200, clientes);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            ClienteSingleton.GetInstancia().Adicionar(cliente);
            return StatusCode(201, cliente);
        }
    }
}
