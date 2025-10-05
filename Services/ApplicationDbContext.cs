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

<<<<<<< HEAD
            // Seed Users
            modelBuilder.Entity<User>().HasData(
=======
            // modelBuilder.Entity<User>().HasData(user1, user2);

              modelBuilder.Entity<User>().HasData(
>>>>>>> main
                new User { Id = 1, FirstName = "Alice", LastName = "Johnson", Email = "alice@crm.com", Phone = "555-1001", Role = "Admin", PasswordHash = "hashed_pw1" },
                new User { Id = 2, FirstName = "Bob", LastName = "Smith", Email = "bob@crm.com", Phone = "555-1002", Role = "Agent", PasswordHash = "hashed_pw2" },
                new User { Id = 3, FirstName = "Charlie", LastName = "Brown", Email = "charlie@crm.com", Phone = "555-1003", Role = "Agent", PasswordHash = "hashed_pw3" }
            );

                 // Seed Clients
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, FirstName = "David", LastName = "Green", Email = "david.green@email.com", Phone = "555-2001", Status = "Lead", Source = "Website", AssignedAgentId = 2 },
                new Client { Id = 2, FirstName = "Eva", LastName = "Martinez", Email = "eva.martinez@email.com", Phone = "555-2002", Status = "Prospect", Source = "Referral", AssignedAgentId = 3 }
            );
<<<<<<< HEAD

            // Seed Properties
            modelBuilder.Entity<Property>().HasData(
                new Property { Id = 1, Title = "3-Bedroom House in LA", Address = "123 Main St", City = "Los Angeles", State = "CA", ZipCode = "90001", Type = "Residential", Status = "Available", Price = 750000, ListingDate = new DateTime(2025, 10, 26), AgentId = 2 },
                new Property { Id = 2, Title = "Downtown Office Space", Address = "500 Business Rd", City = "Los Angeles", State = "CA", ZipCode = "90017", Type = "Commercial", Status = "Available", Price = 1500000, ListingDate = new DateTime(2025, 10, 26), AgentId = 3 }
            );

            // Seed Deals
            modelBuilder.Entity<Deal>().HasData(
                new Deal { Id = 1, ClientId = 1, PropertyId = 1, AgentId = 2, Stage = "Negotiation", ExpectedValue = 740000, ClosingDate = new DateTime(2025, 10, 26).AddMonths(1) },
                new Deal { Id = 2, ClientId = 2, PropertyId = 2, AgentId = 3, Stage = "Lead", ExpectedValue = 1490000, ClosingDate = new DateTime(2025, 10, 26).AddMonths(2) }
            );

            // Seed Interactions
            modelBuilder.Entity<Interaction>().HasData(
                new Interaction { Id = 1, ClientId = 1, AgentId = 2, Type = "Call", Description = "Discussed financing options", Date = new DateTime(2025, 10, 26), Outcome = "Interested" },
                new Interaction { Id = 2, ClientId = 2, AgentId = 3, Type = "Email", Description = "Sent property brochure", Date = new DateTime(2025, 10, 26), Outcome = "Follow-up Needed" }
            );

            // Seed Tasks
            modelBuilder.Entity<TaskItem>().HasData(
                new TaskItem { Id = 1, Title = "Schedule Viewing", Description = "Book a house tour with David Green", DueDate = new DateTime(2025, 10, 26).AddDays(3), Status = "Pending", AssignedToId = 2, ClientId = 1, DealId = 1 },
                new TaskItem { Id = 2, Title = "Prepare Contract Draft", Description = "Prepare draft for Eva’s office space deal", DueDate = new DateTime(2025, 10, 26).AddDays(7), Status = "In Progress", AssignedToId = 3, ClientId = 2, DealId = 2 }
            );

            // Seed Documents
            modelBuilder.Entity<Document>().HasData(
                new Document { Id = 1, FileName = "DavidGreen_Offer.pdf", FilePath = "/docs/offers/DavidGreen_Offer.pdf", UploadedById = 2, ClientId = 1, DealId = 1, UploadedAt = new DateTime(2025, 10, 26) },
                new Document { Id = 2, FileName = "EvaMartinez_Contract.pdf", FilePath = "/docs/contracts/EvaMartinez_Contract.pdf", UploadedById = 3, ClientId = 2, DealId = 2, UploadedAt = new DateTime(2025, 10, 26) }
            );

            base.OnModelCreating(modelBuilder);
            // User
            modelBuilder.Entity<User>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<User>()
                .Property(u => u.UpdatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            // Interaction
            modelBuilder.Entity<Interaction>()
                .HasOne(i => i.Agent)
                .WithMany()
                .HasForeignKey(i => i.AgentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Interaction>()
                .Property(u => u.Date)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Interaction>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            // Client
            modelBuilder.Entity<Client>()
                .HasOne(c => c.AssignedAgent)
                .WithMany()
                .HasForeignKey(c => c.AssignedAgentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Client>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Client>()
                .Property(u => u.UpdatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            // Property
            modelBuilder.Entity<Property>()
                .HasOne(p => p.Agent)
                .WithMany()
                .HasForeignKey(p => p.AgentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Property>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Property>()
                .Property(u => u.UpdatedAt)
                .HasDefaultValueSql("GETUTCDATE()");  

            modelBuilder.Entity<Property>()
                .Property(u => u.ListingDate)
                .HasDefaultValueSql("GETUTCDATE()");    

            modelBuilder.Entity<Property>()
                .Property(d => d.Price)
                .HasColumnType("decimal(18, 4)");

            // Deal
            modelBuilder.Entity<Deal>()
                .HasOne(d => d.Agent)
                .WithMany()
                .HasForeignKey(d => d.AgentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Deal>()
                .HasOne(d => d.Client)
                .WithMany()
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Deal>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Deal>()
                .Property(u => u.UpdatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Deal>()
                .Property(u => u.ClosingDate)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Deal>()
                .Property(d => d.ExpectedValue)
                .HasColumnType("decimal(18, 4)");

            // Task Item
            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.AssignedTo)
                .WithMany()
                .HasForeignKey(t => t.AssignedToId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.Client)
                .WithMany()
                .HasForeignKey(t => t.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.Deal)
                .WithMany()
                .HasForeignKey(t => t.DealId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TaskItem>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");  

            modelBuilder.Entity<TaskItem>()
                .Property(u => u.UpdatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<TaskItem>()
                .Property(u => u.DueDate)
                .HasDefaultValueSql("GETUTCDATE()");    

            // Document
            modelBuilder.Entity<Document>()
                .HasOne(d => d.UploadedBy)
                .WithMany()
                .HasForeignKey(d => d.UploadedById)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.Client)
                .WithMany()
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.Deal)
                .WithMany()
                .HasForeignKey(d => d.DealId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Document>()
                .Property(u => u.UploadedAt)
                .HasDefaultValueSql("GETUTCDATE()");

=======
>>>>>>> main
        }
    }
}

