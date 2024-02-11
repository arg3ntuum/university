namespace SP_Lab_5
{
    partial class UI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListMagazines = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListLotOfToys = new System.Windows.Forms.ListBox();
            this.CountMagazines = new System.Windows.Forms.Label();
            this.CountMagazines_number = new System.Windows.Forms.Label();
            this.MagazineInfoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.addMagazineButton = new System.Windows.Forms.Button();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.GetInfo = new System.Windows.Forms.Button();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.magazineOfToysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NamePartyLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateLotOfToys = new System.Windows.Forms.Button();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.YearNum = new System.Windows.Forms.NumericUpDown();
            this.DayNum = new System.Windows.Forms.NumericUpDown();
            this.MonthNum = new System.Windows.Forms.NumericUpDown();
            this.ClassificationComboBox = new System.Windows.Forms.ComboBox();
            this.ClassificationLabel = new System.Windows.Forms.Label();
            this.NameOfCompanyLabel = new System.Windows.Forms.Label();
            this.NameProductLabel = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.NameProductTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.CountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NameNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.magazineOfToysBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ListMagazines
            // 
            this.ListMagazines.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListMagazines.FormattingEnabled = true;
            this.ListMagazines.Location = new System.Drawing.Point(388, 36);
            this.ListMagazines.Margin = new System.Windows.Forms.Padding(2);
            this.ListMagazines.Name = "ListMagazines";
            this.ListMagazines.Size = new System.Drawing.Size(114, 46);
            this.ListMagazines.TabIndex = 0;
            this.ListMagazines.SelectedIndexChanged += new System.EventHandler(this.ListMagazines_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер отделения магазина";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListLotOfToys
            // 
            this.ListLotOfToys.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListLotOfToys.FormattingEnabled = true;
            this.ListLotOfToys.ItemHeight = 32;
            this.ListLotOfToys.Location = new System.Drawing.Point(9, 89);
            this.ListLotOfToys.Margin = new System.Windows.Forms.Padding(2);
            this.ListLotOfToys.Name = "ListLotOfToys";
            this.ListLotOfToys.Size = new System.Drawing.Size(149, 260);
            this.ListLotOfToys.TabIndex = 2;
            this.ListLotOfToys.SelectedIndexChanged += new System.EventHandler(this.ListLotOfToys_SelectedIndexChanged);
            // 
            // CountMagazines
            // 
            this.CountMagazines.AutoSize = true;
            this.CountMagazines.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountMagazines.Location = new System.Drawing.Point(9, 7);
            this.CountMagazines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountMagazines.Name = "CountMagazines";
            this.CountMagazines.Size = new System.Drawing.Size(345, 33);
            this.CountMagazines.TabIndex = 4;
            this.CountMagazines.Text = "Количество магазинов: ";
            // 
            // CountMagazines_number
            // 
            this.CountMagazines_number.AutoSize = true;
            this.CountMagazines_number.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountMagazines_number.Location = new System.Drawing.Point(338, 9);
            this.CountMagazines_number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountMagazines_number.Name = "CountMagazines_number";
            this.CountMagazines_number.Size = new System.Drawing.Size(30, 33);
            this.CountMagazines_number.TabIndex = 5;
            this.CountMagazines_number.Text = "0";
            // 
            // MagazineInfoButton
            // 
            this.MagazineInfoButton.Location = new System.Drawing.Point(452, 7);
            this.MagazineInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.MagazineInfoButton.Name = "MagazineInfoButton";
            this.MagazineInfoButton.Size = new System.Drawing.Size(50, 23);
            this.MagazineInfoButton.TabIndex = 6;
            this.MagazineInfoButton.Text = "Info";
            this.MagazineInfoButton.UseVisualStyleBackColor = true;
            this.MagazineInfoButton.Click += new System.EventHandler(this.MagazineInfoButton_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(112, 358);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 30);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addMagazineButton
            // 
            this.addMagazineButton.Location = new System.Drawing.Point(388, 7);
            this.addMagazineButton.Margin = new System.Windows.Forms.Padding(2);
            this.addMagazineButton.Name = "addMagazineButton";
            this.addMagazineButton.Size = new System.Drawing.Size(51, 23);
            this.addMagazineButton.TabIndex = 9;
            this.addMagazineButton.Text = "Add";
            this.addMagazineButton.UseVisualStyleBackColor = true;
            this.addMagazineButton.Click += new System.EventHandler(this.addMagazineButton_Click);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ColorPanel.Location = new System.Drawing.Point(161, 89);
            this.ColorPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(62, 263);
            this.ColorPanel.TabIndex = 10;
            // 
            // GetInfo
            // 
            this.GetInfo.Location = new System.Drawing.Point(4, 240);
            this.GetInfo.Margin = new System.Windows.Forms.Padding(2);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(62, 22);
            this.GetInfo.TabIndex = 0;
            this.GetInfo.Text = "GetInfo";
            this.GetInfo.UseVisualStyleBackColor = true;
            this.GetInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // SerializeButton
            // 
            this.SerializeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SerializeButton.Location = new System.Drawing.Point(225, 358);
            this.SerializeButton.Margin = new System.Windows.Forms.Padding(2);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(98, 30);
            this.SerializeButton.TabIndex = 11;
            this.SerializeButton.Text = "Serialize";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.Location = new System.Drawing.Point(328, 358);
            this.DeserializeButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(98, 30);
            this.DeserializeButton.TabIndex = 12;
            this.DeserializeButton.Text = "Deserealize";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // NamePartyLabel
            // 
            this.NamePartyLabel.AutoSize = true;
            this.NamePartyLabel.Location = new System.Drawing.Point(4, 18);
            this.NamePartyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NamePartyLabel.Name = "NamePartyLabel";
            this.NamePartyLabel.Size = new System.Drawing.Size(94, 15);
            this.NamePartyLabel.TabIndex = 14;
            this.NamePartyLabel.Text = "Name(партии):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpdateLotOfToys);
            this.groupBox1.Controls.Add(this.YearLabel);
            this.groupBox1.Controls.Add(this.MonthLabel);
            this.groupBox1.Controls.Add(this.DayLabel);
            this.groupBox1.Controls.Add(this.YearNum);
            this.groupBox1.Controls.Add(this.DayNum);
            this.groupBox1.Controls.Add(this.MonthNum);
            this.groupBox1.Controls.Add(this.ClassificationComboBox);
            this.groupBox1.Controls.Add(this.GetInfo);
            this.groupBox1.Controls.Add(this.ClassificationLabel);
            this.groupBox1.Controls.Add(this.NameOfCompanyLabel);
            this.groupBox1.Controls.Add(this.NameProductLabel);
            this.groupBox1.Controls.Add(this.CompanyNameTextBox);
            this.groupBox1.Controls.Add(this.NameProductTextBox);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.CountNumericUpDown);
            this.groupBox1.Controls.Add(this.NameNumericUpDown);
            this.groupBox1.Controls.Add(this.CountLabel);
            this.groupBox1.Controls.Add(this.NamePartyLabel);
            this.groupBox1.Location = new System.Drawing.Point(228, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(220, 266);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // UpdateLotOfToys
            // 
            this.UpdateLotOfToys.Location = new System.Drawing.Point(155, 240);
            this.UpdateLotOfToys.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateLotOfToys.Name = "UpdateLotOfToys";
            this.UpdateLotOfToys.Size = new System.Drawing.Size(61, 22);
            this.UpdateLotOfToys.TabIndex = 34;
            this.UpdateLotOfToys.Text = "Update";
            this.UpdateLotOfToys.UseVisualStyleBackColor = true;
            this.UpdateLotOfToys.Click += new System.EventHandler(this.UpdateLotOfToys_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(137, 93);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(35, 15);
            this.YearLabel.TabIndex = 33;
            this.YearLabel.Text = "Year:";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(61, 93);
            this.MonthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(45, 15);
            this.MonthLabel.TabIndex = 32;
            this.MonthLabel.Text = "Month:";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(14, 93);
            this.DayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(28, 15);
            this.DayLabel.TabIndex = 31;
            this.DayLabel.Text = "Day";
            this.DayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // YearNum
            // 
            this.YearNum.Location = new System.Drawing.Point(116, 109);
            this.YearNum.Margin = new System.Windows.Forms.Padding(2);
            this.YearNum.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.YearNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.YearNum.Name = "YearNum";
            this.YearNum.Size = new System.Drawing.Size(80, 20);
            this.YearNum.TabIndex = 30;
            this.YearNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DayNum
            // 
            this.DayNum.Location = new System.Drawing.Point(7, 109);
            this.DayNum.Margin = new System.Windows.Forms.Padding(2);
            this.DayNum.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DayNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DayNum.Name = "DayNum";
            this.DayNum.Size = new System.Drawing.Size(40, 20);
            this.DayNum.TabIndex = 29;
            this.DayNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MonthNum
            // 
            this.MonthNum.Location = new System.Drawing.Point(62, 109);
            this.MonthNum.Margin = new System.Windows.Forms.Padding(2);
            this.MonthNum.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MonthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthNum.Name = "MonthNum";
            this.MonthNum.Size = new System.Drawing.Size(40, 20);
            this.MonthNum.TabIndex = 28;
            this.MonthNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ClassificationComboBox
            // 
            this.ClassificationComboBox.FormattingEnabled = true;
            this.ClassificationComboBox.Location = new System.Drawing.Point(106, 214);
            this.ClassificationComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassificationComboBox.Name = "ClassificationComboBox";
            this.ClassificationComboBox.Size = new System.Drawing.Size(110, 21);
            this.ClassificationComboBox.TabIndex = 27;
            // 
            // ClassificationLabel
            // 
            this.ClassificationLabel.AutoSize = true;
            this.ClassificationLabel.Location = new System.Drawing.Point(4, 214);
            this.ClassificationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassificationLabel.Name = "ClassificationLabel";
            this.ClassificationLabel.Size = new System.Drawing.Size(82, 15);
            this.ClassificationLabel.TabIndex = 26;
            this.ClassificationLabel.Text = "Classification:";
            // 
            // NameOfCompanyLabel
            // 
            this.NameOfCompanyLabel.AutoSize = true;
            this.NameOfCompanyLabel.Location = new System.Drawing.Point(4, 184);
            this.NameOfCompanyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameOfCompanyLabel.Name = "NameOfCompanyLabel";
            this.NameOfCompanyLabel.Size = new System.Drawing.Size(96, 15);
            this.NameOfCompanyLabel.TabIndex = 25;
            this.NameOfCompanyLabel.Text = "CompanyName:";
            // 
            // NameProductLabel
            // 
            this.NameProductLabel.AutoSize = true;
            this.NameProductLabel.Location = new System.Drawing.Point(4, 150);
            this.NameProductLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameProductLabel.Name = "NameProductLabel";
            this.NameProductLabel.Size = new System.Drawing.Size(86, 15);
            this.NameProductLabel.TabIndex = 17;
            this.NameProductLabel.Text = "NameProduct:";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(106, 181);
            this.CompanyNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.CompanyNameTextBox.TabIndex = 23;
            // 
            // NameProductTextBox
            // 
            this.NameProductTextBox.Location = new System.Drawing.Point(106, 150);
            this.NameProductTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameProductTextBox.Name = "NameProductTextBox";
            this.NameProductTextBox.Size = new System.Drawing.Size(110, 20);
            this.NameProductTextBox.TabIndex = 22;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(83, 76);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 15);
            this.DateLabel.TabIndex = 21;
            this.DateLabel.Text = "Date";
            // 
            // CountNumericUpDown
            // 
            this.CountNumericUpDown.Location = new System.Drawing.Point(100, 48);
            this.CountNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.CountNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountNumericUpDown.Name = "CountNumericUpDown";
            this.CountNumericUpDown.Size = new System.Drawing.Size(109, 20);
            this.CountNumericUpDown.TabIndex = 19;
            this.CountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NameNumericUpDown
            // 
            this.NameNumericUpDown.Location = new System.Drawing.Point(100, 17);
            this.NameNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.NameNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NameNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NameNumericUpDown.Name = "NameNumericUpDown";
            this.NameNumericUpDown.Size = new System.Drawing.Size(110, 20);
            this.NameNumericUpDown.TabIndex = 18;
            this.NameNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(4, 48);
            this.CountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(42, 15);
            this.CountLabel.TabIndex = 16;
            this.CountLabel.Text = "Count:";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeserializeButton);
            this.Controls.Add(this.SerializeButton);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.addMagazineButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MagazineInfoButton);
            this.Controls.Add(this.CountMagazines_number);
            this.Controls.Add(this.CountMagazines);
            this.Controls.Add(this.ListLotOfToys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListMagazines);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UI";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazineOfToysBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListMagazines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource magazineOfToysBindingSource;
        private System.Windows.Forms.ListBox ListLotOfToys;
        private System.Windows.Forms.Label CountMagazines;
        private System.Windows.Forms.Label CountMagazines_number;
        private System.Windows.Forms.Button MagazineInfoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button addMagazineButton;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.Button GetInfo;
        private System.Windows.Forms.Label NamePartyLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.NumericUpDown CountNumericUpDown;
        private System.Windows.Forms.NumericUpDown NameNumericUpDown;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.TextBox NameProductTextBox;
        private System.Windows.Forms.Label NameProductLabel;
        private System.Windows.Forms.Label ClassificationLabel;
        private System.Windows.Forms.Label NameOfCompanyLabel;
        private System.Windows.Forms.ComboBox ClassificationComboBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.NumericUpDown YearNum;
        private System.Windows.Forms.NumericUpDown DayNum;
        private System.Windows.Forms.NumericUpDown MonthNum;
        private System.Windows.Forms.Button UpdateLotOfToys;
    }
}

