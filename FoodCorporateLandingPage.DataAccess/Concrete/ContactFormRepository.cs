using FoodCorporateLandingPage.Core.Abstract.Repository;
using FoodCorporateLandingPage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.DataAccess.Concrete
{
    public class ContactFormRepository : GenericRepository<ContactForm>, IContactFormRepository
    {
        public ContactFormRepository(FoodDbContext dbContext) : base(dbContext)
        {
                
        }
    }
}
