namespace AccessPesa
{
    partial class Ezy_Pesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ezy_Pesa));
            this.BackButton = new System.Windows.Forms.Button();
            this.EzyPesaLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewEntry = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.EzyPesaListView = new System.Windows.Forms.ListView();
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
            this.addfloatvoda = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(659, 16);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 31);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EzyPesaLabel
            // 
            this.EzyPesaLabel.AutoSize = true;
            this.EzyPesaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EzyPesaLabel.ForeColor = System.Drawing.Color.White;
            this.EzyPesaLabel.Location = new System.Drawing.Point(65, 23);
            this.EzyPesaLabel.Name = "EzyPesaLabel";
            this.EzyPesaLabel.Size = new System.Drawing.Size(128, 29);
            this.EzyPesaLabel.TabIndex = 15;
            this.EzyPesaLabel.Text = "EZY PESA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccessPesa.Properties.Resources.EzyPesa;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // NewEntry
            // 
            this.NewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewEntry.ForeColor = System.Drawing.Color.White;
            this.NewEntry.Location = new System.Drawing.Point(842, 16);
            this.NewEntry.Name = "NewEntry";
            this.NewEntry.Size = new System.Drawing.Size(106, 35);
            this.NewEntry.TabIndex = 12;
            this.NewEntry.Text = "New Entry";
            this.NewEntry.UseVisualStyleBackColor = true;
            this.NewEntry.Click += new System.EventHandler(this.NewEntry_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Location = new System.Drawing.Point(1087, 16);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(94, 34);
            this.ReportButton.TabIndex = 16;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // EzyPesaListView
            // 
            this.EzyPesaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.EzyPesaListView.FullRowSelect = true;
            this.EzyPesaListView.GridLines = true;
            this.EzyPesaListView.Location = new System.Drawing.Point(25, 66);
            this.EzyPesaListView.Name = "EzyPesaListView";
            this.EzyPesaListView.Size = new System.Drawing.Size(1207, 564);
            this.EzyPesaListView.TabIndex = 18;
            this.EzyPesaListView.UseCompatibleStateImageBehavior = false;
            this.EzyPesaListView.View = System.Windows.Forms.View.Details;
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
            // addfloatvoda
            // 
            this.addfloatvoda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addfloatvoda.ForeColor = System.Drawing.Color.White;
            this.addfloatvoda.Location = new System.Drawing.Point(954, 16);
            this.addfloatvoda.Name = "addfloatvoda";
            this.addfloatvoda.Size = new System.Drawing.Size(127, 34);
            this.addfloatvoda.TabIndex = 27;
            this.addfloatvoda.Text = "Add FloatBalance";
            this.addfloatvoda.UseVisualStyleBackColor = true;
            this.addfloatvoda.Click += new System.EventHandler(this.addfloatvoda_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::AccessPesa.Properties.Resources.bck2;
            this.pictureBox2.Location = new System.Drawing.Point(789, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Ezy_Pesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1244, 642);
            this.Controls.Add(this.addfloatvoda);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EzyPesaListView);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EzyPesaLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NewEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ezy_Pesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ezy Pesa";
            this.Activated += new System.EventHandler(this.Ezy_Pesa_Activated);
            this.Load += new System.EventHandler(this.Ezy_Pesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label EzyPesaLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NewEntry;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.ListView EzyPesaListView;
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
        private System.Windows.Forms.Button addfloatvoda;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}