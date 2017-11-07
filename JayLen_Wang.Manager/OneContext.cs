using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace JayLen_Wang.Manager
{
    public static class OneContext
    {
        private static string _contextName { get; set; }
        public static DBJayContext Current
        {
            get { return HttpContext.Current.Items[_contextName] as DBJayContext; }
        }

        static OneContext()
        {
            _contextName = "_JayLenContext";
        }

        public static void Begin()
        {
            HttpContext.Current.Items[_contextName] = new DBJayContext();
        }

        public static void End()
        {
            var entity = HttpContext.Current.Items[_contextName] as DBJayContext;
            if (entity != null)
            {
                entity.Dispose();
            }
        }
    }
}
