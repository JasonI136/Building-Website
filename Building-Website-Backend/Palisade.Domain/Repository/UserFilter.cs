using Palisade.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palisade.Domain.Repository
{
    public static partial class UserFilter
    {
        public static User WithUserId(this IQueryable<User> users, int UserId)
        { 
            return users.SingleOrDefault(p => p.Id == UserId);
        }

        public static User WithEmail(this IQueryable<User> users, string email)
        {
            return users.SingleOrDefault(p => p.Email == email);
        }
    }
}
