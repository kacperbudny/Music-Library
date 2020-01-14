using System;
using System.Collections.Generic;
using System.Linq;
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

namespace MusicLibrary.Pages.Users
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext currentDbContext;

        public IndexModel(ApplicationDbContext mainDbContext)
        {
            currentDbContext = mainDbContext;
        }

        [BindProperty]
        public UsersListViewModel UsersListVM { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet(int productPage=1, string searchCriteria = null)
        {
            UsersListVM = new UsersListViewModel()
            {
                ApplicationUserList = await currentDbContext.ApplicationUser.ToListAsync()
            };

            StringBuilder param = new StringBuilder();
            param.Append("/Users?productPage=:");
            param.Append("&searchCriteria=");

            if (searchCriteria != null)
            {
                param.Append(searchCriteria);
            }

            if(searchCriteria != null)
            {
                UsersListVM.ApplicationUserList = await currentDbContext.ApplicationUser.Where(u => u.Email.ToLower().Contains(searchCriteria.ToLower()) || u.Name.ToLower().Contains(searchCriteria.ToLower())).ToListAsync();
            }


            var count = UsersListVM.ApplicationUserList.Count;

            UsersListVM.PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = SD.PaginationUsersPage,
                TotalItems = count,
                UrlParam = param.ToString()
            };

            UsersListVM.ApplicationUserList = UsersListVM.ApplicationUserList.OrderBy(p=>p.Email)
                .Skip((productPage - 1) * SD.PaginationUsersPage)
                .Take(SD.PaginationUsersPage).ToList();

            return Page();
        }
    }
}