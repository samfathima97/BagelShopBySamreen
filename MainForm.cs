/* Student Name: Samreen Fathima
 * Student ID: 22101335
 * Date:28/11/2022
 * Assignment: 4
 * Assignment: Create a well-designed electronic point of sale (EPOS) application for use by BagelShop counter staff in processing
customer orders.
 */

using System.Drawing.Text;
using System.Globalization;
using System.Net.NetworkInformation;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Buffers;

namespace BagelShopBySamreen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //Price file and stock file read on every form load so below methods are called on every form load event

            ReadPriceFile();
            ReadStockFile();


        }



        //Variable declaration and initiailization 
        string Separator = ",";
        public readonly static int NumberOfBagels = 13;
        public readonly static int NumberOfSizes = 5;

        public decimal[,] PricesArray = new decimal[NumberOfBagels, NumberOfSizes];
        public int[,] StockArray = new int[NumberOfBagels, NumberOfSizes];
        public int[,] TmpStock = new int[NumberOfBagels, NumberOfSizes];
        public int[,] OpeningStock=new int[NumberOfBagels, NumberOfSizes];
        public int[,] TempSoldStock = new int[NumberOfBagels, NumberOfSizes];

        public int[,] SoldStock = {{0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}};
        


        int Quantity;
        StreamReader IpFile;
        StreamWriter OpFile;

        string OrderSumDisplayLine;
        string TxnOrderSummary = "";
        string ConfirmationOrderSummary = "";
        //file names are constants
        const string PRICE_FILE = "Price.txt";
        const string STOCK_FILE = "BagelStock.txt";
        public const string TXN_FILE = "TransactionRecords.txt";

        int NoOfTransactions = 0; int TotalQuantity; int TmpQty; decimal TotalSalesValue, AvgValue;

        decimal TotalPrice = 0m;
        decimal Price;
        int BagelNameIndex, BagelSizeIndex;
        //Bagel Name Array
        private static String[] BagelNames = { "Plain", "Cinnamon Raisin",
            "Blueberry", "Chocolate Chip", "Onion", "Salt",
            "Poppy Seed", "French Toast", "Egg", "Whole Wheat",
            "Garlic", "Sesame", "Cheddar" };
        //Bagel Size Array
        private static String[] BagelSizes = { "Small", "Medium", "Regular", "Large", "Extra-large" };

        private void Form1_Load(object sender3, EventArgs e)
        {
            //On Form load, items are added to bagel name and type lists
            BagelNameListBox.Items.AddRange(BagelNames);
            BagelSizeListBox.Items.AddRange(new object[] {"Small", "Medium",
            "Regular","Large","Extra-large"});
            //Complete button enabled only when an order is added to order
            CompleteButton.Enabled = false;
            

        }
        public void ReadPriceFile()//method to read price from file to an array
        {
            string[] AllPriceRows, PriceRow;

            IpFile = File.OpenText("BagelPrices.txt");
            AllPriceRows = File.ReadAllLines("BagelPrices.txt");
            for (int row = 0; row < AllPriceRows.Length; row++)
            {
                PriceRow = AllPriceRows[row].Split(Separator);
                for (int col = 0; col < PriceRow.Length; col++)
                {
                    PricesArray[row, col] = Convert.ToDecimal(PriceRow[col]);
                }
            }
            IpFile.Close();
        }

        public void ReadStockFile()//method to read stocks from file to an array
        {
            string[] AllStockRows, StockRow;
            try
            {
                IpFile = File.OpenText(STOCK_FILE);
                AllStockRows = File.ReadAllLines(STOCK_FILE);
                for (int row = 0; row < AllStockRows.Length; row++)
                {
                    StockRow = AllStockRows[row].Split(Separator);//Splits by comma and reads values from text file
                    for (int col = 0; col < StockRow.Length; col++)
                    {
                        StockArray[row, col] = int.Parse(StockRow[col]);

                    }
                }
                TmpStock = StockArray;//Assign copying value to a temp/working 2D array
                OpeningStock = StockArray;//Opening stock array
                IpFile.Close();
                TempSoldStock = SoldStock;

            }
            catch(Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        

        private void BagelSizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When an Index is selected on list box it calles the generate price method
                    GeneratePrice();
                

        }

        private void GeneratePrice()
        {

            if (BagelNameListBox.SelectedIndex != -1 && BagelSizeListBox.SelectedIndex != -1)
            {//Below block is executed only if both type and size are selected

              
                    BagelNameIndex = BagelNameListBox.SelectedIndex;
                    BagelSizeIndex = BagelSizeListBox.SelectedIndex;

                    Quantity = (int)(QuantityInput.Value);

                    //Calculate price by quantity
                    Price = (PricesArray[BagelNameIndex, BagelSizeIndex] * Quantity);

                    //display price to text box
                    PriceTextBox.Text = Price.ToString("C2");               
            }
        }

        private void BagelNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GeneratePrice();//method called on index selection
        }



        private void QuantityInput_ValueChanged(object sender, EventArgs e)
        {
            GeneratePrice();//method called on quantiy value change
            
        }


        public void UpdateStock()//method executed at the end of day on closing application
        {
            try
            {
                OpFile = File.CreateText(STOCK_FILE);

                for (int i = 0; i <= NumberOfBagels - 1; i++)//13
                {
                    for (int j = 0; j <= NumberOfSizes - 1; j++)//5
                    {

                        if (j == NumberOfSizes - 1)
                        {
                            OpFile.Write(StockArray[i, j]);

                        }
                        else
                        {
                            OpFile.Write(StockArray[i, j] + ",");
                        }
                    }
                    OpFile.WriteLine();

                }
                OpFile.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private int RandomNumberGenerator()//Generate random number
        {
            int RandNum;
            Random Rand = new Random();
            do
            {
                RandNum = Rand.Next(1000, 9999);

            } while (CheckIfTransactionNumberExists(RandNum));//calls method to check if txn number already exists
            return RandNum;
        }


        private bool CheckIfTransactionNumberExists(int Number)//method to check if txn number exists in file
        {
            bool value = false;

            IpFile = File.OpenText(TXN_FILE);
            while (!IpFile.EndOfStream)
            {
                if (Number.ToString() == IpFile.ReadLine())
                {
                    value = true;
                }
            }
            IpFile.Close();
            return value;
        }



        //On clearing, temp stock gets original values assigned from stock array
        private void ClearButton_Click(object sender, EventArgs e)
        {
            TmpStock = StockArray;
            OrderSummaryDataGrid.Rows.Clear();//clear grid rows
            ClearAll();

        }

        //clear method to set all values to null and 0
        public void ClearAll()
        {
            QuantityInput.Value = 1;
            PriceTextBox.Text = String.Empty;
            OrderSummaryDataGrid.Rows.Clear();
            TxnOrderSummary = "";
            ConfirmationOrderSummary = "";
            TotalPriceTextBox.Text = String.Empty;
            TotalPrice = 0m;
            Price = 0m;
            OrderSumDisplayLine = "";
            TxnOrderSummary = "";
            ConfirmationOrderSummary = "";
            CompleteButton.Enabled = false;
            Quantity = 0;
            this.OrderSummaryDataGrid.Rows.Clear();
        }
        //Calculations for summary report
        public void SummaryCalculation()
        {
            NoOfTransactions++;
            TotalQuantity += TmpQty;
            TotalSalesValue += TotalPrice;
            AvgValue = TotalSalesValue / NoOfTransactions;
        }


        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //class object is initialized 
            SummaryForm SummaryFormObj = new SummaryForm();
            //object calls method and passes parameters to different class method
            SummaryFormObj.SummaryDisplay(TotalQuantity, TotalSalesValue, NoOfTransactions, AvgValue);
            //display summary data
            SummaryFormObj.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            UpdateStock();//write latest stock data to file at end of day
            this.Close();//close application
        }

        //Write latest stock information from temp stock to file
        private void StockReportButton_Click(object sender, EventArgs e)
        {
            //this is a new string array where we will append the bagel names and sizes on the first row and column
            string[,] newArray = new string[NumberOfBagels + 1, NumberOfSizes + 1];

            
            for(int i=0;i<NumberOfBagels+1;i++)//14
            {
                for(int j=0;j<NumberOfSizes+1;j++)//6
                {
                    if (i == 0 && j == 0)
                    {
                        newArray[i, j] = " ";
                    }
                    else if (i == 0 && j != 0)
                    {
                        newArray[i, j] = BagelSizes[j-1];
                    }

                    else if (i != 0 && j == 0)
                    {
                        newArray[i, j] = BagelNames[i-1];
                    }
                    else
                    {
                        newArray[i, j] = TmpStock[i-1, j-1].ToString();//temp stock always holds the latest stock info
                    }
                }
            }
            try
            {//write new stock array to file
                OpFile = File.CreateText("StockReport.txt");
                OpFile.Write("Generated on: "+ DateTime.Now.ToString("dd-MM-yyyy")+"," + " Generation time:"+DateTime.Now.ToString("hh:mm:ss tt"));
                OpFile.WriteLine();
                OpFile.WriteLine();
                for (int i = 0; i < NumberOfBagels + 1; i++)
                {
                    for (int j = 0; j < NumberOfSizes; j++)
                    {
                        OpFile.Write(newArray[i, j] + "\t");
                    }
                    OpFile.WriteLine();
                }
                OpFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Stock report is generated. View the file in debug folder.", "Report generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Initialize search form object
            SearchForm SearchObj = new SearchForm();
            //Display form
            SearchObj.Show();           
        }

        private void SalesReport_Click(object sender, EventArgs e)
        {
            //Initialize sales report form object and pass parameters
            SalesReportForm Sales = new SalesReportForm();         
            Sales.Sales(SoldStock, NumberOfBagels,NumberOfSizes);
            Sales.Show();

        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            
            SummaryCalculation();//calls method to perform summary calculation and store values
            string OrderConfirmation = ConfirmationOrderSummary;


            StockArray = TmpStock;
            SoldStock = TempSoldStock;//update original array

            int TransactionNumber = RandomNumberGenerator();
            //initialize receipt form object and pass parameters to display
            ReceiptForm Receipt = new ReceiptForm();
            Receipt.ReceiptDisplay(TransactionNumber, OrderConfirmation, TotalPrice);
            //this line will display the form
            Receipt.Show();

            //write to transaction file
            try
            {
                OpFile = File.AppendText(TXN_FILE);
                OpFile.WriteLine(TransactionNumber + "," + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + TxnOrderSummary + "," + "Total Price: " + TotalPrice.ToString("C2"));
                OpFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ClearAll();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            //If stock is insufficient , display the available quantity and shift focus to quantity input for user to make changes
            if ((TmpStock[BagelNameIndex, BagelSizeIndex] - Quantity) <= 0)
            {
                MessageBox.Show("Available Quantity is: " + TmpStock[BagelNameIndex, BagelSizeIndex], "Insufficient stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QuantityInput.Focus();
            }

            else
            {   //button enabled only when order added to cart
                CompleteButton.Enabled = true;
                //Calculations
                TmpStock[BagelNameIndex, BagelSizeIndex] -= Quantity;
                TmpQty = Quantity;
                TotalPrice += Price;
                //Display to text box
                TotalPriceTextBox.Text = TotalPrice.ToString("C2");
                //update sold stock text box
                SoldStock[BagelNameIndex, BagelSizeIndex] += Quantity;

                //Strings are formatted to be written to transaction file and displayed in receipt
                OrderSumDisplayLine = BagelNames[BagelNameIndex] + " " + BagelSizes[BagelSizeIndex] + " " + Quantity.ToString() + " " + Price.ToString();
                TxnOrderSummary += "," + OrderSumDisplayLine;
                ConfirmationOrderSummary += BagelSizes[BagelSizeIndex] + " - " + BagelNames[BagelNameIndex] + " x " + Quantity.ToString() + " = " + Price.ToString("C2") + "\n";

                //Item Added to grid/table
                this.OrderSummaryDataGrid.Rows.Add(BagelNames[BagelNameIndex], BagelSizes[BagelSizeIndex], Quantity.ToString(), Price.ToString("C2"));


            }



        }
    }



}









