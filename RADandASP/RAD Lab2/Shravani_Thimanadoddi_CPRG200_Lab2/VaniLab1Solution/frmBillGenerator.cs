using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Solution: To calculate a customer bill each customer 
/// at a time and by applying rates accordling to the customer type,
/// for the city power company.
/// Refactored code to save customer data on external file and open from the file to
/// display customers in the list box.
/// Also adding features to show sum of all charges, sum of charges for each customer type and
/// total number of customers.
///
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

        //collection list for storing customer data
        List<Customer> customers = new List<Customer>();

        //name of the file who's stored in \bin\debug path
        const string path = "customers.txt";
        double finalBill = 0;
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
                int totalUsage;
                Customer customer = new Customer();

                txtBillAmount.Text = "";

                if (rbtnResidential.Checked == true || rbtnCommercial.Checked == true)
                {
                    if (Validator.IsPresent(txtInputPowerUsed, txtInputPowerUsed.Tag.ToString()) &&
                       Validator.IsNonNegativeInteger(txtInputPowerUsed, txtInputPowerUsed.Tag.ToString()) &&
                       Validator.IsPresent(txtAcctNo, txtAcctNo.Tag.ToString()) &&
                       Validator.IsNonNegativeInteger(txtAcctNo, txtAcctNo.Tag.ToString()) &&
                       Validator.IsPresent(txtCustName, txtCustName.Tag.ToString())
                        )
                    {
                        //read data if valid
                        totalUsage = Convert.ToInt32(txtInputPowerUsed.Text);

                        //calculate bill for residential and commercial customers by calling method defined in class customer

                        if (rbtnResidential.Checked == true) // if residential customer is selected
                        {

                            finalBill = customer.CalculateCharge(totalUsage, FLAT_RATE_RESIDENTIAL, ADDITIONAL_RATE_RESIDENTIAL); // call method to calculate bill for residential user which will  return the bill value to finalBill 
                        }
                        else if (rbtnCommercial.Checked == true) // if commercial customer is selected
                        {
                            finalBill = customer.CalculateCharge(totalUsage, FLAT_RATE_COMMERCIAL, ADDITIONAL_RATE_COMMERCIAL,FLAT_RATE_KWH); //call method to calculate bill for commercial user  which will  return the bill value to finalBill
                        }

                        //display the billed amount 
                        txtBillAmount.Text = finalBill.ToString("c"); // print the bill for user
                    }
                }
                else if (rbtnIndustrial.Checked == true) // if industrial user is selected
                {
                    int peakHourUsage = -1;
                    int offpeakHourUsage = -1;
                    double peakBill;
                    double offpeakBill;
                    lblPowerUsed.Text = "kWh Used (Peak Hours)";
                    if (Validator.IsPresent(txtInputPowerUsed, txtInputPowerUsed.Tag.ToString() + "(Peak Hours)") &&
                        Validator.IsNonNegativeInteger(txtInputPowerUsed, txtInputPowerUsed.Tag.ToString() + "(Peak Hours)") &&
                        Validator.IsPresent(txtOffpeakUsage, txtOffpeakUsage.Tag.ToString()) &&
                        Validator.IsNonNegativeInteger(txtOffpeakUsage, txtOffpeakUsage.Tag.ToString()) &&
                         Validator.IsPresent(txtAcctNo, txtAcctNo.Tag.ToString()) &&
                       Validator.IsNonNegativeInteger(txtAcctNo, txtAcctNo.Tag.ToString()) &&
                       Validator.IsPresent(txtCustName, txtCustName.Tag.ToString())
                        ) // check for valid user inputs
                    {
                        //if valid read input from text box

                        peakHourUsage = Convert.ToInt32(txtInputPowerUsed.Text);
                        offpeakHourUsage = Convert.ToInt32(txtOffpeakUsage.Text);

                        //calculate bill amount charged by calling customer class method 
                        peakBill = customer.CalculateCharge(peakHourUsage, FLAT_RATE_INDUSTRIAL_PEAK, ADDITIONAL_RATE_INDUSTRIAL_PEAK,FLAT_RATE_KWH);
                        offpeakBill = customer.CalculateCharge(offpeakHourUsage, FLAT_RATE_INDUSTRIAL_OFFPEAK, ADDITIONAL_RATE_INDUSTRIAL_OFFPEAK,FLAT_RATE_KWH);

                        //display charge for industrial customer
                        finalBill = peakBill + offpeakBill;
                        txtBillAmount.Text = finalBill.ToString("c"); //print the bill for user

                    }

                }
            }
            catch (Exception ex) //catch if any unexpected errors occur
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// display Commercial input panel by hiding residential and industrial  and vice-versa
        /// </summary>
        private void rbtnResidential_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideFields();
        }


        private void rbtnCommercial_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideFields();
        }


        private void rbtnIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideFields();
        }

        /// <summary>
        /// Reset the controls to reflect the default residential customer type
        /// also clears the input and output data
        /// </summary>      
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        /// <summary>
        /// code to exit from the application. 
        /// </summary>

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// On form load display default view for residential customer
        /// create file customers.txt if not exist 
        /// and start with empty list first run or 
        /// open existing file for reading (subsequent runs)
        /// </summary>
        
        private void frmBillGenerator_Load(object sender, EventArgs e)
        {
            rbtnResidential.Checked = true;
            pnlResidentialCommercial.Visible = true;
            txtInputPowerUsed.Focus();
            pnlIndustrial.Visible = false;

            //lab2
            FileStream fs;
            StreamReader sr = null;
            string line;
            string[] fields;
            Customer customer;
            int accountno;
            string name;
            char custType;
            double charge;
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);

                //read data
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    fields = line.Split('|');
                    accountno = Convert.ToInt32(fields[0]);
                    name = fields[1];
                    custType = Convert.ToChar(fields[2]);
                    charge = Convert.ToDouble(fields[3]);
                    customer = new Customer(accountno, name, custType, charge);
                    customers.Add(customer);
                }
                DisplayCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading customers from file: " +
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }


        /// <summary>
        /// reset controls to default view.
        /// </summary>
        private void ResetFields()
        {
            rbtnResidential.Checked = true;
            pnlIndustrial.Visible = false;
            txtAcctNo.Focus();
            txtInputPowerUsed.Text = "";
            txtBillAmount.Text = "";
            txtAcctNo.Text = "";
            txtCustName.Text = "";
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
            if (rbtnResidential.Checked == true || rbtnCommercial.Checked == true)
            {

                lblPowerUsed.Text = "kWh Used";
                pnlIndustrial.Visible = false;
                txtAcctNo.Focus();
                txtAcctNo.Text = "";
                txtCustName.Text = "";
                txtInputPowerUsed.Text = "";
                txtBillAmount.Text = "";
                txtOffpeakUsage.Text = "";
            }
            else
            {

                lblPowerUsed.Text = "kWh Used(Peak Hours)";
                pnlIndustrial.Visible = true;
                txtAcctNo.Focus();
                txtAcctNo.Text = "";
                txtCustName.Text = "";
                txtInputPowerUsed.Text = "";
                txtBillAmount.Text = "";
                txtOffpeakUsage.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int accountnumber;
            string name;
            char custype = 'R';
            double charge;
            Customer newCust;



            //collect new customer data and create an object
            accountnumber = Convert.ToInt32(txtAcctNo.Text);
            name = txtCustName.Text;

            foreach (RadioButton rbtn in grpBoxCustomerType.Controls)
            {
                if (rbtn.Checked == true)
                {
                    custype = Convert.ToChar(rbtn.Tag);
                }
            }
            charge = finalBill;

            //create new customer object
            newCust = new Customer(accountnumber, name, custype, charge);

            //add new customer to the list customers
            customers.Add(newCust);
            DisplayCustomers();
        }

        /// <summary>
        /// method to calculate the sum charges for each customer type
        /// </summary>

        private void DisplaySumChargeOfCustomerType()
        {
            double sumR = 0, sumC = 0, SumI = 0;
            foreach (Customer c in customers)
            {

                if (c.CustomerType == 'R')
                {
                    sumR += c.ChargeAmount;
                }
                else if (c.CustomerType == 'C')
                {
                    sumC += c.ChargeAmount;
                }
                else
                {
                    SumI += c.ChargeAmount;
                }

                lblRSum.Text = sumR.ToString("c");
                lblCSum.Text = sumC.ToString("c");
                lblISum.Text = SumI.ToString("c");
            }
        }

        /// <summary>
        /// display customers information in the list box.
        /// </summary>
        private void DisplayCustomers()
        {
            double sum;
            //list box
            lstCustData.Items.Clear();
            foreach (Customer c in customers)
            {
                lstCustData.Items.Add(c);
            }
            lblCustomerCount.Text = customers.Count.ToString();
            sum = CalculateTotalBill();
            DisplaySumChargeOfCustomerType();
            lblTotalSum.Text = sum.ToString("c");
        }

        /// <summary>
        /// method to calculate sum of all charges
        /// </summary>
        /// <returns></returns>
        private double CalculateTotalBill()
        {
            double totalSum = 0;
            foreach (Customer c in customers)
            {
                totalSum += c.ChargeAmount;
            }
            return totalSum;

        }

        /// <summary>
        /// save the customer data on to a text file using file stream and stream writer 
        /// </summary>
       

        private void frmBillGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs;
            StreamWriter sw = null;
            string line;
            try
            {
                //open file for writing
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

                //write all customers to the file 
                //

                foreach (Customer c in customers)
                {
                    line = c.AccountNo + "|" + c.CustomerName + "|" + c.CustomerType + "|" + c.ChargeAmount;
                    sw.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while writing products from file: " +
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}

