using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicLibrary.Model;
using MusicLibrary.Utility;

namespace MusicLibrary.Pages.Songs
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class CreateModel : PageModel
    {
        private readonly MusicLibrary.Data.ApplicationDbContext currentDbContext;

        public CreateModel(MusicLibrary.Data.ApplicationDbContext mainDbContext)
        {
            currentDbContext = mainDbContext;
        }

        public IActionResult OnGet(int albumId)
        {
            Song = new Song();
            Song.AlbumId = albumId;

            return Page();
        }

        [BindProperty]
        public Song Song { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            currentDbContext.Song.Add(Song);
            await currentDbContext.SaveChangesAsync();

            StatusMessage = "Song has been added successfully.";

            return RedirectToPage("./Index", new { albumId = Song.AlbumId });
        }
    }
}