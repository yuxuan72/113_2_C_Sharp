using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The IsValidFormat method accepts a string argument
        // and determines whether it is properly formatted as
        // a US telephone number in the following manner:
        // (XXX)XXX-XXXX
        // If the argument is properly formatted, the method
        // returns true, otherwise false.
        private bool IsValidFormat(string str)
        {
            if (str.Length == 13 &&
                str[0] == '(' &&
                str[3] == ')' &&
                str[8] == '-')
            {
                string areaCode = str.Substring(1, 2);
                string exchangeCode = str.Substring(4, 4);
                string subscriberNumber = str.Substring(9, 4);

                if (int.TryParse(areaCode, out _) &&
                    int.TryParse(exchangeCode, out _) &&
                    int.TryParse(subscriberNumber, out _))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // The unformat method accepts a string, by reference,
        // assumed to contain a telephone number formatted in
        // this manner: (XXX)XXX-XXXX.
        // The method unformats the string by removing the
        // parentheses and the hyphen.
        private void Unformat(ref string str)
        {
            str = str.Remove(0, 1); // Remove the opening parenthesis
            str = str.Remove(2, 1); // Remove the closing parenthesis
            str = str.Remove(6, 1); // Remove the hyphen
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text;

            if (IsValidFormat(input))
            {
                // Call the unformat method to remove formatting.
                Unformat(ref input);
                // Display the unformatted number in the text box.
                MessageBox.Show("去格式化後的電話號碼是: " + input,"錯誤",MessageBoxButtons.OK,MessageBoxIcons);
            }
            else
            {
                // Display an error message if the format is invalid.
                MessageBox.Show("去格式化後的正確電話號碼");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
