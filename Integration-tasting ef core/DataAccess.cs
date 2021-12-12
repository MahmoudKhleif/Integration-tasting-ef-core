using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration_tasting_ef_core
{
    public class DataAccess
    {
        private readonly context context;

        public DataAccess(context context)
        {
            this.context = context;
        }
         public void AddUser(User user)
        {
            context.users.Add(user);
            context.SaveChanges();

        }

        public User GetUser( string Name)
        {
            return context.users.SingleOrDefault(User => User.Name == Name);
        }

    }
}
