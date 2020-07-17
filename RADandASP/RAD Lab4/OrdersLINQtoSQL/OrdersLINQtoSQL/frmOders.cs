using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Solution: For Displaying Orders and its details from NorthWind db.
/// Calculate the OrderTotal 
/// Update with new Shipped Date which is not before order date and after required date
/// All the fields are ReadOnly except the ShippedDate.
/// Assuming User will not write on the orderID combobox.
/// Date:April 2020
/// Author:Shravani.
/// </summary>
namespace OrdersLINQtoSQL
{
    public partial class frmOders : Form
    {
        //private OrdersDataContext db = new OrdersDataContext();
        Order orders; // create object reference to the the Order class
        public frmOders()
        {
            InitializeComponent();
        }
        
        //fill the order combobox datasource with the data from database by using dbcontext 
        private void Form1_Load(object sender, EventArgs e)
        {
            //display orders details and order when formloads from the database.
            using (OrdersDataContext db = new OrdersDataContext()) //connect to db
            {
                orderIDComboBox.DataSource = from ord in db.Orders  //fill the combobox i.e datasource with order id's from orders table
                                             orderby ord.OrderID
                                             select ord.OrderID;
                
            }
        }

        //display details of the order like cutsomerid,requireddate on the orderid selecting change
        private void orderIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            using (OrdersDataContext db = new OrdersDataContext())
            {
                //get the first row of  order data for the selected order
                //also fill the orderdetails grid for the order selected 
                orders = (from ord in db.Orders
                          where ord.OrderID == (int)orderIDComboBox.SelectedItem
                          select ord).Single();
                order_DetailsDataGridView.DataSource = (from od in db.Order_Details
                                                        where od.OrderID == (int)orderIDComboBox.SelectedItem
                                                        select od).ToList();
            }
            //fill the controls with data from database whichis stored in orders object.
            customerIDTextBox.Text = orders.CustomerID;
            orderDateDateTimePicker.Value = (DateTime)orders.OrderDate;
            requiredDateDateTimePicker.Value = (DateTime)orders.RequiredDate;
            if (orders.ShippedDate == null) // If the shipped data is null, disable shippedData date picker control and show it disabled.
            {
                cbxEnable.Checked = false;
                shippedDateDateTimePicker.Enabled = false;
            }
            else // Enable the shippedDate date picker control and show it enabled.
            {
                cbxEnable.Checked = true;
                shippedDateDateTimePicker.Enabled = true;
                shippedDateDateTimePicker.Value = (DateTime)orders.ShippedDate;
            }
            DisplayOrderTotal();
            

        }

        //calculate orderTotal for an Order
        private void DisplayOrderTotal()
        {
            double total = 0;
            double sum = 0;
            double unitPrice = 0;
            double discount = 0;
            int quanity = 0;
            for(int i = 0;i < order_DetailsDataGridView.Rows.Count; i++)
            {
                 unitPrice = Convert.ToDouble( order_DetailsDataGridView.Rows[i].Cells[2].Value);
                 discount = Convert.ToDouble( order_DetailsDataGridView.Rows[i].Cells[4].Value);
                 quanity = Convert.ToInt32(order_DetailsDataGridView.Rows[i].Cells[3].Value);
                 sum = unitPrice * (1 - discount) * quanity;
                 total += sum;
            }

            lblOrderTotal.Text = total.ToString("c");
        }

        /// <summary>
        /// update the shipped date in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (validateShippedDate()) {
                try
                {
                    using (OrdersDataContext db = new OrdersDataContext())
                    {
                        Order newOrder = db.Orders.Single
                            (no => no.OrderID == orders.OrderID);
                        if (newOrder != null)
                        {
                            newOrder.ShippedDate = orders.ShippedDate;
                            db.SubmitChanges();
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch (ChangeConflictException)
                {
                    MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                    DialogResult = DialogResult.Retry;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// validate shipdate 
        /// </summary>
        /// <returns></returns>
        private bool validateShippedDate()
        {
            bool dataValid = true;
            if (cbxEnable.Checked)
            {

                DateTime newShippedDate = shippedDateDateTimePicker.Value.Date;
                TimeSpan timeSpanOrderShip = newShippedDate.Subtract(orderDateDateTimePicker.Value.Date);
                TimeSpan timeSpanRequiredShip = newShippedDate.Subtract(requiredDateDateTimePicker.Value.Date);
                int daysShipOrder = timeSpanOrderShip.Days;
                int daysShipRequired = timeSpanRequiredShip.Days;
                if (daysShipOrder < 0)
                {
                    MessageBox.Show("Shipped date cannot be before order date", "Early");
                    shippedDateDateTimePicker.Focus();
                    dataValid = false;
                }
                if (daysShipRequired > 0)
                {
                    MessageBox.Show("Shipped date cannot be after required date", "Late");
                    shippedDateDateTimePicker.Focus();
                    dataValid = false;
                }
                if (dataValid)
                    orders.ShippedDate = shippedDateDateTimePicker.Value;
            }
            return dataValid;
        }

        private void cbxEnable_CheckedChanged(object sender, EventArgs e)
        {
            shippedDateDateTimePicker.Enabled = cbxEnable.Checked;
            if (!cbxEnable.Checked)
            {
                orders.ShippedDate = null;
            }
        }
    }
}
