using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficePool.Domain;

namespace OfficePool.Repository
{
    public class OfficePoolContext : DbContext
    {
        public OfficePoolContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
