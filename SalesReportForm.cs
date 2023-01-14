using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BagelShopBySamreen
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
        //method called from mainform clas nad parameters are passed
        public void Sales(int[,] SoldStock, int B, int S)
        {
            
            int height = SoldStock.GetLength(0);
            int width = SoldStock.GetLength(1);

            this.dataGridView1.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = SoldStock[r, c];
                }

                this.dataGridView1.Rows.Add(row);
            }

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
