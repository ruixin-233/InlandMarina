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

        // public preoperties
        public Slip SelectedDock { get; set; }

        public bool AllowAutoPostBack
        {
            get { return ddlDock.AutoPostBack; }
            set { ddlDock.AutoPostBack = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // populate the drop down list
                ddlDock.DataSource = DockManager.GetAll();
                ddlDock.DataValueField = "ID";
                ddlDock.DataTextField = "Name";
                ddlDock.DataBind();
                ddlDock.SelectedIndex = 0;
            }
        }

        // user selected from the drop down list
        protected void ddlDock_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fire the event CourseSelect
            if (DockSelect != null)    // if the event was subscribed to
            {
                // get the id from the drop down list
                int id = Convert.ToInt32(ddlDock.SelectedValue);

                // find the course with this id
                Slip slipInDock = SlipManager.FindDock(id);

                // set property
                SelectedDock = slipInDock;

                // instantiate the DockEventArgs class
                DockEventArgs arg = new DockEventArgs
                {
                    DockID = slipInDock.DockID.ToString(),
                    SlipID = slipInDock.ID.ToString(),
                };

                // invoke the event
                DockSelect.Invoke(this, arg);
            }

        }
    }
}