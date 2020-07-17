using CPRG214.Marina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Usercontrol for loading docks and slips 
/// Author:Shravani
/// Date:May,2020
/// </summary>

namespace CPRG214.Marina.App.Controls
{
    public partial class DockSlipControl : System.Web.UI.UserControl
    {
       
        //set public properties slipId will be used for leasing the slips in LeaseSlip
      
        public string DockName
        {
            get { return dockList.SelectedItem.Text; }
        }

        
        public int SlipId
        {
            get { return Convert.ToInt32(slipList.SelectedValue); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var mgr = new DockManager();
                dockList.DataSource = mgr.GetAllAsListItems(); //get the docks and bind to the dropdownlist
                dockList.DataTextField = "Name";
                dockList.DataValueField = "ID";
                dockList.DataBind();
                dockList.SelectedIndex = 0;
               dockList_SelectedIndexChanged(null, null); //to fill the slips on pageload
               
            }
        }

        public void dockList_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSlips();            
           
        }

        //load slips dropdownlist for selected dock 
        //by calling the findslip method 

        public void loadSlips()
        {
            int id = Convert.ToInt32(dockList.SelectedValue);
            //get dock details
            Dock dock = DockManager.Find(id);
            lblDockName.Text = dock.Name;
            lblWaterService.Text = dock.WaterService.ToString();
            lblEService.Text = dock.ElectricalService.ToString();

            //call manager class to get the available slips and get dock obj
            slipList.DataSource = DockManager.FindSlip(id);

            slipList.DataTextField = "ID";
            slipList.DataValueField = "ID";
            slipList.DataBind();
            slipList.SelectedIndex = 0;
        }

      
    }
}