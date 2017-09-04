namespace MarshallsRevenueGUI
{
    partial class Form1
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
            this.lblNumExterior = new System.Windows.Forms.Label();
            this.lblNumInterior = new System.Windows.Forms.Label();
            this.txtNumExterior = new System.Windows.Forms.TextBox();
            this.txtNumInterior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRevenueInterior = new System.Windows.Forms.Label();
            this.lblRevenueExterior = new System.Windows.Forms.Label();
            this.lblNumDifference = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumExterior
            // 
            this.lblNumExterior.AutoSize = true;
            this.lblNumExterior.Location = new System.Drawing.Point(108, 53);
            this.lblNumExterior.Name = "lblNumExterior";
            this.lblNumExterior.Size = new System.Drawing.Size(27, 13);
            this.lblNumExterior.TabIndex = 6;
            this.lblNumExterior.Text = "@ $";
            // 
            // lblNumInterior
            // 
            this.lblNumInterior.AutoSize = true;
            this.lblNumInterior.Location = new System.Drawing.Point(108, 79);
            this.lblNumInterior.Name = "lblNumInterior";
            this.lblNumInterior.Size = new System.Drawing.Size(27, 13);
            this.lblNumInterior.TabIndex = 9;
            this.lblNumInterior.Text = "@ $";
            // 
            // txtNumExterior
            // 
            this.txtNumExterior.Location = new System.Drawing.Point(63, 50);
            this.txtNumExterior.MaxLength = 2;
            this.txtNumExterior.Name = "txtNumExterior";
            this.txtNumExterior.Size = new System.Drawing.Size(39, 20);
            this.txtNumExterior.TabIndex = 3;
            this.txtNumExterior.Text = "0";
            this.txtNumExterior.TextChanged += new System.EventHandler(this.txtNumExterior_TextChanged);
            // 
            // txtNumInterior
            // 
            this.txtNumInterior.Location = new System.Drawing.Point(63, 76);
            this.txtNumInterior.MaxLength = 2;
            this.txtNumInterior.Name = "txtNumInterior";
            this.txtNumInterior.Size = new System.Drawing.Size(39, 20);
            this.txtNumInterior.TabIndex = 5;
            this.txtNumInterior.Text = "0";
            this.txtNumInterior.TextChanged += new System.EventHandler(this.txtNumInterior_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interior:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exterior:";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Location = new System.Drawing.Point(229, 111);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(28, 13);
            this.lblTotalRevenue.TabIndex = 13;
            this.lblTotalRevenue.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total:  $";
            // 
            // lblRevenueInterior
            // 
            this.lblRevenueInterior.AutoSize = true;
            this.lblRevenueInterior.Location = new System.Drawing.Point(229, 79);
            this.lblRevenueInterior.Name = "lblRevenueInterior";
            this.lblRevenueInterior.Size = new System.Drawing.Size(28, 13);
            this.lblRevenueInterior.TabIndex = 11;
            this.lblRevenueInterior.Text = "0.00";
            // 
            // lblRevenueExterior
            // 
            this.lblRevenueExterior.AutoSize = true;
            this.lblRevenueExterior.Location = new System.Drawing.Point(229, 53);
            this.lblRevenueExterior.Name = "lblRevenueExterior";
            this.lblRevenueExterior.Size = new System.Drawing.Size(28, 13);
            this.lblRevenueExterior.TabIndex = 8;
            this.lblRevenueExterior.Text = "0.00";
            // 
            // lblNumDifference
            // 
            this.lblNumDifference.AutoSize = true;
            this.lblNumDifference.Location = new System.Drawing.Point(12, 141);
            this.lblNumDifference.Name = "lblNumDifference";
            this.lblNumDifference.Size = new System.Drawing.Size(186, 13);
            this.lblNumDifference.TabIndex = 14;
            this.lblNumDifference.Text = "There are n more interior than exterior.";
            this.lblNumDifference.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Month:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(63, 24);
            this.txtMonth.MaxLength = 2;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(39, 20);
            this.txtMonth.TabIndex = 1;
            this.txtMonth.Text = "0";
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 174);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumDifference);
            this.Controls.Add(this.lblRevenueInterior);
            this.Controls.Add(this.lblRevenueExterior);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumInterior);
            this.Controls.Add(this.txtNumExterior);
            this.Controls.Add(this.lblNumInterior);
            this.Controls.Add(this.lblNumExterior);
            this.Name = "Form1";
            this.Text = "Marshall\'s Murals Revenue v2.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumExterior;
        private System.Windows.Forms.Label lblNumInterior;
        private System.Windows.Forms.TextBox txtNumExterior;
        private System.Windows.Forms.TextBox txtNumInterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRevenueInterior;
        private System.Windows.Forms.Label lblRevenueExterior;
        private System.Windows.Forms.Label lblNumDifference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonth;
    }
}

