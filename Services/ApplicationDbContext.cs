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
        public DbSet<Property> Properties { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // var user1 = new User() { Id = 1, FirstName = "James", LastName = "Tran", Email = "jtran@email.com", Phone = "555-555-5555", Role = "Agent", PasswordHash = "password1" };
            // var user2 = new User() { Id = 2, FirstName = "Chrystal", LastName = "Smith", Email = "csmith@email.com", Phone = "111-111-1111", Role = "Admin", PasswordHash = "password2" };

            // modelBuilder.Entity<User>().HasData(user1, user2);

  // Seed Users
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

            // Seed Properties
            modelBuilder.Entity<Property>().HasData(
                new Property { Id = 1, Title = "3-Bedroom House in LA", Address = "123 Main St", City = "Los Angeles", State = "CA", ZipCode = "90001", Type = "Residential", Status = "Available", Price = 750000, ListingDate = DateTime.UtcNow, AgentId = 2 },
                new Property { Id = 2, Title = "Downtown Office Space", Address = "500 Business Rd", City = "Los Angeles", State = "CA", ZipCode = "90017", Type = "Commercial", Status = "Available", Price = 1500000, ListingDate = DateTime.UtcNow, AgentId = 3 }
            );

            // Seed Deals
            modelBuilder.Entity<Deal>().HasData(
                new Deal { Id = 1, ClientId = 1, PropertyId = 1, AgentId = 2, Stage = "Negotiation", ExpectedValue = 740000, ClosingDate = DateTime.UtcNow.AddMonths(1) },
                new Deal { Id = 2, ClientId = 2, PropertyId = 2, AgentId = 3, Stage = "Lead", ExpectedValue = 1490000, ClosingDate = DateTime.UtcNow.AddMonths(2) }
            );

            // Seed Interactions
            modelBuilder.Entity<Interaction>().HasData(
                new Interaction { Id = 1, ClientId = 1, AgentId = 2, Type = "Call", Description = "Discussed financing options", Date = DateTime.UtcNow, Outcome = "Interested" },
                new Interaction { Id = 2, ClientId = 2, AgentId = 3, Type = "Email", Description = "Sent property brochure", Date = DateTime.UtcNow, Outcome = "Follow-up Needed" }
            );

            // Seed Tasks
            modelBuilder.Entity<TaskItem>().HasData(
                new TaskItem { Id = 1, Title = "Schedule Viewing", Description = "Book a house tour with David Green", DueDate = DateTime.UtcNow.AddDays(3), Status = "Pending", AssignedToId = 2, ClientId = 1, DealId = 1 },
                new TaskItem { Id = 2, Title = "Prepare Contract Draft", Description = "Prepare draft for Eva’s office space deal", DueDate = DateTime.UtcNow.AddDays(7), Status = "In Progress", AssignedToId = 3, ClientId = 2, DealId = 2 }
            );

            // Seed Documents
            modelBuilder.Entity<Document>().HasData(
                new Document { Id = 1, FileName = "DavidGreen_Offer.pdf", FilePath = "/docs/offers/DavidGreen_Offer.pdf", UploadedById = 2, ClientId = 1, DealId = 1, UploadedAt = DateTime.UtcNow },
                new Document { Id = 2, FileName = "EvaMartinez_Contract.pdf", FilePath = "/docs/contracts/EvaMartinez_Contract.pdf", UploadedById = 3, ClientId = 2, DealId = 2, UploadedAt = DateTime.UtcNow }
            );


            base.OnModelCreating(modelBuilder);

            // User -> Client relationship (One Agent to Many Clients)
            modelBuilder.Entity<Client>()
                .HasOne(c => c.AssignedAgent)
                .WithMany(u => u.Clients)
                .HasForeignKey(c => c.AssignedAgentId)
                .OnDelete(DeleteBehavior.Restrict);

            // User -> Property relationship (One Agent to Many Properties)
            modelBuilder.Entity<Property>()
                .HasOne(p => p.Agent)
                .WithMany(u => u.Properties)
                .HasForeignKey(p => p.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Property>()
                .Property(d => d.Price)
                .HasColumnType("decimal(18, 4)");

            // User -> Interaction relationship (One Agent to Many Interactions)
            modelBuilder.Entity<Interaction>()
                .HasOne(i => i.Agent)
                .WithMany(u => u.Interactions)
                .HasForeignKey(i => i.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Client -> Interaction relationship
            modelBuilder.Entity<Interaction>()
                .HasOne(i => i.Client)
                .WithMany(c => c.Interactions)
                .HasForeignKey(i => i.ClientId);

            // Deal relationships
            modelBuilder.Entity<Deal>()
                .HasOne(d => d.Client)
                .WithMany(c => c.Deals)
                .HasForeignKey(d => d.ClientId);

            modelBuilder.Entity<Deal>()
                .HasOne(d => d.Property)
                .WithMany(p => p.Deals)
                .HasForeignKey(d => d.PropertyId);

            modelBuilder.Entity<Deal>()
                .HasOne(d => d.Agent)
                .WithMany(u => u.Deals)
                .HasForeignKey(d => d.AgentId);

            modelBuilder.Entity<Deal>()
                .Property(d => d.ExpectedValue)
                .HasColumnType("decimal(18, 4)");

            // TaskItem relationships
            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.AssignedTo)
                .WithMany()
                .HasForeignKey(t => t.AssignedToId)
                .OnDelete(DeleteBehavior.Restrict);

            // modelBuilder.Entity<TaskItem>()
            //     .HasOne(t => t.Client)
            //     .WithMany(c => c.Interactions) // optional link to Client
            //     .HasForeignKey(t => t.ClientId)
            //     .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.Deal)
                .WithMany(d => d.Tasks)
                .HasForeignKey(t => t.DealId)
                .OnDelete(DeleteBehavior.SetNull);

            // Document relationships
            modelBuilder.Entity<Document>()
                .HasOne(d => d.UploadedBy)
                .WithMany()
                .HasForeignKey(d => d.UploadedById)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.Client)
                .WithMany(c => c.Documents)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.Deal)
                .WithMany(dl => dl.Documents)
                .HasForeignKey(d => d.DealId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}