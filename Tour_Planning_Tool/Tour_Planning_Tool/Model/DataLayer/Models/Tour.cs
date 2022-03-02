using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour_Planning_Tool.DataLayer.Models.MapQuest;

namespace Tour_Planning_Tool.DataLayer.Models
{
    public enum ETransportType { CAR, TRAIN, SHIP, AIRPLANE, FOOT, BICYCLE }
    public class Tour
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Location From { get; set; }
        public Location To { get; set; }
        public ETransportType TransportType { get; set; }
        public Route TourRoute { get; set; }

    }
}
