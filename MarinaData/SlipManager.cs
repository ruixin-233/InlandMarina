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
        public static List<Slip> GetAll()
        {
            MarinaEntities db = new MarinaEntities();
            List<Slip> slips = db.Slips.ToList();
            return slips;
        }

        //public static List<Slip> SlipsinDock(int id)
        //{
        //    MarinaEntities db = new MarinaEntities();
        //    List<Slip> slips = db.Slips.Where(s => s.DockID == id).ToList();
        //    return slips;
        //}

        public static List<Slip> AvailableSlip(int id)
        {
            MarinaEntities db = new MarinaEntities();
            var availableSlips = db.Slips.Where(s => s.Leases.Count == 0 && s.DockID == id).ToList();
            return availableSlips;
        }

    }
}
