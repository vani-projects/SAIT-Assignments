using CPRG214.Marina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Marina.App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAuthenticate_Click(object sender, EventArgs e)
        {
            //pass the credentials to the authentication manager which is class in data project working with context
            var customer = AuthenticationManager.Authenticate(txtFName.Text, txtLName.Text);
            if(customer == null)
            {
                //the customer is not authenticated so send message and return
                lblError.Text = "Invalid login";
                txtFName.Text = string.Empty;
                txtLName.Text = string.Empty;
                txtFName.Focus();
               
                return;
            }

            //at this point, customer is not null meaning we have a valid authentication
            //so add customer id to session
            Session.Add("customerID", customer.ID);
            string custFullName = customer.FullName;
            Session.Add("CustName", custFullName);
            // redirect - false means no persistent cookie
            FormsAuthentication.RedirectFromLoginPage(customer.FullName, false);

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration?ReturnUrl="+ Request.QueryString["ReturnUrl"]);
        }
    }
}