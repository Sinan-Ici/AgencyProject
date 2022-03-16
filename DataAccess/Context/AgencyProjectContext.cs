using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class AgencyProjectContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        
    }
}
