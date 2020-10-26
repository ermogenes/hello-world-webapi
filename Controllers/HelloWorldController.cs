using Microsoft.AspNetCore.Mvc;
using hello_world_webapi.Models;

namespace hello_world_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public HelloWorldModel Get()
        {
            var resultado = new HelloWorldModel
            {
                mensagem = "Hello Dev Web!",
                url = "https://github.com/ermogenes/aulas-programacao-web/"
            };
            return resultado;
        }
    }
}