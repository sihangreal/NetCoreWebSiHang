using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace NetCoreWebSiHang
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var host = new WebHostBuilder()
            // .UseKestrel()
            // .UseContentRoot(Directory.GetCurrentDirectory())
            // .UseIISIntegration()
            // .UseUrls("http://*:9100")//监听来自所有ip的9100端口的请求
            // .UseStartup<Startup>()
            // .Build();

            //host.Run();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
