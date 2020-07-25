using System.Web;
using System.Web.Mvc;

namespace WEBAPP_API_REST_NET_SP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
