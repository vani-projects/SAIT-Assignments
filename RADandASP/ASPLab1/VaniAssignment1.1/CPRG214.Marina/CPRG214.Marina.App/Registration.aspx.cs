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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

       

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
               
                    FirstName = txtFName.Text,
                    LastName = txtLName.Text,
                    Phone = txtPhone.Text,
                    City = txtCity.Text
                   
                
            };
            //pass the auth object to the manager for inserting
            AuthenticationManager.Add(customer); // add customer to the database
            AuthenticationManager.Authenticate(customer.FirstName, customer.LastName); //authenticate the user
            Session.Add("customerID", customer.ID); //add custer to session to use in leaseslip 
            string custFullName = customer.FirstName + " " + customer.LastName;
            Session.Add("CustName", custFullName);
            // redirect - false means no persistent cookie
           

            FormsAuthentication.RedirectFromLoginPage(custFullName, false);
           
        }
    }
}