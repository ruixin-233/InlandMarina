using MarinaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarinaGUI
{
    public partial class AvaliableSlip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DockSelector.DDL_Dock_Control.Load += new EventHandler(InitSlipDataByDock_UserControl_Clicked);
            DockSelector.DockSelect += DockSelector_DockSelect; // subscribe to the event
     
        }

        //private void InitSlipDataByDock_UserControl_Clicked(object sender, System.EventArgs e)
        //{
        //    string dockID = DockSelector.DDL_Dock_Control.SelectedValue;
        //    if (!string.IsNullOrEmpty(dockID))
        //    {
        //        List<Slip> list = MarinaManager.AvailableSlip(int.Parse(dockID));
        //        showListBoxItem(list);
        //    }
        //}

        // method to handle the event CourseSelect
        private void DockSelector_DockSelect(object sender, Controls.DockEventArgs e)
        {
            //lstSlips.DataSource = e.SlipID;
            //string dockID = DockSelector.DDL_Dock_Control.SelectedValue;
            List<Slip> list = e.SlipID;

            gvSlips.DataSource = e.SlipID;
            gvSlips.DataBind();

            //var avaliableSlips = MarinaManager.AvailableSlip(int.Parse(dockID));
            //gvSlips.DataSource = avaliableSlips;
            //showListBoxItem(list);

        }

        //private void showListBoxItem(List<Slip> list)
        //{
        //    lstSlips.Items.Clear();
        //    foreach (var slip in list)
        //    {
        //        lstSlips.Items.Add(slip.ID.ToString());
        //    }
        //}
    }
}