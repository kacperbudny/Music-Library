using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.Data;
using MusicLibrary.Model;
using MusicLibrary.Model.ViewModel;
using MusicLibrary.Utility;

namespace MusicLibrary.Pages.Albums
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly MusicLibrary.Data.ApplicationDbContext currentDbContext;

        public IndexModel(MusicLibrary.Data.ApplicationDbContext mainDbContext)
        {
            currentDbContext = mainDbContext;
        }

        [BindProperty]
        public AlbumViewModel AlbumVM { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet(int productPage = 1, string searchCriteria = null)
        {
            AlbumVM = new AlbumViewModel()
            {
                AlbumList = await currentDbContext.Album.ToListAsync()
            };

            StringBuilder param = new StringBuilder();
            param.Append("/Albums?productPage=:");

            param.Append("&searchCriteria=");

            if (searchCriteria != null)
            {
                param.Append(searchCriteria);
            }

            if (searchCriteria != null)
            {
                AlbumVM.AlbumList = await currentDbContext.Album.Where(u => u.Name.ToLower().Contains
                    (searchCriteria.ToLower()) || u.Artist.ToLower().Contains(searchCriteria.ToLower()) ||
                    u.ReleaseDate.ToString().Contains(searchCriteria.ToLower())).ToListAsync();

            }

            var count = AlbumVM.AlbumList.Count;

            AlbumVM.PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = SD.PaginationUsersPage,
                TotalItems = count,
                UrlParam = param.ToString()
            };

            AlbumVM.AlbumList = AlbumVM.AlbumList.OrderBy(p => p.Id)
                .Skip((productPage - 1) * SD.PaginationUsersPage)
                .Take(SD.PaginationUsersPage).ToList();

            return Page();
        }
    }
}
