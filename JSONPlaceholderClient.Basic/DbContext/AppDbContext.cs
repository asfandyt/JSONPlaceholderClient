using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JSONPlaceholderClient.Basic.Models;

namespace JSONPlaceholderClient.Basic.DbContext
{
    class AppDbContext : System.Data.Entity.DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Post> Posts { get; set; }  
    }
}
