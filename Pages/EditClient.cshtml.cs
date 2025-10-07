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
    public class EditClient : PageModel
    {
        private readonly ApplicationDbContext context;
         public List<User> UserList { get; set; } = new List<User>();

        public EditClient(ApplicationDbContext context)
        {
            this.context = context;
        }
        

        [BindProperty]
        public CRM.Models.Client Clients { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserList = this.context.Users.ToList();
            
            if (id == null)
            {
                Console.WriteLine("No ID");
                return RedirectToPage("/Clients");
            }

            CRM.Models.Client? clients = await context.Clients.FirstOrDefaultAsync(e => e.Id == id);
            Console.WriteLine(clients);

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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine($"Validation error: {error.ErrorMessage}");
                }
                return Page();
            }
            context.Clients.Update(Clients);
            await context.SaveChangesAsync();

            return RedirectToPage("/Clients");
        }
    }
}