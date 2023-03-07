using Microsoft.AspNetCore.Routing.Constraints;

namespace MvcRoutingSecondApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            /*
            https://localhost:7212
            controller = Home, action = Index

            https://localhost:7212/About
            controller  = About, action = Index

            https://localhost:7212/Contact/Map
            controller = Contact, action = Map

            */

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{category}/{date}/{id}",
                constraints: new { category = new AlphaRouteConstraint(), 
                                   date = new DateTimeRouteConstraint(),
                                   id = new IntRouteConstraint() }
                );

            //app.MapControllerRoute(
            //    name: "userinfo",
            //    pattern: "{controller=Home}/{action=About}/{name}/{age}"
            //    );
            //app.MapControllerRoute(
            //    name: "about",
            //    pattern: "{name}/{age}",
            //    defaults: new { controller = "Home", action = "About" }
            //    );
            //app.MapControllerRoute(
            //    name: "actions",
            //    pattern: "{action}",
            //    defaults: new { controller = "Home", action = "Index" }
            //    );

            //app.MapControllerRoute(
            //    name: "static",
            //    pattern: "api/{controller}/{action}/{id}"
            //    );


            app.Run();
        }
    }
}