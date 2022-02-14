using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Iuga_Dorut.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Lenght { get; set; }
        public decimal PriceForTicket { get; set; }
        public ICollection<Ticket> Ticket { get; set; }
    }
}
