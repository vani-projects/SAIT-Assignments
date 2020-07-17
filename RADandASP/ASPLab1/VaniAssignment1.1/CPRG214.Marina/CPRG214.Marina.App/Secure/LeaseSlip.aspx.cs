using CPRG214.Marina.App.Controls;
using CPRG214.Marina.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Marina.App.Secure
{
    public partial class LeaseSlip : System.Web.UI.Page
    {
        int Slip_Id; //declare varaibles for slipid and customerid
        int custId;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["CustomerID"] == null) return;
            else
            {
                showLeasedSlips(); //show leased slips for the login customer 
            }

        }

        protected void btnLease_Click(object sender, EventArgs e)
        {
            Slip_Id = DockSlipControl.SlipId; //get slipid from the usercontrol
            if (Session["CustomerID"] != null)
            {
                custId = (int)Session["customerID"];
            }
            var leaseSlip = new Lease
            {
                SlipID = Slip_Id,
                CustomerID = custId
            };

            //pass the leaseSlip object to the manager for inserting
            DockManager.Add(leaseSlip);

            showLeasedSlips(); //show leased slips 

            DockSlipControl.loadSlips(); //refresh the slip dorpdown 

        }

        private void showLeasedSlips()
        {
            custId = (int)Session["customerID"];
            IList leasedSlips = DockManager.FindLeasedSlip(custId);
            if (leasedSlips.Count > 0)
            {
                gvLeasedSlips.DataSource = leasedSlips;
                gvLeasedSlips.DataBind();
                lblMsg.Text = "";
            }
            else
            {
                string CustFullName = Session["CustName"].ToString();
                lblMsg.Text = CustFullName + " does not have any slips leased";
            }
        }
    }
}