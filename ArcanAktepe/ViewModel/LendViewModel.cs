using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcanAktepe.Data.Models;
namespace ArcanAktepe.ViewModel
{
    public class LendViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
