using System.Web;
using System.Web.Mvc;

namespace beSecure_AV_Mangement_System
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
