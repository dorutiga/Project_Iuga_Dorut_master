
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
namespace Project_Iuga_Dorut.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public ICollection<Ticket> Orders { get; set; }
    }
}