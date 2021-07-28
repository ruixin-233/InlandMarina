using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarinaGUI
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // toggle the navbar look depending on there user logged in or not
            // Context is property of Page, its type is Httpcontext
            // we can check: if Context.User.Identity.IsAuthenticated
            if (Context.User.Identity.IsAuthenticated)
            {
                uxWelcome.InnerText = $"Welcome {Context.User.Identity.Name}";
                uxLogin.InnerHtml = "<span class='fa fa-sign-out-alt'></span>";
            }
            else // nobody logged in
            {
                uxWelcome.InnerText = "";
                uxLogin.InnerHtml = "<span class='fa fa-sign-in-alt'></span>";
            }
        }

        // method that handles Click on the uxLogin in Site.Master
        protected void HandleLoginClick(object sender, EventArgs e)
        {
            if (Context.User.Identity.IsAuthenticated) // user logged in
            {
                // they want to log out
                FormsAuthentication.SignOut(); // removes authorization ticket from the browser
                Session.Clear(); // session is ending, so clear session state
                Response.Redirect("~/"); // home page
            }
            else
            {
                // somebody want to log in
                Response.Redirect("~/Login");
            }
        }
    }
}