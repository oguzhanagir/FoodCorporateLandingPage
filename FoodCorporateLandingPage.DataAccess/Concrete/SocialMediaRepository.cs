﻿using FoodCorporateLandingPage.Core.Abstract.Repository;
using FoodCorporateLandingPage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.DataAccess.Concrete
{
    public class SocialMediaRepository : GenericRepository<SocialMedia> , ISocialMediaRepository
    {
        public SocialMediaRepository(FoodDbContext dbContext) : base(dbContext)
        {

        }
    }
}
