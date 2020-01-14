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

namespace MusicLibrary.Pages.Songs
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class EditModel : PageModel
    {
        private readonly MusicLibrary.Data.ApplicationDbContext currentDbContext;

        [TempData]
        public string StatusMessage { get; set; }

        public EditModel(MusicLibrary.Data.ApplicationDbContext mainDbContext)
        {
            currentDbContext = mainDbContext;
        }

        [BindProperty]
        public Song Song { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Song = await currentDbContext.Song
                .Include(s => s.Album).FirstOrDefaultAsync(m => m.Id == id);

            if (Song == null)
            {
                return NotFound();
            }

            ViewData["AlbumId"] = new SelectList(currentDbContext.Album, "Id", "Artist");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            currentDbContext.Attach(Song).State = EntityState.Modified;

            try
            {
                await currentDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SongExists(Song.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            StatusMessage = "Song updated succesfully.";

            return RedirectToPage("./Index", new { albumId = Song.AlbumId });
        }

        private bool SongExists(int id)
        {
            return currentDbContext.Song.Any(e => e.Id == id);
        }
    }
}
