using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Client
    {

        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Status { get; set; } = "Lead"; // Lead, Prospect, Active, Inactive
        public string Source { get; set; } = "Referral";

        public int AssignedAgentId { get; set; }
        public User AssignedAgent { get; set; } = null!;


    }
}