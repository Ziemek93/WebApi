using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebApi.Models;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {






            CreateWebHostBuilder(args).Build().Run();



            var context = new MagazynContext();

            var studentWithGrade = context.Things.Include(s => s.DocumentsThings)
                                                    .FirstOrDefault();
            Console.WriteLine("XxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine(studentWithGrade);
            Console.ReadKey();
            //foreach(var x in studentWithGrade)
            //{
            //    Console.WriteLine("  xxx   ");
            //}


        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
