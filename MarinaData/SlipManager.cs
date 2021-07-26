using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaData
{
    public static class SlipManager
    {
        public static IList GetAll()
        {
            MarinaEntities db = new MarinaEntities();

            var slips = db.Slips.Join(db.Docks,
                                      s => s.DockID,
                                      d => d.ID,
                                      (s, d) => new { dockID = d.ID, s.DockID, d.Name, slipID = s.ID }).
                                      ToList();
            return slips;
        }

        public static Slip FindDock(int id)
        {
            MarinaEntities db = new MarinaEntities();
            Slip slip = db.Slips.SingleOrDefault(s => s.DockID == id);
            return slip;
        }

    }
}
