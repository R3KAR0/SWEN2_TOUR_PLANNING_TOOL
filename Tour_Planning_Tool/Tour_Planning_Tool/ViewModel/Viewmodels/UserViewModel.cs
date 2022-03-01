using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour_Planning_Tool.DataLayer.Models;

namespace Tour_Planning_Tool.ViewModel.Viewmodels
{
    internal class UserViewModel : AViewModel
    {
        public User User { get; }

        public UserViewModel(User user)
        {
            User = user;
        }
    }
}
