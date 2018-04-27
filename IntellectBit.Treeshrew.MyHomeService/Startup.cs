﻿using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(IntellectBit.Treeshrew.MyHomeService.Startup))]
namespace IntellectBit.Treeshrew.MyHomeService
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            System.IO.File.WriteAllText(@"d:\saran\startup.txt", "Started");
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}