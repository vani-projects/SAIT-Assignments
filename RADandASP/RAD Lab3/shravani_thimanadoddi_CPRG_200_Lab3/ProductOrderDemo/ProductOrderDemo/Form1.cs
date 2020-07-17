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
///  application that connects to the Northwind database using data source that includes tables: Products and Order Details
///  Author:Shravani.
///  Date:April 24
/// </summary>
namespace ProductOrderDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.northWindDataSet);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Another user changed or deleted data. Try again",
                    "Concurrency Exception");
                // refresh your data
                this.productsTableAdapter.Fill(this.northWindDataSet.Products);
            }
            catch (NoNullAllowedException) // adding no null allowed exception
            {
                MessageBox.Show("Data cannot be null",
                   "NoNullData Exception");
                // refresh your data
                this.productsTableAdapter.Fill(this.northWindDataSet.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occurred while saving data: " +
                    ex.Message, ex.GetType().ToString());
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northWindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northWindDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northWindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northWindDataSet.Categories);
            // TODO: This line of code loads data into the 'northWindDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northWindDataSet.Suppliers);
            // TODO: This line of code loads data into the 'northWindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northWindDataSet.Products);

        }

        
    }
}
