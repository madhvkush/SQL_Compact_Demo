using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Compact_Demo.CRUD_Context
{
    class CRUDAppDBContext : DbContext
    {
        public CRUDAppDBContext() : base("db_CRUD_Demo") { }
        public DbSet<Entities.Student> Students { get; set; }
    }
}
