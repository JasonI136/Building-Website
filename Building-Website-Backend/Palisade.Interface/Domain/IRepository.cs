using Palisade.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palisade.Interface.Domain
{
    public interface IRepository
    {
        // Building Interface Repository
        IQueryable<User> GetUser();

        void PostUser(User user);

        IQueryable<Building> GetBuilding();
        
        ///////////
    }
}
