namespace SP_Lab_4
{
    partial class AddNewLotOfToys
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameOfProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameOfCompanyProduct = new System.Windows.Forms.TextBox();
            this.NameLotOfParty = new System.Windows.Forms.NumericUpDown();
            this.CountLotOfToys = new System.Windows.Forms.NumericUpDown();
            this.ClassificationChoose = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NameLotOfParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountLotOfToys)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для создания партии заполните поля:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название партии:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество игрушек в партии:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дату изменить нельзя.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Название продукта:";
            // 
            // NameOfProduct
            // 
            this.NameOfProduct.Location = new System.Drawing.Point(169, 138);
            this.NameOfProduct.Name = "NameOfProduct";
            this.NameOfProduct.Size = new System.Drawing.Size(132, 22);
            this.NameOfProduct.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Название компании продукта:";
            // 
            // NameOfCompanyProduct
            // 
            this.NameOfCompanyProduct.Location = new System.Drawing.Point(226, 172);
            this.NameOfCompanyProduct.Name = "NameOfCompanyProduct";
            this.NameOfCompanyProduct.Size = new System.Drawing.Size(75, 22);
            this.NameOfCompanyProduct.TabIndex = 9;
            // 
            // NameLotOfParty
            // 
            this.NameLotOfParty.Location = new System.Drawing.Point(144, 38);
            this.NameLotOfParty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NameLotOfParty.Name = "NameLotOfParty";
            this.NameLotOfParty.Size = new System.Drawing.Size(157, 22);
            this.NameLotOfParty.TabIndex = 11;
            // 
            // CountLotOfToys
            // 
            this.CountLotOfToys.Location = new System.Drawing.Point(226, 72);
            this.CountLotOfToys.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CountLotOfToys.Name = "CountLotOfToys";
            this.CountLotOfToys.Size = new System.Drawing.Size(75, 22);
            this.CountLotOfToys.TabIndex = 12;
            // 
            // ClassificationChoose
            // 
            this.ClassificationChoose.FormattingEnabled = true;
            this.ClassificationChoose.Items.AddRange(new object[] {
            "None",
            "SoftToy",
            "Toy",
            "Doll",
            "TechniqueModel",
            "Constructor"});
            this.ClassificationChoose.Location = new System.Drawing.Point(144, 208);
            this.ClassificationChoose.Name = "ClassificationChoose";
            this.ClassificationChoose.Size = new System.Drawing.Size(157, 24);
            this.ClassificationChoose.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Классификация:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(226, 250);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 31);
            this.submit.TabIndex = 15;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // AddNewLotOfToys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(310, 299);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClassificationChoose);
            this.Controls.Add(this.CountLotOfToys);
            this.Controls.Add(this.NameLotOfParty);
            this.Controls.Add(this.NameOfCompanyProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameOfProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewLotOfToys";
            this.Text = "AddNewLotOfToys";
            this.Load += new System.EventHandler(this.AddNewLotOfToys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NameLotOfParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountLotOfToys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameOfProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameOfCompanyProduct;
        private System.Windows.Forms.NumericUpDown NameLotOfParty;
        private System.Windows.Forms.NumericUpDown CountLotOfToys;
        private System.Windows.Forms.ComboBox ClassificationChoose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button submit;
    }
}