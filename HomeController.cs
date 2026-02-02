using Microsoft.AspNetCore.Mvc;

namespace aspaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("hai")]
        public string Hai([FromQuery] string nama)
        {
            return "halo, " + nama + "!";
        }
    }
}
