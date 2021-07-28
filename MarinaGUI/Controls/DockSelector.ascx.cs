using MarinaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarinaGUI.Controls
{
    public partial class DockSelector : System.Web.UI.UserControl
    {
        // declare event
        public event DockSelectionHandler DockSelect;

        // public properties
        public List<Slip> SelectedDock { get; set; }

        public bool AllowAutoPostBack
        {
            get { return ddlDock.AutoPostBack; }
            set { ddlDock.AutoPostBack = value; }
        }

        // return ddlDock property
        public DropDownList DDL_Dock_Control
        {
            get
            {
                return ddlDock;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // populate the drop down list
                ddlDock.DataSource = MarinaManager.GetAllDocks();
                ddlDock.DataValueField = "ID";
                ddlDock.DataTextField = "Name";
                ddlDock.DataBind();
                ddlDock.SelectedIndex = 0;
             
            }
        }

        // user selected from the drop down list
        protected void ddlDock_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fire the event DockSelect
            if (DockSelect != null)    // if the event was subscribed to
            {
                // get the id from the drop down list
                int id = Convert.ToInt32(ddlDock.SelectedValue);

                // find slips with dock id
                var slipInDock = MarinaManager.AvailableSlip(id);

                // set property
                //SelectedDock = slipInDock;

                // instantiate the DockEventArgs class
                DockEventArgs arg = new DockEventArgs
                {
                    DockID = id.ToString(),
                    SlipID = slipInDock
                };

                // invoke the event
                DockSelect.Invoke(this, arg);
            }

        }
    }
}