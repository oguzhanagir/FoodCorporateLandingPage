using FoodCorporateLandingPage.Core.Abstract.Repository;
using FoodCorporateLandingPage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.DataAccess.Concrete
{
    public class ServiceRepository : GenericRepository<Service>,IServiceRepository
    {
        public ServiceRepository(FoodDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
