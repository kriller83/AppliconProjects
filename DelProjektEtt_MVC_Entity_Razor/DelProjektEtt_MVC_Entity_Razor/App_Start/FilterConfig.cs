using System.Web;
using System.Web.Mvc;

namespace DelProjektEtt_MVC_Entity_Razor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
