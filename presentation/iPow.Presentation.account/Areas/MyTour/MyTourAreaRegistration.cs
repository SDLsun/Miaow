﻿using System.Web.Mvc;

namespace Miaow.Presentation.account.Areas.MyTour
{
    public class MyTourAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MyTour";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "MyTour_default",
                "MyTour/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, null,
                new string[] { "Miaow.Presentation.account.Areas.MyTour" }
            );
        }
    }
}
