using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.Data;
using MusicLibrary.Model;
using MusicLibrary.Utility;

namespace MusicLibrary.Pages.Albums
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class EditModel : PageModel
    {
        private readonly MusicLibrary.Data.ApplicationDbContext currentDbContext;

        public EditModel(MusicLibrary.Data.ApplicationDbContext mainDbContext)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            currentDbContext.Attach(Album).State = EntityState.Modified;

            try
            {
                await currentDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlbumExists(Album.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            StatusMessage = "Album updated succesfully.";
            return RedirectToPage("./Index");
        }

        private bool AlbumExists(int id)
        {
            return currentDbContext.Album.Any(e => e.Id == id);
        }
    }
}
