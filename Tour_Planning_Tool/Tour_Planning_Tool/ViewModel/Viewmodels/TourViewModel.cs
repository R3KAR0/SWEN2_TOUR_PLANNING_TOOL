using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour_Planning_Tool.DataLayer.Models;

namespace Tour_Planning_Tool.ViewModel.Viewmodels
{
    internal class TourViewModel : AViewModel
    {
        public Tour Tour { get; }

        public TourViewModel (Tour tour)
        {
            Tour = tour;
        }

        public string Name { get => Tour.Name; set { Tour.Name = value; OnPropertyChanged(nameof(Name)); } }
        public string Description { get => Tour.Description; set { Tour.Description = value; OnPropertyChanged(nameof(Description)); } }



    }
}
