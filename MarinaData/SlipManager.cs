﻿using System;
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
                                      (s, d) => new { s.DockID, d.Name, s.ID }).
                                      ToList();
            return slips;
        }

        public static Slip FindDock(int id)
        {
            MarinaEntities db = new MarinaEntities();
            Slip slip = db.Slips.SingleOrDefault(s => s.ID == id);
            return slip;
        }

    }
}
