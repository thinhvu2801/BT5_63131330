﻿using System.Web;
using System.Web.Mvc;

namespace BT5_63131330
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
