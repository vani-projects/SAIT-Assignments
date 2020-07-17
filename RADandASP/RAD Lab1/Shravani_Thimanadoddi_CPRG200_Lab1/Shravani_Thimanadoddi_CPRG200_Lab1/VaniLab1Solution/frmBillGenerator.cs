using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Solution: To calculate a customer bill each customer 
/// at a time and by applying rates accordling to the customer type,
/// for the city power company.
///Date: April,2020
///Author: Vani
/// </summary>
namespace VaniLab1Solution
{
    public partial class frmBillGenerator : Form
    {
        /// <summary>
        /// declare the flat rates and additional rates provided for 
        /// customer type by the power company as constants
        /// Also, declare types of customer compnay has as constants.
        /// </summary>
        
        const double FLAT_RATE_RESIDENTIAL = 6.00;
        const double ADDITIONAL_RATE_RESIDENTIAL = 0.052;
        const double FLAT_RATE_COMMERCIAL = 60.00;
        const double ADDITIONAL_RATE_COMMERCIAL = 0.045;
        const double FLAT_RATE_INDUSTRIAL_PEAK = 76.00;
        const double ADDITIONAL_RATE_INDUSTRIAL_PEAK = 0.065;
        const double FLAT_RATE_INDUSTRIAL_OFFPEAK = 40.00;
        const double ADDITIONAL_RATE_INDUSTRIAL_OFFPEAK = 0.028;

        const int FLAT_RATE_KWH = 1000;

       
        public frmBillGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Code to calculate bill customers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void btnCalculateBill_Click(object sender, EventArgs e)
        {
            try
            {
                double totalUsage;
                double finalBill = 0;
                txtBillAmount.Text = "";
                
                if(rbtnResidential.Checked == true || rbtnCommercial.Checked == true)
                {
                    if(Validator.IsPresent(txtInputPowerUsed, txtInputPowerUsed.Tag.ToString()) &&
                       Validator.IsNonNegativeInteger(txtInputPowerUsed , txtInputPowerUsed.Tag.ToString()) //check for valid user input 
                        )
                    {
                        totalUsage = Convert.ToInt32(txtInputPowerUsed.Text);
                        if(rbtnResidential.Checked ==true) // if residential customer is selected
                        {
                            finalBill = CalculateResidentialBill(totalUsage); // call method to calculate bill for residential user which will  return the bill value to finalBill 
                        }
                        else if(rbtnCommercial.Checked == true) // if commercial customer is selected
                        {
                            finalBill = CalculateCommercialBill(totalUsage); //call method to calculate bill for commercial user  which will  return the bill value to finalBill
                        }
                        txtBillAmount.Text = finalBill.ToString("c"); // print the bill for user
                    }
                }
                else if(rbtnIndustrial.Checked ==true) // if industrial user is selected
                {
                    int peakHourUsage = -1;
                    int offpeakHourUsage = -1;
                    lblPowerUsed.Text = "kWh Used (Peak Hours)";
                    if ( Validator.IsPresent(txtInputPowerUsed, txtInputPowerUsed.Tag.ToString() + "(Peak Hours)") &&
                        Validator.IsNonNegativeInteger(txtInputPowerUsed, txtInputPowerUsed.Tag.ToString() + "(Peak Hours)") &&
                        Validator.IsPresent(txtOffpeakUsage, txtOffpeakUsage.Tag.ToString()) &&
                        Validator.IsNonNegativeInteger(txtOffpeakUsage, txtOffpeakUsage.Tag.ToString())
                        ) // check for valid user inputs
                    {
                        peakHourUsage = Convert.ToInt32(txtInputPowerUsed.Text);
                        offpeakHourUsage = Convert.ToInt32(txtOffpeakUsage.Text);
                        finalBill = CalculateIndustrialBill(peakHourUsage, offpeakHourUsage); // calculate bill for peak hour and offpeak hour  which will  return the bill value to finalBill
                        txtBillAmount.Text = finalBill.ToString("c"); //print the bill for user

                    }
                   
                }
            }
            catch(Exception ex) //catch if any unexpected errors occur
            {
                MessageBox.Show(ex.Message); 
            }
        }

