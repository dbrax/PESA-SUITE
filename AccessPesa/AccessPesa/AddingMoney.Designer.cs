namespace AccessPesa
{
    partial class AddingMoney
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
            this.floatlabel = new System.Windows.Forms.Label();
            this.hela = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.Changetext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // floatlabel
            // 
            this.floatlabel.AutoSize = true;
            this.floatlabel.BackColor = System.Drawing.Color.Transparent;
            this.floatlabel.Font = new System.Drawing.Font("Andalus", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floatlabel.ForeColor = System.Drawing.Color.White;
            this.floatlabel.Location = new System.Drawing.Point(15, 7);
            this.floatlabel.Name = "floatlabel";
            this.floatlabel.Size = new System.Drawing.Size(86, 41);
            this.floatlabel.TabIndex = 0;
            this.floatlabel.Text = "label1";
            // 
            // hela
            // 
            this.hela.AutoSize = true;
            this.hela.BackColor = System.Drawing.Color.Transparent;
            this.hela.Font = new System.Drawing.Font("Andalus", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hela.ForeColor = System.Drawing.Color.White;
            this.hela.Location = new System.Drawing.Point(59, 48);
            this.hela.Name = "hela";
            this.hela.Size = new System.Drawing.Size(42, 41);
            this.hela.TabIndex = 1;
            this.hela.Text = "$$";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(375, 54);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(135, 20);
            this.input.TabIndex = 2;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(508, 99);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(427, 99);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(346, 99);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 5;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // Changetext
            // 
            this.Changetext.Location = new System.Drawing.Point(145, 54);
            this.Changetext.Name = "Changetext";
            this.Changetext.Size = new System.Drawing.Size(200, 20);
            this.Changetext.TabIndex = 6;
            // 
            // AddingMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(604, 134);
            this.ControlBox = false;
            this.Controls.Add(this.Changetext);
            this.Controls.Add(this.change);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add);
            this.Controls.Add(this.input);
            this.Controls.Add(this.hela);
            this.Controls.Add(this.floatlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddingMoney";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Change Money";
            this.Load += new System.EventHandler(this.AddingFloat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label floatlabel;
        private System.Windows.Forms.Label hela;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox Changetext;
    }
}