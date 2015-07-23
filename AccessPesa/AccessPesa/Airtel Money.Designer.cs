namespace AccessPesa
{
    partial class Airtel_Money
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Airtel_Money));
            this.NewEntry = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.Airteltxt = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.Button();
            this.AirtelListView = new System.Windows.Forms.ListView();
            this.SN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CASHBALANCE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FLOATBALANCE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TRANSACTION_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TRANSACTION_TYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TRANSACTION_VALUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CUSTOMER_NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CUSTOMER_CELLPHONE_NO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CUSTOMER_ID_TYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CUSTOMER_ID_NUMBER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AirtelPic = new System.Windows.Forms.PictureBox();
            this.addfloatairtel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirtelPic)).BeginInit();
            this.SuspendLayout();
            // 
            // NewEntry
            // 
            this.NewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewEntry.ForeColor = System.Drawing.Color.White;
            this.NewEntry.Location = new System.Drawing.Point(845, 16);
            this.NewEntry.Name = "NewEntry";
            this.NewEntry.Size = new System.Drawing.Size(106, 35);
            this.NewEntry.TabIndex = 11;
            this.NewEntry.Text = "New Entry";
            this.NewEntry.UseVisualStyleBackColor = true;
            this.NewEntry.Click += new System.EventHandler(this.NewEntry_Click);
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(671, 19);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 31);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Airteltxt
            // 
            this.Airteltxt.AutoSize = true;
            this.Airteltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airteltxt.ForeColor = System.Drawing.Color.White;
            this.Airteltxt.Location = new System.Drawing.Point(66, 24);
            this.Airteltxt.Name = "Airteltxt";
            this.Airteltxt.Size = new System.Drawing.Size(191, 29);
            this.Airteltxt.TabIndex = 14;
            this.Airteltxt.Text = "AIRTEL MONEY";
            // 
            // report
            // 
            this.report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report.ForeColor = System.Drawing.Color.White;
            this.report.Location = new System.Drawing.Point(1087, 18);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(94, 31);
            this.report.TabIndex = 15;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.button1_Click);
            // 
            // AirtelListView
            // 
            this.AirtelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SN,
            this.DATE,
            this.CASHBALANCE,
            this.FLOATBALANCE,
            this.TRANSACTION_ID,
            this.TRANSACTION_TYPE,
            this.TRANSACTION_VALUE,
            this.CUSTOMER_NAME,
            this.CUSTOMER_CELLPHONE_NO,
            this.CUSTOMER_ID_TYPE,
            this.CUSTOMER_ID_NUMBER});
            this.AirtelListView.FullRowSelect = true;
            this.AirtelListView.GridLines = true;
            this.AirtelListView.Location = new System.Drawing.Point(21, 64);
            this.AirtelListView.Name = "AirtelListView";
            this.AirtelListView.Size = new System.Drawing.Size(1207, 533);
            this.AirtelListView.TabIndex = 22;
            this.AirtelListView.UseCompatibleStateImageBehavior = false;
            this.AirtelListView.View = System.Windows.Forms.View.Details;
            // 
            // SN
            // 
            this.SN.Text = "SN";
            this.SN.Width = 30;
            // 
            // DATE
            // 
            this.DATE.Text = "DATE";
            this.DATE.Width = 87;
            // 
            // CASHBALANCE
            // 
            this.CASHBALANCE.Text = "CASH BALANCE";
            this.CASHBALANCE.Width = 98;
            // 
            // FLOATBALANCE
            // 
            this.FLOATBALANCE.Text = "FLOAT BALANCE";
            this.FLOATBALANCE.Width = 98;
            // 
            // TRANSACTION_ID
            // 
            this.TRANSACTION_ID.Text = "TRANSACTION ID";
            this.TRANSACTION_ID.Width = 112;
            // 
            // TRANSACTION_TYPE
            // 
            this.TRANSACTION_TYPE.Text = "TRANSACTION TYPE";
            this.TRANSACTION_TYPE.Width = 122;
            // 
            // TRANSACTION_VALUE
            // 
            this.TRANSACTION_VALUE.Text = "TRANSACTION VALUE";
            this.TRANSACTION_VALUE.Width = 129;
            // 
            // CUSTOMER_NAME
            // 
            this.CUSTOMER_NAME.Text = "CUSTOMER NAME";
            this.CUSTOMER_NAME.Width = 119;
            // 
            // CUSTOMER_CELLPHONE_NO
            // 
            this.CUSTOMER_CELLPHONE_NO.Text = "CUSTOMER CELLPHONE NO.";
            this.CUSTOMER_CELLPHONE_NO.Width = 162;
            // 
            // CUSTOMER_ID_TYPE
            // 
            this.CUSTOMER_ID_TYPE.Text = "CUSTOMER ID TYPE";
            this.CUSTOMER_ID_TYPE.Width = 119;
            // 
            // CUSTOMER_ID_NUMBER
            // 
            this.CUSTOMER_ID_NUMBER.Text = "CUSTOMER ID NUMBER";
            this.CUSTOMER_ID_NUMBER.Width = 137;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AccessPesa.Properties.Resources.bck2;
            this.pictureBox1.Location = new System.Drawing.Point(789, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AirtelPic
            // 
            this.AirtelPic.Image = global::AccessPesa.Properties.Resources.AirtelMoney;
            this.AirtelPic.Location = new System.Drawing.Point(12, 12);
            this.AirtelPic.Name = "AirtelPic";
            this.AirtelPic.Size = new System.Drawing.Size(48, 48);
            this.AirtelPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AirtelPic.TabIndex = 13;
            this.AirtelPic.TabStop = false;
            // 
            // addfloatairtel
            // 
            this.addfloatairtel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addfloatairtel.ForeColor = System.Drawing.Color.White;
            this.addfloatairtel.Location = new System.Drawing.Point(957, 17);
            this.addfloatairtel.Name = "addfloatairtel";
            this.addfloatairtel.Size = new System.Drawing.Size(127, 34);
            this.addfloatairtel.TabIndex = 28;
            this.addfloatairtel.Text = "Add FloatBalance";
            this.addfloatairtel.UseVisualStyleBackColor = true;
            this.addfloatairtel.Click += new System.EventHandler(this.addfloatairtel_Click);
            // 
            // Airtel_Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1244, 642);
            this.Controls.Add(this.addfloatairtel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AirtelListView);
            this.Controls.Add(this.report);
            this.Controls.Add(this.Airteltxt);
            this.Controls.Add(this.AirtelPic);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NewEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Airtel_Money";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airtel Money";
            this.Activated += new System.EventHandler(this.Airtel_Money_Activated);
            this.Load += new System.EventHandler(this.Airtel_Money_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirtelPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewEntry;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox AirtelPic;
        private System.Windows.Forms.Label Airteltxt;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.ListView AirtelListView;
        private System.Windows.Forms.ColumnHeader SN;
        private System.Windows.Forms.ColumnHeader DATE;
        private System.Windows.Forms.ColumnHeader CASHBALANCE;
        private System.Windows.Forms.ColumnHeader FLOATBALANCE;
        private System.Windows.Forms.ColumnHeader TRANSACTION_ID;
        private System.Windows.Forms.ColumnHeader TRANSACTION_TYPE;
        private System.Windows.Forms.ColumnHeader TRANSACTION_VALUE;
        private System.Windows.Forms.ColumnHeader CUSTOMER_NAME;
        private System.Windows.Forms.ColumnHeader CUSTOMER_CELLPHONE_NO;
        private System.Windows.Forms.ColumnHeader CUSTOMER_ID_TYPE;
        private System.Windows.Forms.ColumnHeader CUSTOMER_ID_NUMBER;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addfloatairtel;
    }
}