using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.Data;
using MusicLibrary.Model;
using MusicLibrary.Utility;

namespace MusicLibrary.Pages.Users
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext currentDbContext;

        public EditModel(ApplicationDbContext mainDbContext)
        {
            currentDbContext = mainDbContext;
        }

        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id.Trim().Length == 0)
            {
                return NotFound();
            }

            ApplicationUser = await currentDbContext.ApplicationUser.FirstOrDefaultAsync(m => m.Id == id);

            if (ApplicationUser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var userInDb = await currentDbContext.ApplicationUser.SingleOrDefaultAsync(u => u.Id == ApplicationUser.Id);

                if (userInDb == null)
                {
                    return NotFound();
                }
                else
                {
                    userInDb.Name = ApplicationUser.Name;
                    userInDb.PhoneNumber = ApplicationUser.PhoneNumber;

                    await currentDbContext.SaveChangesAsync();
                    StatusMessage = "User updated succesfully.";
                    return RedirectToPage("Index");
                }
            }
        }


    }
}