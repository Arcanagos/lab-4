using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Models
{
    public class DBSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DatabaseContext(serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>()))
            {
                if (context.Users.Any())
                {
                    return;
                }

                context.Users.Add(new DatabaseClass
                {
                    FirstName = "Jan",
                    LastName = "Rodzyń",
                    Age = 62,
                    City = "Warsaw"
                });
                context.Users.Add(new DatabaseClass
                {
                    FirstName = "Adam",
                    LastName = "Grudziński",
                    Age = 29,
                    City = "Cracov"
                });
                context.Users.Add(new DatabaseClass
                {
                    FirstName = "Rafał",
                    LastName = "Kalasza",
                    Age = 22,
                    City = "Lipinki Łużyckie"
                });
                context.Users.Add(new DatabaseClass
                {
                    FirstName = "Barbara",
                    LastName = "Kaszub",
                    Age = 25,
                    City = "Legnica"
                });
                context.Users.Add(new DatabaseClass
                {
                    FirstName = "Anna",
                    LastName = "Krokiet",
                    Age = 36,
                    City = "Leipzig"
                });
                context.SaveChanges();
            }
        }
    }
}
