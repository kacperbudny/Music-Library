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

namespace MusicLibrary.Pages.Albums
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class DeleteModel : PageModel
    {
        private readonly MusicLibrary.Data.ApplicationDbContext currentDbContext;

        public DeleteModel(MusicLibrary.Data.ApplicationDbContext mainDbContext)
        {
            currentDbContext = mainDbContext;
        }

        [BindProperty]
        public Album Album { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Album = await currentDbContext.Album.FirstOrDefaultAsync(m => m.Id == id);

            if (Album == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Album = await currentDbContext.Album.FindAsync(id);

            if (Album != null)
            {
                currentDbContext.Album.Remove(Album);
                await currentDbContext.SaveChangesAsync();
            }

            StatusMessage = "Album deleted succesfully.";
            return RedirectToPage("./Index");
        }
    }
}
