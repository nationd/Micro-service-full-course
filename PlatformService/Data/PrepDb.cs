using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app, bool isProd)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProd);
            }
        }

        private static void SeedData(AppDbContext context, bool isProd )
        {
            if(isProd)
            {
                Console.WriteLine("---> Attempting to apply migration");
                try
                {
                    context.Database.Migrate();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"---> Could not run migrations: {ex.Message}");
                }
                
            }

            if(!context.Platforms.Any())
            {
                Console.Write("--> seeding data");
                context.Platforms.AddRange(
                    new Platform() {Name ="Dot Net", Publisher = "Microsoft", Cost = "free"},
                    new Platform() {Name ="Sql Server Express", Publisher = "Microsoft", Cost = "free"},
                    new Platform() {Name ="Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "free"}
                    
                );
                context.SaveChanges();
            }
            else
            {
                Console.Write("--> we already have data");
            }
        }
    }
}