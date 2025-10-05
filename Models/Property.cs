using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Type { get; set; } = "Residential"; // Residential, Commercial, Land
        public string Status { get; set; } = "Available"; // Available, Under Contract, Sold
        public decimal Price { get; set; }
        public DateTime ListingDate { get; set; }

        public int AgentId { get; set; }
        public User Agent { get; set; } = null!;

        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; } 

        // Navigation
        public ICollection<Deal> Deals { get; set; } = new List<Deal>();
    }
}