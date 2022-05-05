using Microsoft.AspNetCore.Mvc;
using Mobilography.Data;
using System.Linq;

namespace Task1.Controllers
{
    [ApiController]
    public class MultiplicationController : ControllerBase
    {
        private ApplicationDbContext _ctx;

        public MultiplicationController(ApplicationDbContext ctx) {
            _ctx = ctx;
        }

        [HttpGet]
        [Route("Check")]
        public IActionResult Check(int a, int b)
        {
            return new JsonResult(new { result = _ctx.MultiplicationResults.Any(x => x.Result == a * b) });
        }
    }
}
