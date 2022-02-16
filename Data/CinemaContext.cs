using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Iuga_Dorut.Models;

namespace Project_Iuga_Dorut.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) :
       base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Ticket>().ToTable("Tickets");
            modelBuilder.Entity<Movie>().ToTable("Movies");
        }
        public DbSet<Project_Iuga_Dorut.Models.Producer> Producer { get; set; }
    }
}
