using MarinaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarinaGUI.Controls
{
    public partial class Registration : System.Web.UI.UserControl
    {
        public bool IsUpdate { get; set; } // distinguishes Update from Add

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                // display current data values for the registration
                if (Session["Id"] != null && txtFirstName.Text == string.Empty)
                // only need to do it when text boxes empty
                {
                    // get customer ID out of the Session
                    int custID = Convert.ToInt32(Session["Id"]);

                    // get authentication record for this student
                    Customer authCust = CustomerManager.Find(custID);
                    if (authCust != null)
                    {
                        // display data in wizard's textboxes
                        txtFirstName.Text = authCust.FirstName;
                        txtLastName.Text = authCust.LastName;
                        txtPhone.Text = authCust.Phone;
                        txtCity.Text = authCust.City;
                        txtUserName.Text = authCust.FirstName;
                        txtPassword.Text = authCust.LastName;
                    }
                }
            }
        }

        // submit button for the wizard
        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (IsUpdate)
            {
                if (Session["Id"] != null)
                {
                    // get customer id out of Session
                    int custID = Convert.ToInt32(Session["Id"]);
                    Customer authCust = CustomerManager.Find(custID);
                    authCust.FirstName = txtFirstName.Text;
                    authCust.LastName = txtLastName.Text;
                    authCust.Phone = txtPhone.Text;
                    authCust.City = txtCity.Text;
                    // pass to the manager class for update
                    CustomerManager.Update(authCust);

                    // force the user to log in again  after update
                    FormsAuthentication.SignOut();// remove from auth ticket
                    Session.Clear();
                    Response.Redirect("~/Login");
                }
            }
            else // inserting new record
            {
                // new data from text boxes (no Id nor StudentId, just the collected data)
                Customer cust = new Customer
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    City = txtCity.Text,
                };


                CustomerManager.Add(cust); // pass to the manager class for Add
                Response.Redirect("~/Login"); // give the user opportunity to log in

            }
        }

    }
}