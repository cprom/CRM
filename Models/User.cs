using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;

namespace CRM.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Role { get; set; } = "Agent"; // Admin, Agent, Manager
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

                // Navigation
        public ICollection<Client> Clients { get; set; } = new List<Client>();
        public ICollection<Property> Properties { get; set; } = new List<Property>();
        public ICollection<Interaction> Interactions { get; set; } = new List<Interaction>();
        public ICollection<Deal> Deals { get; set; } = new List<Deal>();
    }
}