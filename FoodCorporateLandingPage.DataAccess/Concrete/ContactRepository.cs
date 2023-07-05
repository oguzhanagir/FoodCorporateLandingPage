using FoodCorporateLandingPage.Core.Abstract.Repository;
using FoodCorporateLandingPage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.DataAccess.Concrete
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        private readonly FoodDbContext _dbContext;
        public ContactRepository(FoodDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public string GetPhoneNumber()
        {
            var phoneNumber = _dbContext.Contacts!.Select(c => c.PhoneNumber).FirstOrDefault();
            return phoneNumber!;
        }
    }
}
