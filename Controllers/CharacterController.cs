using Microsoft.AspNetCore.Mvc;


namespace Rpg___Fiap.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character Kinigth = new Character();
        [HttpGet]
        public ActionResult<Character> get()
        {
            return Ok(Kinigth);
        }
    }
}
