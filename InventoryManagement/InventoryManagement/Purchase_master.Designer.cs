namespace InventoryManagement
{
    partial class Purchase_master
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxProdName = new System.Windows.Forms.ComboBox();
            this.textBoxPq = new System.Windows.Forms.TextBox();
            this.textBoxPp = new System.Windows.Forms.TextBox();
            this.textBoxPt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDn = new System.Windows.Forms.ComboBox();
            this.comboBoxPuT = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxProfit = new System.Windows.Forms.TextBox();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Quantity : ";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(254, 99);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(33, 17);
            this.labelUnit.TabIndex = 2;
            this.labelUnit.Text = "Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Price : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Purchase Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dealer Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Purchase Type : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Expiry Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Profit% :";
            // 
            // comboBoxProdName
            // 
            this.comboBoxProdName.FormattingEnabled = true;
            this.comboBoxProdName.Location = new System.Drawing.Point(133, 40);
            this.comboBoxProdName.Name = "comboBoxProdName";
            this.comboBoxProdName.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProdName.TabIndex = 10;
            this.comboBoxProdName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProdName_SelectedIndexChanged);
            // 
            // textBoxPq
            // 
            this.textBoxPq.Location = new System.Drawing.Point(148, 96);
            this.textBoxPq.Name = "textBoxPq";
            this.textBoxPq.Size = new System.Drawing.Size(100, 23);
            this.textBoxPq.TabIndex = 11;
            // 
            // textBoxPp
            // 
            this.textBoxPp.Location = new System.Drawing.Point(133, 153);
            this.textBoxPp.Name = "textBoxPp";
            this.textBoxPp.Size = new System.Drawing.Size(100, 23);
            this.textBoxPp.TabIndex = 12;
            this.textBoxPp.Leave += new System.EventHandler(this.textBoxPp_Leave);
            // 
            // textBoxPt
            // 
            this.textBoxPt.Location = new System.Drawing.Point(133, 204);
            this.textBoxPt.Name = "textBoxPt";
            this.textBoxPt.Size = new System.Drawing.Size(100, 23);
            this.textBoxPt.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // comboBoxDn
            // 
            this.comboBoxDn.FormattingEnabled = true;
            this.comboBoxDn.Location = new System.Drawing.Point(133, 311);
            this.comboBoxDn.Name = "comboBoxDn";
            this.comboBoxDn.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDn.TabIndex = 15;
            // 
            // comboBoxPuT
            // 
            this.comboBoxPuT.FormattingEnabled = true;
            this.comboBoxPuT.Items.AddRange(new object[] {
            "Cash",
            "Debit"});
            this.comboBoxPuT.Location = new System.Drawing.Point(133, 367);
            this.comboBoxPuT.Name = "comboBoxPuT";
            this.comboBoxPuT.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPuT.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(133, 420);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // textBoxProfit
            // 
            this.textBoxProfit.Location = new System.Drawing.Point(133, 474);
            this.textBoxProfit.Name = "textBoxProfit";
            this.textBoxProfit.Size = new System.Drawing.Size(100, 23);
            this.textBoxProfit.TabIndex = 18;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(379, 514);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(98, 28);
            this.buttonPurchase.TabIndex = 19;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // Purchase_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 554);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.textBoxProfit);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBoxPuT);
            this.Controls.Add(this.comboBoxDn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPt);
            this.Controls.Add(this.textBoxPp);
            this.Controls.Add(this.textBoxPq);
            this.Controls.Add(this.comboBoxProdName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Purchase_master";
            this.Text = "Purchase_master";
            this.Load += new System.EventHandler(this.Purchase_master_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxProdName;
        private System.Windows.Forms.TextBox textBoxPq;
        private System.Windows.Forms.TextBox textBoxPp;
        private System.Windows.Forms.TextBox textBoxPt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxDn;
        private System.Windows.Forms.ComboBox comboBoxPuT;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBoxProfit;
        private System.Windows.Forms.Button buttonPurchase;
    }
}