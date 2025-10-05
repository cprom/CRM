using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Document
    {
         public int Id { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;

        public int UploadedById { get; set; }
        public User UploadedBy { get; set; } = null!;

        public int? ClientId { get; set; }
        public Client? Client { get; set; }

        public int? DealId { get; set; }
        public Deal? Deal { get; set; }

        public DateTime UploadedAt { get; set; }
    }
}