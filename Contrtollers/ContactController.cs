using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingSecondApp.Contrtollers
{
    public class ContactController : Controller
    {
        public string Index(string? id) 
            => $"Contact page {id}";
    }
}
