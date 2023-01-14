namespace BagelShopBySamreen
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchOutputLabel = new System.Windows.Forms.Label();
            this.TxnNumIpTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ClearButton = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchTextBOX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BagelShopBySamreen.Properties.Resources.MyBagelShopMedium;
            this.pictureBox1.Location = new System.Drawing.Point(101, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SearchLabel
            // 
            this.SearchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.SearchLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.Location = new System.Drawing.Point(11, 125);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(202, 25);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search By Transaction ID:";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchOutputLabel
            // 
            this.SearchOutputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.SearchOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchOutputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchOutputLabel.Location = new System.Drawing.Point(12, 267);
            this.SearchOutputLabel.Name = "SearchOutputLabel";
            this.SearchOutputLabel.Size = new System.Drawing.Size(365, 216);
            this.SearchOutputLabel.TabIndex = 1;
            // 
            // TxnNumIpTextBox
            // 
            this.TxnNumIpTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxnNumIpTextBox.Location = new System.Drawing.Point(219, 125);
            this.TxnNumIpTextBox.Name = "TxnNumIpTextBox";
            this.TxnNumIpTextBox.Size = new System.Drawing.Size(155, 27);
            this.TxnNumIpTextBox.TabIndex = 2;
            this.TxnNumIpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(237, 219);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(107, 36);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "&Search";
            this.toolTip1.SetToolTip(this.SearchButton, "Click to Search Orders");
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(237, 487);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(107, 36);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "&Close";
            this.toolTip1.SetToolTip(this.CloseButton, "Click to close search window");
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(128, 487);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 36);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.ClearButton, "Click to clear information");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(215, 176);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(159, 27);
            this.DatePicker.TabIndex = 5;
            // 
            // SearchTextBOX
            // 
            this.SearchTextBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.SearchTextBOX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchTextBOX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBOX.Location = new System.Drawing.Point(11, 176);
            this.SearchTextBOX.Name = "SearchTextBOX";
            this.SearchTextBOX.Size = new System.Drawing.Size(202, 25);
            this.SearchTextBOX.TabIndex = 1;
            this.SearchTextBOX.Text = "Search By Date:";
            this.SearchTextBOX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(389, 536);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TxnNumIpTextBox);
            this.Controls.Add(this.SearchOutputLabel);
            this.Controls.Add(this.SearchTextBOX);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "Search orders";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label SearchLabel;
        private Label SearchOutputLabel;
        private TextBox TxnNumIpTextBox;
        private Button SearchButton;
        private Button CloseButton;
        private ToolTip toolTip1;
        private DateTimePicker DatePicker;
        private Label SearchTextBOX;
        private Button ClearButton;
    }
}