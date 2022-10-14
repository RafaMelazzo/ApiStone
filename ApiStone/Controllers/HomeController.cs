using ApiStone.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace ApiStone.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private DbContexto db;
        public HomeController(DbContexto _db)
        {
            this.db = _db;
        }

        //[HttpGet]
        //[Route("/")]
        //public dynamic Get()
        //{
        //    return new
        //    {
        //        Mensagem = "Bem vindo a API!",
        //        Documentacao = "https://localhost:44381/swagger/index.html"
        //    };
        //}


        [HttpGet]
        [Route("/")]
        public ActionResult Get()
        {
            return StatusCode(200, new
            {
                Mensagem = "Bem vindo a API",
                Documentacao = "https://localhost:44381/swagger/index.html"
            });
        }
    }
}