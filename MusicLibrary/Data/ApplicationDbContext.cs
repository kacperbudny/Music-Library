using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.Model;

namespace MusicLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Album { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Likes> Likes { get; set; }
    }
}
