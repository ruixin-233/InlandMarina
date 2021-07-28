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
                if (Session["CustomerID"] != null && txtFirstName.Text == string.Empty)
                // only need to do it when text boxes empty
                {
                    // get customer ID out of the Session
                    int custID = Convert.ToInt32(Session["Id"]);

                    // get authentication record for this student
                    Authentication authCust = MarinaManager.FindAuthentication(custID);
                    if (authCust != null)
                    {
                        // display data in wizard's textboxes
                        txtFirstName.Text = authCust.Customer.FirstName;
                        txtLastName.Text = authCust.Customer.LastName;
                        txtPhone.Text = authCust.Customer.Phone;
                        txtCity.Text = authCust.Customer.City;
                        txtUserName.Text = authCust.Username;
                        txtPassword.Text = authCust.Password;
                    }
                }
            }
        }

        // submit button for the wizard
        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (IsUpdate)
            {
                if (Session["CustomerID"] != null)
                {
                    // get customer id out of Session
                    int custID = Convert.ToInt32(Session["Id"]);
                    Authentication authCust = MarinaManager.FindAuthentication(custID);
                    authCust.Customer.FirstName = txtFirstName.Text;
                    authCust.Customer.LastName = txtLastName.Text;
                    authCust.Customer.Phone = txtPhone.Text;
                    authCust.Customer.City = txtCity.Text;
                    // pass to the manager class for update
                    MarinaManager.UpdateAuthentication(authCust);

                    // force the user to log in again  after update
                    FormsAuthentication.SignOut();// remove from auth ticket
                    Session.Clear();
                    Response.Redirect("~/Login");
                }
            }
            else // inserting new record
            {
                // new data from text boxes (no Id nor StudentId, just the collected data)
                Authentication authCust = new Authentication
                {
                    Username = txtUserName.Text,
                    Password = txtPassword.Text,
                    Customer = new Customer
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Phone = txtPhone.Text,
                        City = txtCity.Text
                    }
                };
                MarinaManager.AddAuthentication(authCust); // pass to the manager class for Add
                Response.Redirect("~/Login"); // give the user opportunity to log in

            }
        }

    }
}