﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Model.ViewModel
{
    public class UsersListViewModel
    {
        public List<ApplicationUser> ApplicationUserList { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
