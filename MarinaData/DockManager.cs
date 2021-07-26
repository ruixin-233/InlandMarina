using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaData
{
    public static class DockManager
    {
        public static List<Dock> GetAll()
        {
            MarinaEntities db = new MarinaEntities();
            List<Dock> docks = db.Docks.ToList();
            return docks;
        }
    }
}
