using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using WebApi.Models;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {


            CreateWebHostBuilder(args).Build().Run();



            var context = new MagazynContext();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
