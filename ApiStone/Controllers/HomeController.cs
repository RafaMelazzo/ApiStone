using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ApiStone.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public dynamic Get()
        {
            return new
            {
                Mensagem = "Bem vindo à API!",
                Documentacao = "https://localhost:44381/swagger/index.html"
            };
        }
    }
}
