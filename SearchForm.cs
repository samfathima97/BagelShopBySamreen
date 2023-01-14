using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagelShopBySamreen
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        string TxnNum;
        string Date;//variable declaration
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Date = DatePicker.Value.ToString("dd-MM-yyyy");
            
                //transaction number input from textbox
                TxnNum = TxnNumIpTextBox.Text;

                // takes file name value from main form and passes to function in same form            
            //check if inputs are empty
            if (string.IsNullOrEmpty(TxnNum) && string.IsNullOrEmpty(Date))
            {
                MessageBox.Show("Please enter Transaction ID or date");
            }
            else
            {
                SearchFn(MainForm.TXN_FILE);
            }
        }

        public void SearchFn(string TxnFile)
        {
             
            string[] ReadFileArray = File.ReadAllLines(TxnFile);//allocates every line to one element of the array

            for (int i = 0; i < ReadFileArray.Length; i++)
            {
                if (string.IsNullOrEmpty(ReadFileArray[i]))
                {
                    continue;
                }
                if (ReadFileArray[i].Split(",")[0].Trim().Equals(TxnNum.Trim()) || (string.IsNullOrEmpty(TxnNum) && Convert.ToDateTime(ReadFileArray[i].Split(",")[1]).Date.Equals(Convert.ToDateTime(Date).Date)))
                 //check if number or date is a part of the line/element
                {
                    SearchOutputLabel.Text += ReadFileArray[i]+"\n";//if yes, displays the transaction line
                }                
            }

            if (string.IsNullOrEmpty(SearchOutputLabel.Text.Trim()))
            {
                SearchOutputLabel.Text = "No transaction records found!!";
            }



        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Date = "";
     
            this.Close();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchOutputLabel.Text = "";
            Date = "";
            TxnNumIpTextBox.Clear();
            TxnNum = "";
            

        }
    }
}
