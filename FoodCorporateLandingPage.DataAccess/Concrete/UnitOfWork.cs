using FoodCorporateLandingPage.Core.Abstract.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FoodDbContext _dbContext;
        public UnitOfWork(FoodDbContext dbContext)
        {

            _dbContext = dbContext;
            Abouts = new AboutRepository(_dbContext);
            Blogs = new BlogRepository(_dbContext);
            Contacts = new ContactRepository(_dbContext);
            ContactForms = new ContactFormRepository(_dbContext);
            HeaderBanners = new HeaderBannerRepository(_dbContext);
            Services = new ServiceRepository(_dbContext);
            SocialMedias = new SocialMediaRepository(_dbContext);
            Subscribes = new SubscribeRepository(_dbContext);
        }

        public IAboutRepository Abouts { get; }

        public IBlogRepository Blogs { get; }

        public IContactRepository Contacts { get; }

        public IContactFormRepository ContactForms { get; }

        public IHeaderBannerRepository HeaderBanners { get; }

        public IServiceRepository Services { get; }

        public ISocialMediaRepository SocialMedias { get; }

        public ISubscribeRepository Subscribes { get; }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
