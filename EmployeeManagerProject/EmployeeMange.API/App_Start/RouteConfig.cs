using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeeMange.API
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }// thằng này quy định controller và action dau tien đc goi
            );
        }
    }
}
