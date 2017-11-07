using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayLen_Wang.Manager
{
    public class DBJayContext:DbContext
    {
        public DBJayContext() : base("name=DbConnection")
        {
            Database.SetInitializer<DBJayContext>(null);
        }
    }
}
