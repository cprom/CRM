using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, In Progress, Completed

        public int AssignedToId { get; set; }
        public User AssignedTo { get; set; } = null!;

        public int? ClientId { get; set; }
        public Client? Client { get; set; }

        public int? DealId { get; set; }
        public Deal? Deal { get; set; }

        // public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        // public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}