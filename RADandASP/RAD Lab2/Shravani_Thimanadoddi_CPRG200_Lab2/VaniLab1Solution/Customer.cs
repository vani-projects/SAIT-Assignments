using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VaniLab1Solution
{
    /// <summary>
    /// Solution: class representing Customer with the 
    /// properties: account number,customer name,type and cutomer charge amount.
    /// Date: April,2020.
    /// Author:Shravani.
    /// </summary>
    
    
    public class Customer
    {
        //private data shoulod be starting with lower case
        private string customerName;
        private int accountNo;
        private double chargeAmount;
        private char customerType;
        
       
       

        //adding properties
        //public names should start with Uppercase.
        /// <summary>
        /// customerName property which should be a non empty string
        /// </summary>
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (value != "")
                    customerName = value;
            }
        }

        /// <summary>
        /// AccountNo property where it should be positive interger value
        /// </summary>
        public int AccountNo
        {
            get { return accountNo; }
            set
            {
                if (value < 0) value = -value;
                accountNo = value;
            }

        }

        /// <summary>
        /// single char string that can be "R","C" or "I"
        /// </summary>
        /// 

        public char CustomerType
        {
            get { return customerType; }
            set
            {               
                if (value == 'R')
                   
                {
                    customerType = value;
                }
                else if (value == 'C')
                {
                    customerType = value;
                }
                else if (value == 'I')
                {
                    customerType = value;
                }
            }
        }

        /// <summary>
        /// chargeAmount which is a double and not a string
        /// </summary>
        public double ChargeAmount
        {
            get { return chargeAmount; }
            set
            {
                if (value.GetType() != typeof(string))
                {
                    chargeAmount = value;
                }
            }
        }


        //constructors
        //default constructor and constructor with parameters
        public Customer(){}
        public Customer(int acctnum,string custname,char custType, double charge)
        {
            AccountNo = acctnum;
            CustomerName = custname;
            CustomerType = custType;
            ChargeAmount = charge;
        }

        //calculate charge for the customer

        public double CalculateCharge(int kWhUsage,double flatRate,double addRate,int minKwh)
        {
            
            if (kWhUsage < minKwh)
                chargeAmount = flatRate;
            else
                chargeAmount = flatRate + ((kWhUsage - minKwh) * addRate);

            return chargeAmount;
        }

        //calculate charge for residential
        public double CalculateCharge(int kWhUsage, double flatRate, double addRate)
        {
            chargeAmount = flatRate + (kWhUsage  * addRate);

            return chargeAmount;
        }



        //tostring method
        public override string ToString()
        {
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = culture.TextInfo;
            customerName = textInfo.ToTitleCase(customerName);
            return customerName + ":\t" + accountNo.ToString() + ",\t " +customerType + ",\t" + chargeAmount.ToString("c");
        }

    }
}
