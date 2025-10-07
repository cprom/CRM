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
    public class AddNewClient : PageModel
    {
        private readonly ApplicationDbContext context;


        public List<User> UserList { get; set; } = new List<User>();

        public AddNewClient(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet()
        {
            UserList = this.context.Users.ToList();
            return Page();
        }
        [BindProperty]
        public Client Clients { get; set; } = default!;

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
            context.Clients.Add(Clients);
            await context.SaveChangesAsync();

            return RedirectToPage("Clients");
        }
    }
}