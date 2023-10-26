using Microsoft.AspNetCore.Mvc;
using ToDoList2.Core.Common.Exceptions;

namespace ToDoList2.Core.Controllers
{
    [Route("/jobs")]
    public class IphoneController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            throw new Exception();
        }
    }
}
