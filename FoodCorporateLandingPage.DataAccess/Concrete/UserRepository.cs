using FoodCorporateLandingPage.DataAccess.Concrete;
using FoodCorporateLandingPage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.Core.Abstract.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(FoodDbContext dbContext): base(dbContext)
        {
            
        }
    }
}
