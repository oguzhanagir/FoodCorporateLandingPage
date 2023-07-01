using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.Entity.Concrete
{
    public class Contact
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Mail { get; set; }
        public string? Address { get; set; }
    }
}
