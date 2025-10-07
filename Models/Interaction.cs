using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Interaction
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;

        public int AgentId { get; set; }
        // public User Agent { get; set; } = null!;

        public string Type { get; set; } = "Note"; // Call, Meeting, Email, Note
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Outcome { get; set; } = "Follow-up Needed";

        public DateTime CreatedAt { get; set; }
    }
}