using Microsoft.AspNetCore.Mvc;

namespace FirstCoreMVCApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("Hello")]
        public string Index()
        {
            return "From Index Hello World";
        }
        
        public string Watch()
        {            
            return "Error";
        }
    }
}
