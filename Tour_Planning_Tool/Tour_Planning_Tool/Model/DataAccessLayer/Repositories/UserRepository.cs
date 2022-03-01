using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour_Planning_Tool.DataLayer.Models;

namespace Tour_Planning_Tool.Model.DataAccessLayer.Repositories
{
    internal class UserRepository : IRepository<User>
    {
        public User? Add(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public User? Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
