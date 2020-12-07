using Palisade.Domain.Entity;
using Palisade.Interface.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palisade.Domain.Repository
{
    public class Repository : RepositoryBase, IRepository
    {
        public IQueryable<User> GetUser()
        {
            return _dataContext.Users;
        }

        public void PostUser(User user)
        {
            if (user.Id <= 0)
            {
                _dataContext.Add(user);
            }
            else
            {
                _dataContext.Update(user);
            }

            _dataContext.SaveChanges();
        }
        public IQueryable<Building> GetBuilding()
        {
            return _dataContext.Buildings;
        }

        
        
    }
}
