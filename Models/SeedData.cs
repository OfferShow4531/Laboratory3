using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Laboratory6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratory6.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AuthorizationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AuthorizationContext>>()))
            {
                // Look for any movies.
                if (context.MarsControllers.Any())
                {
                    return;   // DB has been seeded
                }

                context.MarsControllers.AddRange(
                   
                    new MarsController
                    {
                        Login = "JamesBond",
                        Password = "007",
                        Email = "Agent007@gmail.com",
                        Number = 0000007,
                        Country = "USA,Washington"
                    }

                   
                );
                context.SaveChanges();
            }
        }
    }
}
