using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Planning_Tool.DataLayer.Models.MapQuest
{
    public enum EGranularityCode { P1, L1, I1, A1, A3, A4, A5, A6, B1, B2, B3, Z1, Z2, Z3, Z4}
    public enum EConfidenceLevel { A,B,C,X } //Quality of information
    public enum ESideOfStreet { L, R, N } //L = Left, R = right, N = None
    public enum ELocationType { s, v } //s = stop, v = via

    public struct LatLng{
        float lat;
        float lng;
      };

    //Mapper class for MapQuest Locations
    public class Location
    {
        public string Street { get; set; }
        public string AdminArea6 { get; set; }
        public string AdminArea6Type { get; set; }
        public string AdminArea5 { get; set; }
        public string AdminArea5Type { get; set; }
        public string AdminArea4 { get; set; }
        public string AdminArea4Type { get; set; }
        public string AdminArea3 { get; set; }
        public string AdminArea3Type { get; set; }
        public string AdminArea2 { get; set; }
        public string AdminArea2Type { get; set; }
        public string AdminArea1 { get; set; }
        public string AdminArea1Type { get; set; }
        public string PostalCode { get; set; }
        public string UnknownInput { get; set; }
        public string GeocodeQualityCode { set => GeocodeQualityCode = value; get => GranularityCode.ToString() + ConfidenceLevel.ToString(); }
        public EGranularityCode GranularityCode { get; set; }
        public EConfidenceLevel ConfidenceLevel { get; set; }

        public bool DragPoint { get; set; }
        public ESideOfStreet SideOfStreet { get; set; }
        public Guid LinkId { get; set; }
        public ELocationType Type {get; set;}
        public LatLng LatLng { get; set; }

        public LatLng DisplayLatLng { get; set; }


    }
}
