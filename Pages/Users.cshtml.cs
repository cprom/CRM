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
    public class Users : PageModel
    {
        private readonly ApplicationDbContext context;

        public List<User> UserList { get; set; } = new List<User>();

        public Users(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            UserList = this.context.Users.ToList();
        }
    }
}