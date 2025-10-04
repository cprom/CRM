using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // var user1 = new User() { Id = 1, FirstName = "James", LastName = "Tran", Email = "jtran@email.com", Phone = "555-555-5555", Role = "Agent", PasswordHash = "password1" };
            // var user2 = new User() { Id = 2, FirstName = "Chrystal", LastName = "Smith", Email = "csmith@email.com", Phone = "111-111-1111", Role = "Admin", PasswordHash = "password2" };

            // modelBuilder.Entity<User>().HasData(user1, user2);

              modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Alice", LastName = "Johnson", Email = "alice@crm.com", Phone = "555-1001", Role = "Admin", PasswordHash = "hashed_pw1" },
                new User { Id = 2, FirstName = "Bob", LastName = "Smith", Email = "bob@crm.com", Phone = "555-1002", Role = "Agent", PasswordHash = "hashed_pw2" },
                new User { Id = 3, FirstName = "Charlie", LastName = "Brown", Email = "charlie@crm.com", Phone = "555-1003", Role = "Agent", PasswordHash = "hashed_pw3" }
            );

                 // Seed Clients
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, FirstName = "David", LastName = "Green", Email = "david.green@email.com", Phone = "555-2001", Status = "Lead", Source = "Website", AssignedAgentId = 2 },
                new Client { Id = 2, FirstName = "Eva", LastName = "Martinez", Email = "eva.martinez@email.com", Phone = "555-2002", Status = "Prospect", Source = "Referral", AssignedAgentId = 3 }
            );
        }
    }
}