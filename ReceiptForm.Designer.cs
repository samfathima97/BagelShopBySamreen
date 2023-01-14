namespace BagelShopBySamreen
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.OKButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.OrderNumTxtBox = new System.Windows.Forms.TextBox();
            this.OrderTextBox = new System.Windows.Forms.RichTextBox();
            this.DateTimeTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.TextBox();
            this.TotalPriceLabel = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.OKButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OKButton.Location = new System.Drawing.Point(101, 545);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 42);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "&OK";
            this.toolTip1.SetToolTip(this.OKButton, "Click to close receipt");
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BagelShopBySamreen.Properties.Resources.MyBagelShopMedium;
            this.pictureBox1.Location = new System.Drawing.Point(21, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderNumberTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderNumberTextBox.Location = new System.Drawing.Point(155, 137);
            this.OrderNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.ReadOnly = true;
            this.OrderNumberTextBox.Size = new System.Drawing.Size(87, 27);
            this.OrderNumberTextBox.TabIndex = 2;
            this.OrderNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderNumTxtBox
            // 
            this.OrderNumTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.OrderNumTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderNumTxtBox.Location = new System.Drawing.Point(65, 137);
            this.OrderNumTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderNumTxtBox.Name = "OrderNumTxtBox";
            this.OrderNumTxtBox.ReadOnly = true;
            this.OrderNumTxtBox.Size = new System.Drawing.Size(84, 27);
            this.OrderNumTxtBox.TabIndex = 2;
            this.OrderNumTxtBox.Text = "Order No";
            this.OrderNumTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderTextBox.Location = new System.Drawing.Point(21, 233);
            this.OrderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.ReadOnly = true;
            this.OrderTextBox.Size = new System.Drawing.Size(283, 232);
            this.OrderTextBox.TabIndex = 3;
            this.OrderTextBox.Text = "";
            // 
            // DateTimeTextBox
            // 
            this.DateTimeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.DateTimeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateTimeTextBox.Location = new System.Drawing.Point(21, 183);
            this.DateTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateTimeTextBox.Name = "DateTimeTextBox";
            this.DateTimeTextBox.ReadOnly = true;
            this.DateTimeTextBox.Size = new System.Drawing.Size(283, 27);
            this.DateTimeTextBox.TabIndex = 2;
            this.DateTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalLabel
            // 
            this.TotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalLabel.Location = new System.Drawing.Point(116, 484);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.ReadOnly = true;
            this.TotalLabel.Size = new System.Drawing.Size(84, 27);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total: ";
            this.TotalLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceLabel.Location = new System.Drawing.Point(217, 484);
            this.TotalPriceLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.ReadOnly = true;
            this.TotalPriceLabel.Size = new System.Drawing.Size(87, 27);
            this.TotalPriceLabel.TabIndex = 2;
            this.TotalPriceLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(324, 600);
            this.Controls.Add(this.OrderTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.OrderNumTxtBox);
            this.Controls.Add(this.DateTimeTextBox);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.OrderNumberTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OKButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReceiptForm";
            this.Text = "Order Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OKButton;
        private PictureBox pictureBox1;
        private TextBox OrderNumberTextBox;
        private TextBox OrderNumTxtBox;
        private RichTextBox OrderTextBox;
        private TextBox DateTimeTextBox;
        private TextBox TotalLabel;
        private TextBox TotalPriceLabel;
        private ToolTip toolTip1;
    }
}