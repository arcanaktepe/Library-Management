using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArcanAktepe.Data.Models;
namespace ArcanAktepe.Data
{
    public class ArcanDbContext :DbContext

    {
        public ArcanDbContext(DbContextOptions<ArcanDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
