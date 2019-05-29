using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcanAktepe.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ArcanAktepe.Data
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ArcanDbContext>();


                // Add Customers
                var arcan = new Customer { Name = "Arcan Aktepe" };

                var emre = new Customer { Name = "Emre Ayberk Kaymaz" };

                var okan = new Customer { Name = "Okan Yazıcı" };

                context.Customers.Add(arcan);
                context.Customers.Add(emre);
                context.Customers.Add(okan);

                // Add Author
                var tolkien = new Author
                {
                    Name = "J. R. R. Tolkien",
                    Books = new List<Book>()
                {
                    new Book { Title = "The Lord of the Rings" },
                    new Book { Title = "The Children of Húrin" }
                }
                };

                var rowling = new Author
                {
                    Name = "J. K. Rowling",
                    Books = new List<Book>()
                {
                    new Book { Title = "Harry Potter and the Philosopher's Stone "},
                    new Book { Title = "Harry Potter and the Chamber of Secrets"},
                    new Book { Title = "Harry Potter and the Deathly Hallows"}
                }
                };

                context.Authors.Add(tolkien);
                context.Authors.Add(rowling);

                context.SaveChanges();
            }
        }
    }

}
