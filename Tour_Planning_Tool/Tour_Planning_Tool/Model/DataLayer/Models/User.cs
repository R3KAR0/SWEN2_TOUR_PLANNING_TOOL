using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour_Planning_Tool.DataLayer.Models.MapQuest;

namespace Tour_Planning_Tool.DataLayer.Models
{
    internal class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Tour> Tours { get; set; }
        public List<Tour> Favorites { get; set; }
        public List<User> Friends { get; set; }
        public List<Dictionary<Location, string>> SavedLocations { get; set; }

    }
}
