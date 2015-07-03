﻿using System.Web.Mvc;

namespace CSoft.WebApp.Areas.CodeMaticModule
{
    public class CodeMaticModuleAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "CodeMaticModule";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                this.AreaName + "_Default",
                this.AreaName + "/{controller}/{action}/{id}",
                new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "CSoft.WebApp.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}
