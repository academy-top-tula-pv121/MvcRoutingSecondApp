using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingSecondApp.Contrtollers
{
    public class HomeController : Controller
    {
        public string Index(int id) => $"Home page {id}";
        public string About(string name, int age) 
            => $"About page {name} {age}";

    }
}
