using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherWebSiteApp.Data.Auth;
using TeacherWebSiteApp.Data.Models;
using TeacherWebSiteApp.Data.PageModels;

namespace TeacherWebSiteApp.Data
{
    public class TeacherContext : DbContext
    {
        // Models
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupPublication> GroupPublications { get; set; }
        // PageModels
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArcticleBlock> ArticleBlocks { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<MainPage> MainPages { get; set; }
        public DbSet<SliderPicture> SliderPictures { get; set; }

        //Auth
        public DbSet<User> Users { get; set; }


        public TeacherContext(DbContextOptions<TeacherContext> options)
            : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeacherContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
