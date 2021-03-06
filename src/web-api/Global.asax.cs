﻿using System;
using System.Net.Sockets;
using System.Web;
using System.Web.Http;
using Serilog;
using Serilog.Sinks.Udp.TextFormatters;

namespace Sample
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Udp(
                    "localhost",
                    7071,
                    AddressFamily.InterNetwork,
                    new Log4jTextFormatter())
                .WriteTo.Debug()
                .CreateLogger();

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
