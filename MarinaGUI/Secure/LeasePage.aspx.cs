using MarinaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MarinaGUI.Secure
{
    public partial class LeasePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DockSelector.DDL_Dock_Control.Load += new EventHandler(InitSlipDataByDock_UserControl_Clicked);
            DockSelector.DockSelect += DockSelector_DockSelect; // subscribe to the event

            int custID = Convert.ToInt32(Session["CustomerID"]);

            txt1.Text = custID.ToString();
        }


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

        protected void gvSlips_SelectedIndexChanged(object sender, EventArgs e)
        {
            // confirmation message for deleting data 
            DialogResult result =
                MessageBox.Show($"Do you want to rent slip #{gvSlips.SelectedRow.Cells[1].Text}?",
                "Lease", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) // if delete is confirmed
            {
                // only need to do it when text boxes empty
                {
                    // get customer ID out of the Session
                    int custID = Convert.ToInt32(Session["CustomerID"]);

                    Lease lease = new Lease
                    {
                        SlipID = Convert.ToInt32(gvSlips.SelectedRow.Cells[1].Text),
                        CustomerID = custID
                    };

                    MarinaManager.LeaseSlips(lease);
                    Response.Redirect("~/");
                }

            }
        }
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

        //private void showListBoxItem(List<Slip> list)
        //{
        //    lstSlips.Items.Clear();
        //    foreach (var slip in list)
        //    {
        //        lstSlips.Items.Add(slip.ID.ToString());
        //    }
        //}
    }

