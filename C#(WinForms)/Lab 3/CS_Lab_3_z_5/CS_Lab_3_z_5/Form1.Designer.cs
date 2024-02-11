
namespace CS_Lab_3_z_5
{
    partial class Form1
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
            this.LName = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.adressText = new System.Windows.Forms.TextBox();
            this.LAdress = new System.Windows.Forms.Label();
            this.ButHelp = new System.Windows.Forms.Button();
            this.ButOk = new System.Windows.Forms.Button();
            this.butWomen = new System.Windows.Forms.RadioButton();
            this.butMan = new System.Windows.Forms.RadioButton();
            this.LYears = new System.Windows.Forms.Label();
            this.ListJobs = new System.Windows.Forms.CheckedListBox();
            this.LRod = new System.Windows.Forms.Label();
            this.OutList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yearsNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName.Location = new System.Drawing.Point(12, 9);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(34, 16);
            this.LName.TabIndex = 0;
            this.LName.Text = "Имя";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(110, 8);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(191, 20);
            this.nameText.TabIndex = 1;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // adressText
            // 
            this.adressText.Location = new System.Drawing.Point(110, 35);
            this.adressText.Multiline = true;
            this.adressText.Name = "adressText";
            this.adressText.Size = new System.Drawing.Size(191, 81);
            this.adressText.TabIndex = 2;
            this.adressText.TextChanged += new System.EventHandler(this.adressText_TextChanged);
            // 
            // LAdress
            // 
            this.LAdress.AutoSize = true;
            this.LAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LAdress.Location = new System.Drawing.Point(12, 36);
            this.LAdress.Name = "LAdress";
            this.LAdress.Size = new System.Drawing.Size(48, 16);
            this.LAdress.TabIndex = 3;
            this.LAdress.Text = "Адрес";
            // 
            // ButHelp
            // 
            this.ButHelp.Location = new System.Drawing.Point(320, 37);
            this.ButHelp.Name = "ButHelp";
            this.ButHelp.Size = new System.Drawing.Size(75, 22);
            this.ButHelp.TabIndex = 4;
            this.ButHelp.Text = "Help";
            this.ButHelp.UseVisualStyleBackColor = true;
            this.ButHelp.Click += new System.EventHandler(this.ButHelp_Click);
            // 
            // ButOk
            // 
            this.ButOk.Enabled = false;
            this.ButOk.Location = new System.Drawing.Point(320, 8);
            this.ButOk.Name = "ButOk";
            this.ButOk.Size = new System.Drawing.Size(75, 23);
            this.ButOk.TabIndex = 5;
            this.ButOk.Text = "OK";
            this.ButOk.UseVisualStyleBackColor = true;
            this.ButOk.Click += new System.EventHandler(this.ButOk_Click);
            // 
            // butWomen
            // 
            this.butWomen.AutoSize = true;
            this.butWomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butWomen.Location = new System.Drawing.Point(6, 19);
            this.butWomen.Name = "butWomen";
            this.butWomen.Size = new System.Drawing.Size(85, 20);
            this.butWomen.TabIndex = 6;
            this.butWomen.TabStop = true;
            this.butWomen.Text = "Женский";
            this.butWomen.UseVisualStyleBackColor = true;
            this.butWomen.CheckedChanged += new System.EventHandler(this.butWomen_CheckedChanged);
            // 
            // butMan
            // 
            this.butMan.AutoSize = true;
            this.butMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMan.Location = new System.Drawing.Point(101, 19);
            this.butMan.Name = "butMan";
            this.butMan.Size = new System.Drawing.Size(84, 20);
            this.butMan.TabIndex = 7;
            this.butMan.TabStop = true;
            this.butMan.Text = "Мужской";
            this.butMan.UseVisualStyleBackColor = true;
            this.butMan.CheckedChanged += new System.EventHandler(this.butMan_CheckedChanged);
            // 
            // LYears
            // 
            this.LYears.AutoSize = true;
            this.LYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LYears.Location = new System.Drawing.Point(13, 175);
            this.LYears.Name = "LYears";
            this.LYears.Size = new System.Drawing.Size(66, 16);
            this.LYears.TabIndex = 10;
            this.LYears.Text = "Возраст:";
            // 
            // ListJobs
            // 
            this.ListJobs.FormattingEnabled = true;
            this.ListJobs.Items.AddRange(new object[] {
            "Программирование",
            "Торговля",
            "Перевод с иностранного языка",
            "Строительство"});
            this.ListJobs.Location = new System.Drawing.Point(110, 203);
            this.ListJobs.Name = "ListJobs";
            this.ListJobs.Size = new System.Drawing.Size(191, 64);
            this.ListJobs.TabIndex = 11;
            this.ListJobs.SelectedIndexChanged += new System.EventHandler(this.ListJobs_SelectedIndexChanged);
            // 
            // LRod
            // 
            this.LRod.AutoSize = true;
            this.LRod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LRod.Location = new System.Drawing.Point(13, 203);
            this.LRod.Name = "LRod";
            this.LRod.Size = new System.Drawing.Size(93, 16);
            this.LRod.TabIndex = 12;
            this.LRod.Text = "Род занятий:";
            // 
            // OutList
            // 
            this.OutList.BackColor = System.Drawing.SystemColors.Control;
            this.OutList.FormattingEnabled = true;
            this.OutList.Location = new System.Drawing.Point(15, 305);
            this.OutList.Name = "OutList";
            this.OutList.Size = new System.Drawing.Size(286, 134);
            this.OutList.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Результат:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butWomen);
            this.groupBox1.Controls.Add(this.butMan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(110, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 50);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол";
            // 
            // yearsNUD
            // 
            this.yearsNUD.Location = new System.Drawing.Point(110, 175);
            this.yearsNUD.Name = "yearsNUD";
            this.yearsNUD.Size = new System.Drawing.Size(120, 20);
            this.yearsNUD.TabIndex = 16;
            this.yearsNUD.ValueChanged += new System.EventHandler(this.yearsNUD_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.yearsNUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutList);
            this.Controls.Add(this.LRod);
            this.Controls.Add(this.ListJobs);
            this.Controls.Add(this.LYears);
            this.Controls.Add(this.ButOk);
            this.Controls.Add(this.ButHelp);
            this.Controls.Add(this.LAdress);
            this.Controls.Add(this.adressText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Текстовые поля";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox adressText;
        private System.Windows.Forms.Label LAdress;
        private System.Windows.Forms.Button ButHelp;
        private System.Windows.Forms.Button ButOk;
        private System.Windows.Forms.RadioButton butWomen;
        private System.Windows.Forms.RadioButton butMan;
        private System.Windows.Forms.Label LYears;
        private System.Windows.Forms.CheckedListBox ListJobs;
        private System.Windows.Forms.Label LRod;
        private System.Windows.Forms.ListBox OutList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown yearsNUD;
    }
}

