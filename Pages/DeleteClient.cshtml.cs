using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Models;
using CRM.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CRM.Pages
{
    public class DeleteClient : PageModel
    {
        private readonly ApplicationDbContext context;

        public DeleteClient(ApplicationDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public CRM.Models.Client Clients { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                Console.WriteLine("No ID");
                return RedirectToPage("/Clients");
            }

            var clients = await context.Clients.FirstOrDefaultAsync(e => e.Id == id);

            if (clients == null)
            {
                return RedirectToPage("/Clients");
            }
            else
            {
                Clients = clients;
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return Page();
            }

            var clients = await context.Clients.FindAsync(id);

            if (clients == null)
            {
                return Page();
            }
            else
            {
                Clients = clients;
                context.Clients.Remove(Clients);
                await context.SaveChangesAsync();
                return RedirectToPage("/Clients"); 
            }
        }
    }
}