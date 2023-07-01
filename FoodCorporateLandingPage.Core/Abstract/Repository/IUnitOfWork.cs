using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.Core.Abstract.Repository
{
    public interface IUnitOfWork
    {
        IAboutRepository Abouts { get; }
        IBlogRepository Blogs { get; }
        IContactRepository Contacts { get; }
        IContactFormRepository ContactForms { get; }
        IHeaderBannerRepository HeaderBanners { get; }
        IServiceRepository Services { get; }
        ISocialMediaRepository SocialMedias { get; }
        ISubscribeRepository Subscribes { get; }

        void Save();

    }
}
