using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcanAktepe.Data.Models;
using ArcanAktepe.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArcanAktepe.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ArcanDbContext context) : base(context)
        {
        }
    }
}
