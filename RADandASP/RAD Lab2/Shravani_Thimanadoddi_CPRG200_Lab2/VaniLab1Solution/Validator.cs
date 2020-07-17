using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaniLab1Solution
{
    public static class Validator
    {
        /// <summary>
        /// Tests if textbox is not empty
        /// </summary>
        /// <param name="tb">text box to be tested</param>
        /// <param name="word">word for the error message</param>
        /// <returns>true when not empty and false when empty</returns>
        public static bool IsPresent(TextBox tb, string word)
        {
            bool isValid = true;
            if (tb.Text == "")//there is no input from user
            {
                isValid = false;
                MessageBox.Show(word + " has to be provided", "Input Error");
                tb.Focus();//put focus to facilitate entry
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains non-negative whole number
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <param name="word">word for the error message</param>
        /// <returns>true if valid, false if not</returns>
        public static bool IsNonNegativeInteger(TextBox tb, string word)
        {
            bool isValid = true;
            int value; //for TryParse
            if (!Int32.TryParse(tb.Text, out value)) //not a correct integer
            {
                isValid = false;
                MessageBox.Show(word + " should be a whole number", "Input Error");
                tb.SelectAll(); // select content of the text box for replacement
                tb.Focus(); // focus ont he textbox to facilitate replacing content
            }
            else if (value < 0)// correct integer, but negative
            {
                isValid = false;
                MessageBox.Show(word + " should be zero or more", "Input Error");
                tb.SelectAll(); // select content of the text box for replacement
                tb.Focus(); // focus ont he textbox to facilitate replacing content
            }
            return isValid;
        }

       


    }
}
