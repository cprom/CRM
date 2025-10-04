using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Deal
    {
         public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;

        public int PropertyId { get; set; }
        public Property Property { get; set; } = null!;

        public int AgentId { get; set; }
        public User Agent { get; set; } = null!;

        public string Stage { get; set; } = "Lead"; // Lead, Negotiation, Offer, Closed Won, Closed Lost
        public decimal ExpectedValue { get; set; }
        public DateTime ClosingDate { get; set; } = DateTime.UtcNow;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}