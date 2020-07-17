using CPRG214.Marina.App.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// this page uses usercontrol dockslipcontrol which takes care of loading docks and available slips 
/// </summary>

namespace CPRG214.Marina.App
{
    public partial class Docks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            
        }         

        protected void lBtnLeaseSlip_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Secure/LeaseSlip");//derirect to page to lease slip
        }
    }
}