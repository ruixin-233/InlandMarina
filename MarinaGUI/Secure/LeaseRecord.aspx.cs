using MarinaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarinaGUI.Secure
{
    public partial class LeaseRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["CustomerID"]) != 0)
            {
                // get customer ID out of the Session
                int custID = Convert.ToInt32(Session["CustomerID"]);

                Authentication authCust = MarinaManager.FindAuthentication(custID);

                MarinaEntities db = new MarinaEntities();

                var custLeaseRecord = (from l in db.Leases
                                      join s in db.Slips on l.SlipID equals s.ID 
                                      join c in db.Customers on l.CustomerID equals c.ID 
                                      join d in db.Docks on s.DockID equals d.ID
                                      where l.CustomerID == custID
                                      select new { Lease_ID = l.ID, 
                                          Customer_Name = c.FirstName +" " + c.LastName, 
                                          Dock = d.Name, Slip_ID = l.SlipID, s.Width, s.Length }).ToList();

                gvCustLeaseRecord.DataSource = custLeaseRecord;
                gvCustLeaseRecord.DataBind();

                //var custLeaseInfo = MarinaManager.GetLeaseRecord(custID);
                //gvCustLeaseRecord.DataSource = custLeaseInfo;

            }
            else
            {
                lblMessage.Text = "Authentication Error! Please try re-login.";
            }

        }
    }
}