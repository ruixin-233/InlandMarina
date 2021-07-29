using MarinaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarinaGUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAuthenticate_Click(object sender, EventArgs e)
        {
            // pass login credentials to AuthenticationManager
            CustomerDTO custDTO = MarinaManager.
                Authenticate(txtUserName.Text, txtPassword.Text);
            if (custDTO == null) // failed authentication
            {
                lblMessage.Text = "Invalid login";
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
            }
            else // authentication success
            {
                // preserve stdent id in the session for possible update registration
                Session.Add("CustomerID", custDTO.ID);

                // redirect to original page that was requested
                FormsAuthentication.RedirectFromLoginPage(custDTO.FullName, false);

                Response.Redirect("~/Secure/LeasePage");
            }
        }

    }
}