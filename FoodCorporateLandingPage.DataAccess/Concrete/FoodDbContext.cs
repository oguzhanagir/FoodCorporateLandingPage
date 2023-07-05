using FoodCorporateLandingPage.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.DataAccess.Concrete
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options)
        {

        }
        public DbSet<About>? Abouts { get; set; }
        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<ContactForm>? ContactForms { get; set; }
        public DbSet<HeaderBanner>? HeaderBanners { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<SocialMedia>? SocialMedias { get; set; }
        public DbSet<Subscribe>? Subscribes { get; set; }
        public DbSet<User>? Users { get; set; }
    }
}
