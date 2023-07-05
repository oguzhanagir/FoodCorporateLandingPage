using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.Entity.Concrete
{
    public class Blog
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ImagePath { get; set; }
        public DateTime? PublishDate { get; set; }

        public Blog()
        {
            PublishDate = DateTime.Now;
        }
    }
}