        /// <summary>
        /// Calulate Industrial customer power bill
        /// </summary>
        /// <param name="peakHourUsage">kWh used during peak hour.
        /// If peakHr is greater than 1000, get the additional hours charges that apply.</param>
        /// <param name="offpeakHourUsage">kWh used during off-peak hour
        /// using the same logic as peak hr to off peak hour bill calculation</param>
        /// <returns>total bill by calculating for peak hour and off peak hour units if any</returns>
        private double CalculateIndustrialBill(int peakHourUsage, int offpeakHourUsage)
        {
            double peakHrBill, offpeakHrBill, IndustrialBill;
            if(peakHourUsage >FLAT_RATE_KWH)
            {
                peakHrBill = FLAT_RATE_INDUSTRIAL_PEAK +
                            (ADDITIONAL_RATE_INDUSTRIAL_PEAK * (peakHourUsage - FLAT_RATE_KWH));
            }
            else
            {
                peakHrBill = FLAT_RATE_INDUSTRIAL_PEAK;
            }
            if (offpeakHourUsage > FLAT_RATE_KWH)
            {
                offpeakHrBill = FLAT_RATE_INDUSTRIAL_OFFPEAK +
                            (ADDITIONAL_RATE_INDUSTRIAL_OFFPEAK * (offpeakHourUsage - FLAT_RATE_KWH));
            }
            else
            {
                offpeakHrBill = FLAT_RATE_INDUSTRIAL_OFFPEAK;
            }
            IndustrialBill = peakHrBill + offpeakHrBill;
            return IndustrialBill;
        }

        /// <summary>
        /// Calculate bill for commercial customer
        /// </summary>
        /// <param name="totalUsage">total units used by the User.
        /// if total units are greater than 1000, get the additional hours charges that apply</param>
        /// <returns>Total bill for the units used </returns>
        private double CalculateCommercialBill(double totalUsage)
        {
            double commercialBill;
            if(totalUsage > FLAT_RATE_KWH)
            {
                commercialBill = FLAT_RATE_COMMERCIAL + (ADDITIONAL_RATE_COMMERCIAL * (totalUsage - FLAT_RATE_KWH));
              
            }
            else
            {
                commercialBill = FLAT_RATE_COMMERCIAL;
            }
            return commercialBill;
        }

        /// <summary>
        /// calculate bill for residential customer
        /// </summary>
        /// <param name="totalUsage">User input of Number of units used</param>
        /// <returns>total bill for the units used</returns>
        private double CalculateResidentialBill(double totalUsage)
        {
            double residentialBill;
            residentialBill = FLAT_RATE_RESIDENTIAL + (ADDITIONAL_RATE_RESIDENTIAL * totalUsage);
            return residentialBill;
        }

        private void rbtnResidential_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideFields();
        }

        /// <summary>
        /// display Commercial input panel by hiding residential and industrial 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnCommercial_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideFields();
        }



        /// <summary>
        /// display industrial customer panel of input controls and hide residential and commercial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideFields();
        }




       /// <summary>
       /// Reset the controls to reflect the default residential customer type
       /// also clears the input and output data
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }



        /// <summary>
        /// code to exit from the application. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        /// <summary>
        /// On form load display default view for residential customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBillGenerator_Load(object sender, EventArgs e)
        {
            rbtnResidential.Checked = true;
            pnlResidentialCommercial.Visible = true;
            txtInputPowerUsed.Focus();
            pnlIndustrial.Visible = false;
        }
       

        

        /// <summary>
        /// reset controls to default view.
        /// </summary>
        private void ResetFields()
        {
            rbtnResidential.Checked = true;
           
            pnlIndustrial.Visible = false;
            txtInputPowerUsed.Focus();
            txtInputPowerUsed.Text = "";
            txtBillAmount.Text = "";
           
            txtOffpeakUsage.Text = "";
        }




        /// <summary>
        /// If Residential or Commercial Customers are selected hide Industrial customers 
        /// power usage fields for peak and off peak hours.
        /// Do vice versa for Indusrial.
        /// Set focus on the appriopriate user input text box  field.
        /// </summary>
        private void ShowHideFields()
        {
            if(rbtnResidential.Checked == true || rbtnCommercial.Checked == true)
            {

                lblPowerUsed.Text = "kWh Used";
                pnlIndustrial.Visible = false;
                txtInputPowerUsed.Focus();
                txtInputPowerUsed.Text = "";
                txtBillAmount.Text = "";               
                txtOffpeakUsage.Text = "";
            }
            else
            {

                lblPowerUsed.Text = "kWh Used(Peak Hours)";
                pnlIndustrial.Visible = true;
                txtInputPowerUsed.Focus();
                txtInputPowerUsed.Text = "";
                txtBillAmount.Text = "";               
                txtOffpeakUsage.Text = "";
            }
        }

       
    }
}

