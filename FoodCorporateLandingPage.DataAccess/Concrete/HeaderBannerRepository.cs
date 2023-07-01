using FoodCorporateLandingPage.Core.Abstract.Repository;
using FoodCorporateLandingPage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.DataAccess.Concrete
{
    public class HeaderBannerRepository : GenericRepository<HeaderBanner> , IHeaderBannerRepository
    {
        public HeaderBannerRepository(FoodDbContext dbContext):  base (dbContext)
        {
            
        }
    }
}
