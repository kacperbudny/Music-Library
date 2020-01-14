using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.Data;
using MusicLibrary.Model.ViewModel;

namespace MusicLibrary.Pages.Songs
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext currentDbContext;

        [BindProperty]
        public AlbumAndSongViewModel AlbumSongVM { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public IndexModel(ApplicationDbContext mainDbContext)
        {
            currentDbContext = mainDbContext;
        }

        public async Task<IActionResult> OnGet(int? albumId = null)
        {
            AlbumSongVM = new AlbumAndSongViewModel()
            {
                Songs = await currentDbContext.Song.Where(s => s.AlbumId == albumId).OrderBy(s => s.TrackNumber).ToListAsync(),
                AlbumObj = await currentDbContext.Album.FirstOrDefaultAsync(a => a.Id == albumId)
            };

            return Page();
        }

        public async Task<IActionResult> OnPostDelete(int? id)
        {
            var song = await currentDbContext.Song.FindAsync(id);

            if(song==null)
            {
                return NotFound();
            }

            currentDbContext.Song.Remove(song);

            await currentDbContext.SaveChangesAsync();

            StatusMessage = "Song deleted succesfully.";

            return RedirectToPage("./Index", new { albumId = song.AlbumId });
        }
    }
}