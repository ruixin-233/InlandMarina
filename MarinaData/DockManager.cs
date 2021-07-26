using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaData
{
    public static class DockManager
    {
        public static Dock FindAvaliableSlip(int id)
        {
            MarinaEntities db = new MarinaEntities();
            Dock dock = db.Docks.SingleOrDefault(d => d.ID == id);
            return dock;
        }
    }
}
