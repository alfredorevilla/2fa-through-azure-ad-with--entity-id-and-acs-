using System.Web;
using System.Web.Mvc;

namespace _2fa_through_azure_ad_with__entity_id_and_acs_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
