namespace StocksDestopApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTickerDetail = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.txtBxDate = new System.Windows.Forms.TextBox();
            this.txtBxSymbol = new System.Windows.Forms.TextBox();
            this.btnStockSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTickerDetail);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblSymbol);
            this.groupBox1.Controls.Add(this.txtBxDate);
            this.groupBox1.Controls.Add(this.txtBxSymbol);
            this.groupBox1.Controls.Add(this.btnStockSubmit);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnTickerDetail
            // 
            this.btnTickerDetail.Location = new System.Drawing.Point(105, 98);
            this.btnTickerDetail.Name = "btnTickerDetail";
            this.btnTickerDetail.Size = new System.Drawing.Size(95, 23);
            this.btnTickerDetail.TabIndex = 7;
            this.btnTickerDetail.Text = "Ticker Detail";
            this.btnTickerDetail.UseVisualStyleBackColor = true;
            this.btnTickerDetail.Click += new System.EventHandler(this.btnTickerDetail_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 64);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(6, 28);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(75, 13);
            this.lblSymbol.TabIndex = 5;
            this.lblSymbol.Text = "Stock Symbol:";
            // 
            // txtBxDate
            // 
            this.txtBxDate.Location = new System.Drawing.Point(94, 57);
            this.txtBxDate.Name = "txtBxDate";
            this.txtBxDate.Size = new System.Drawing.Size(100, 20);
            this.txtBxDate.TabIndex = 2;
            // 
            // txtBxSymbol
            // 
            this.txtBxSymbol.Location = new System.Drawing.Point(93, 21);
            this.txtBxSymbol.Name = "txtBxSymbol";
            this.txtBxSymbol.Size = new System.Drawing.Size(100, 20);
            this.txtBxSymbol.TabIndex = 1;
            // 
            // btnStockSubmit
            // 
            this.btnStockSubmit.Location = new System.Drawing.Point(0, 99);
            this.btnStockSubmit.Name = "btnStockSubmit";
            this.btnStockSubmit.Size = new System.Drawing.Size(99, 22);
            this.btnStockSubmit.TabIndex = 0;
            this.btnStockSubmit.Text = "Get Open/Close";
            this.btnStockSubmit.UseVisualStyleBackColor = true;
            this.btnStockSubmit.Click += new System.EventHandler(this.btnStockSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStockSubmit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox txtBxDate;
        private System.Windows.Forms.TextBox txtBxSymbol;
        private System.Windows.Forms.Button btnTickerDetail;
    }
}

