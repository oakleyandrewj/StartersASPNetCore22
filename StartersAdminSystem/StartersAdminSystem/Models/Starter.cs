using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartersAdminSystem.Models
{
    public class Starter
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public decimal Salary { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public DateTime StartDate { get; set; }
        public string Department { get; set; }
        public string Office { get; set; }
        public string Ddi { get; set; }

    }
}
