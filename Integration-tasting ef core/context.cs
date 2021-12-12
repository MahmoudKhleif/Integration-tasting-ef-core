using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration_tasting_ef_core
{
   public class context:DbContext
    {
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {  ///add conection string
            optionsBuilder.UseSqlServer(@"Data Source= ;Initial Catalog=EFtest;Integrated Security=True");
        }
    }
}
