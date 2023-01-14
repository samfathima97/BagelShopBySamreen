using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagelShopBySamreen
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //method called from main form class and parameters are passed 
        public void ReceiptDisplay(int Txn, string Order,decimal Price)
        {
            //values are displayed 
            OrderNumberTextBox.Text = Txn.ToString();
            OrderTextBox.Text = Order.ToString();
            TotalPriceLabel.Text = Price.ToString("C2");
            DateTimeTextBox.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
          }
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
