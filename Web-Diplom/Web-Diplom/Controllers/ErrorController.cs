using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_Diplom.Controllers
{
	public class ErrorController : Controller
	{
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
