using System.Web;
using System.Web.Mvc;

namespace CSC.IT.Store.CustomerFacing
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ErrorHandler.AiHandleErrorAttribute());
        }
    }
}
