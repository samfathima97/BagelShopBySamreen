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
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            //on form load it displays date and time 
            DateTextBox.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
        //method is called from main form class and values are passed 
        public void SummaryDisplay(int NoOfBagelsSold, decimal TotalSalesValue,int NoOfTxns,decimal AvgValue)
        {
            //values dispalyed to form text boxes
            TotNoOfBagelsTextBox.Text= NoOfBagelsSold.ToString();
            TotalSalesValueTextBox.Text= TotalSalesValue.ToString("C2");
            TotNoOfTxnsTextBox.Text = NoOfTxns.ToString();
            AvgValueTextBox.Text = AvgValue.ToString("C2");
        
        }
        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
