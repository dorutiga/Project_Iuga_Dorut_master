using System;
namespace Project_Iuga_Dorut.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int CustomerID { get; set; }
        public int MovieID { get; set; }
        public DateTime SaleDate { get; set; }
        public Customer Customer { get; set; }
        public Movie Movie{ get; set; }
    }
}