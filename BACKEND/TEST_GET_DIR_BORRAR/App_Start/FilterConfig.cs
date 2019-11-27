using System.Web;
using System.Web.Mvc;

namespace TEST_GET_DIR_BORRAR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
