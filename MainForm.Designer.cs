namespace BagelShopBySamreen
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BagelNameListBox = new System.Windows.Forms.ListBox();
            this.BagelSizeListBox = new System.Windows.Forms.ListBox();
            this.QuantityInput = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.OrderSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalPriceTextBox = new System.Windows.Forms.Label();
            this.OrderSummaryDataGrid = new System.Windows.Forms.DataGridView();
            this.BageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.CreateOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceTextBox = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.BagelTypeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesReport = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StockReportButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).BeginInit();
            this.OrderSummaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSummaryDataGrid)).BeginInit();
            this.CreateOrderGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BagelShopBySamreen.Properties.Resources.MyBagelShopMedium;
            this.pictureBox1.Location = new System.Drawing.Point(333, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BagelNameListBox
            // 
            this.BagelNameListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.BagelNameListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BagelNameListBox.FormattingEnabled = true;
            this.BagelNameListBox.ItemHeight = 20;
            this.BagelNameListBox.Location = new System.Drawing.Point(15, 71);
            this.BagelNameListBox.Name = "BagelNameListBox";
            this.BagelNameListBox.Size = new System.Drawing.Size(148, 284);
            this.BagelNameListBox.TabIndex = 2;
            this.BagelNameListBox.SelectedIndexChanged += new System.EventHandler(this.BagelNameListBox_SelectedIndexChanged);
            // 
            // BagelSizeListBox
            // 
            this.BagelSizeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.BagelSizeListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BagelSizeListBox.FormattingEnabled = true;
            this.BagelSizeListBox.ItemHeight = 20;
            this.BagelSizeListBox.Location = new System.Drawing.Point(179, 71);
            this.BagelSizeListBox.Name = "BagelSizeListBox";
            this.BagelSizeListBox.Size = new System.Drawing.Size(142, 144);
            this.BagelSizeListBox.TabIndex = 2;
            this.BagelSizeListBox.SelectedIndexChanged += new System.EventHandler(this.BagelSizeListBox_SelectedIndexChanged);
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(263, 231);
            this.QuantityInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(58, 27);
            this.QuantityInput.TabIndex = 3;
            this.QuantityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityInput.ValueChanged += new System.EventHandler(this.QuantityInput_ValueChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(179, 314);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(137, 42);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "&Add to order";
            this.toolTip1.SetToolTip(this.AddButton, "Click to add order to cart");
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OrderSummaryGroupBox
            // 
            this.OrderSummaryGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.OrderSummaryGroupBox.Controls.Add(this.TotalPriceTextBox);
            this.OrderSummaryGroupBox.Controls.Add(this.OrderSummaryDataGrid);
            this.OrderSummaryGroupBox.Controls.Add(this.TotalPriceLabel);
            this.OrderSummaryGroupBox.Controls.Add(this.ClearButton);
            this.OrderSummaryGroupBox.Controls.Add(this.CompleteButton);
            this.OrderSummaryGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderSummaryGroupBox.Location = new System.Drawing.Point(370, 169);
            this.OrderSummaryGroupBox.Name = "OrderSummaryGroupBox";
            this.OrderSummaryGroupBox.Size = new System.Drawing.Size(567, 379);
            this.OrderSummaryGroupBox.TabIndex = 9;
            this.OrderSummaryGroupBox.TabStop = false;
            this.OrderSummaryGroupBox.Text = "Order Summary";
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalPriceTextBox.Location = new System.Drawing.Point(463, 318);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(88, 34);
            this.TotalPriceTextBox.TabIndex = 13;
            this.TotalPriceTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderSummaryDataGrid
            // 
            this.OrderSummaryDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderSummaryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderSummaryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderSummaryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BageType,
            this.Size,
            this.QuantityA,
            this.PriceA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderSummaryDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrderSummaryDataGrid.Location = new System.Drawing.Point(6, 35);
            this.OrderSummaryDataGrid.Name = "OrderSummaryDataGrid";
            this.OrderSummaryDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderSummaryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.OrderSummaryDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.OrderSummaryDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderSummaryDataGrid.RowTemplate.Height = 29;
            this.OrderSummaryDataGrid.Size = new System.Drawing.Size(555, 267);
            this.OrderSummaryDataGrid.TabIndex = 10;
            // 
            // BageType
            // 
            this.BageType.HeaderText = "Bagel Type";
            this.BageType.MinimumWidth = 6;
            this.BageType.Name = "BageType";
            this.BageType.ReadOnly = true;
            this.BageType.Width = 125;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 125;
            // 
            // QuantityA
            // 
            this.QuantityA.HeaderText = "Quantity";
            this.QuantityA.MinimumWidth = 6;
            this.QuantityA.Name = "QuantityA";
            this.QuantityA.ReadOnly = true;
            this.QuantityA.Width = 125;
            // 
            // PriceA
            // 
            this.PriceA.HeaderText = "Price";
            this.PriceA.MinimumWidth = 6;
            this.PriceA.Name = "PriceA";
            this.PriceA.ReadOnly = true;
            this.PriceA.Width = 125;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.TotalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceLabel.Location = new System.Drawing.Point(336, 318);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(121, 34);
            this.TotalPriceLabel.TabIndex = 13;
            this.TotalPriceLabel.Text = "Total Price:";
            this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(6, 314);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(141, 42);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.ClearButton, "Click to clear selections");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CompleteButton
            // 
            this.CompleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.CompleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompleteButton.Location = new System.Drawing.Point(163, 314);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(154, 42);
            this.CompleteButton.TabIndex = 10;
            this.CompleteButton.Text = "&Complete Order";
            this.CompleteButton.UseVisualStyleBackColor = false;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // CreateOrderGroupBox
            // 
            this.CreateOrderGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.CreateOrderGroupBox.Controls.Add(this.PriceTextBox);
            this.CreateOrderGroupBox.Controls.Add(this.QuantityLabel);
            this.CreateOrderGroupBox.Controls.Add(this.label1);
            this.CreateOrderGroupBox.Controls.Add(this.SizeLabel);
            this.CreateOrderGroupBox.Controls.Add(this.BagelTypeLabel);
            this.CreateOrderGroupBox.Controls.Add(this.BagelNameListBox);
            this.CreateOrderGroupBox.Controls.Add(this.BagelSizeListBox);
            this.CreateOrderGroupBox.Controls.Add(this.QuantityInput);
            this.CreateOrderGroupBox.Controls.Add(this.AddButton);
            this.CreateOrderGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateOrderGroupBox.Location = new System.Drawing.Point(12, 169);
            this.CreateOrderGroupBox.Name = "CreateOrderGroupBox";
            this.CreateOrderGroupBox.Size = new System.Drawing.Size(336, 379);
            this.CreateOrderGroupBox.TabIndex = 11;
            this.CreateOrderGroupBox.TabStop = false;
            this.CreateOrderGroupBox.Text = "Create your order";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PriceTextBox.Location = new System.Drawing.Point(261, 275);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(60, 27);
            this.PriceTextBox.TabIndex = 13;
            this.PriceTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.QuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuantityLabel.Location = new System.Drawing.Point(179, 231);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(78, 30);
            this.QuantityLabel.TabIndex = 13;
            this.QuantityLabel.Text = "Quantity";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeLabel
            // 
            this.SizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.SizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SizeLabel.Location = new System.Drawing.Point(177, 35);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(144, 30);
            this.SizeLabel.TabIndex = 13;
            this.SizeLabel.Text = "Size";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BagelTypeLabel
            // 
            this.BagelTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.BagelTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BagelTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BagelTypeLabel.Location = new System.Drawing.Point(15, 35);
            this.BagelTypeLabel.Name = "BagelTypeLabel";
            this.BagelTypeLabel.Size = new System.Drawing.Size(148, 30);
            this.BagelTypeLabel.TabIndex = 13;
            this.BagelTypeLabel.Text = "Bagel Type";
            this.BagelTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.SalesReport);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.StockReportButton);
            this.panel1.Controls.Add(this.SummaryButton);
            this.panel1.Location = new System.Drawing.Point(12, 580);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 111);
            this.panel1.TabIndex = 12;
            // 
            // SalesReport
            // 
            this.SalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.SalesReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalesReport.Location = new System.Drawing.Point(628, 14);
            this.SalesReport.Name = "SalesReport";
            this.SalesReport.Size = new System.Drawing.Size(133, 37);
            this.SalesReport.TabIndex = 1;
            this.SalesReport.Text = "&Sales Report";
            this.toolTip1.SetToolTip(this.SalesReport, "Click to view sales report");
            this.SalesReport.UseVisualStyleBackColor = false;
            this.SalesReport.Click += new System.EventHandler(this.SalesReport_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(177, 14);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(133, 37);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "&Search";
            this.toolTip1.SetToolTip(this.SearchButton, "Click to search order history");
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(395, 61);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(133, 37);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "&Close";
            this.toolTip1.SetToolTip(this.CloseButton, "Click to exit application");
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StockReportButton
            // 
            this.StockReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.StockReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StockReportButton.Location = new System.Drawing.Point(477, 14);
            this.StockReportButton.Name = "StockReportButton";
            this.StockReportButton.Size = new System.Drawing.Size(133, 37);
            this.StockReportButton.TabIndex = 0;
            this.StockReportButton.Text = "&Stock Report";
            this.toolTip1.SetToolTip(this.StockReportButton, "Click to view remaining stock");
            this.StockReportButton.UseVisualStyleBackColor = false;
            this.StockReportButton.Click += new System.EventHandler(this.StockReportButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryButton.Location = new System.Drawing.Point(324, 14);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(133, 37);
            this.SummaryButton.TabIndex = 0;
            this.SummaryButton.Text = "&Summary";
            this.toolTip1.SetToolTip(this.SummaryButton, "Click to view Company Summary ");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(956, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreateOrderGroupBox);
            this.Controls.Add(this.OrderSummaryGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MyBagelShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).EndInit();
            this.OrderSummaryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderSummaryDataGrid)).EndInit();
            this.CreateOrderGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox BagelNameListBox;
        private ListBox BagelSizeListBox;
        private NumericUpDown QuantityInput;
        private Button AddButton;
        private GroupBox OrderSummaryGroupBox;
        private Button CompleteButton;
        private Button ClearButton;
        private DataGridView OrderSummaryDataGrid;
        private DataGridViewTextBoxColumn BageType;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn QuantityA;
        private DataGridViewTextBoxColumn PriceA;
        private GroupBox CreateOrderGroupBox;
        private Panel panel1;
        private Button CloseButton;
        private Button StockReportButton;
        private Button SummaryButton;
        private Button SearchButton;
        private Label TotalPriceTextBox;
        internal Label TotalPriceLabel;
        internal Label QuantityLabel;
        internal Label SizeLabel;
        internal Label BagelTypeLabel;
        private Label PriceTextBox;
        internal Label label1;
        private Button SalesReport;
        private ToolTip toolTip1;
    }
}