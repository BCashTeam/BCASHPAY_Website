using System.Web;
using System.Web.Mvc;

namespace Presentation.BcashPay.v2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
