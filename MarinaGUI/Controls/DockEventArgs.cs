using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarinaGUI.Controls
{
    public class DockEventArgs: EventArgs
    {
        // properties from Slip, all string type for convenience
        public string DockID { get; set; }
        public string DockName{ get; set; }
        public string SlipID { get; set; }
    }
}