﻿using System.Web;
using System.Web.Mvc;

namespace Biztek.Paisadeal.App.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
