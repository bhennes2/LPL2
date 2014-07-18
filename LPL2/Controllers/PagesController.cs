using System.Web;
using System.Web.Mvc;

namespace LPL2.Controllers
{
    public class PagesController : Controller
    {
        //
        // GET: /Pages/
        public string Index()
        {
            return "I am here";
        }
        public string Welcome()
        {
            return "Welcome!";
        }
	}
}