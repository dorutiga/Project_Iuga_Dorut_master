using System;
using System.Collections.Generic;
using System.Linq;
using Project_Iuga_Dorut.Models;
using System.Threading.Tasks;

namespace Project_Iuga_Dorut.Data
{
    public class DbInitializer
    {
        public static void Initialize(CinemaContext context)
        {
            context.Database.EnsureCreated();
            if (context.Movies.Any())
            {
                return; // BD a fost creata anterior
            }
            var movies = new Movie[]
            {
 new Movie{ID = 1, Title = "Toy Story",Producer = "Pixar", Lenght = "123", PriceForTicket = Decimal.Parse("27") },
 new Movie{ID = 2,Title = "Ragnarok", Producer= "Marvel", Lenght = "102", PriceForTicket = Decimal.Parse("23") },
 new Movie{ID = 3,Title = "Cars", Producer = "Pixar", Lenght = "113", PriceForTicket =Decimal.Parse("17") },

            };
            foreach (Movie movie in movies)
            {
                context.Movies.Add(movie);
            }
            context.SaveChanges();
            var customers = new Customer[]
            {

new Customer{CustomerID=11,Name="Matei",Age=DateTime.Parse("25")},
new Customer{CustomerID=12,Name="Mara",Age=DateTime.Parse("19")},

         };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
            var tickets = new Ticket[]
            {
 new Ticket{MovieID=1,CustomerID=11,SaleDate = DateTime.Parse("02-25-2020")},
 new Ticket{MovieID=2,CustomerID=11, SaleDate = DateTime.Parse("02-25-2020")},
 new Ticket{MovieID=3,CustomerID=12,SaleDate = DateTime.Parse("02-25-2020")},
 new Ticket{MovieID=1,CustomerID=11,SaleDate = DateTime.Parse("02-25-2020")},

            };
            foreach (Ticket ticket in tickets
                )
            {
                context.Tickets.Add(ticket);
            }
            context.SaveChanges();
        }
    }
}
