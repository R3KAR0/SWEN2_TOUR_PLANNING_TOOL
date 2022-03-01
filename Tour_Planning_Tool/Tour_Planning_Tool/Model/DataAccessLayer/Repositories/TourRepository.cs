using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour_Planning_Tool.DataLayer.Models;

namespace Tour_Planning_Tool.Model.DataAccessLayer.Repositories
{
    internal class TourRepository : IRepository<Tour>
    {
        public Tour? Add(Tour obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Tour obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Tour> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tour? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Tour? Update(Tour obj)
        {
            throw new NotImplementedException();
        }
    }
}
