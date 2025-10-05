using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Models;
using CRM.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CRM.Pages
{
    public class Clients : PageModel
    {
        private readonly ApplicationDbContext context;
        public List<Client> ClientList { get; set; } = new List<Client>();
        public Clients(ApplicationDbContext context)
        {
            this.context = context;          
        }

        public void OnGet()
        {
            ClientList = this.context.Clients.ToList();
        }
    }
}