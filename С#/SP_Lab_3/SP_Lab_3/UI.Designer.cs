namespace SP_Lab_3
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
            this.Info = new System.Windows.Forms.RichTextBox();
            this.CountMagazines = new System.Windows.Forms.Label();
            this.CountMagazines_number = new System.Windows.Forms.Label();
            this.MagazineInfoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.addMagazineButton = new System.Windows.Forms.Button();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.magazineOfToysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.magazineOfToysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListMagazines
            // 
            this.ListMagazines.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListMagazines.FormattingEnabled = true;
            this.ListMagazines.Location = new System.Drawing.Point(422, 54);
            this.ListMagazines.Name = "ListMagazines";
            this.ListMagazines.Size = new System.Drawing.Size(123, 46);
            this.ListMagazines.TabIndex = 0;
            this.ListMagazines.SelectedIndexChanged += new System.EventHandler(this.ListMagazines_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 54);
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
            this.ListLotOfToys.Location = new System.Drawing.Point(18, 110);
            this.ListLotOfToys.Name = "ListLotOfToys";
            this.ListLotOfToys.Size = new System.Drawing.Size(197, 356);
            this.ListLotOfToys.TabIndex = 2;
            this.ListLotOfToys.SelectedIndexChanged += new System.EventHandler(this.ListLotOfToys_SelectedIndexChanged);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(279, 110);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(266, 356);
            this.Info.TabIndex = 3;
            this.Info.Text = "";
            this.Info.TextChanged += new System.EventHandler(this.Info_TextChanged);
            // 
            // CountMagazines
            // 
            this.CountMagazines.AutoSize = true;
            this.CountMagazines.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountMagazines.Location = new System.Drawing.Point(12, 9);
            this.CountMagazines.Name = "CountMagazines";
            this.CountMagazines.Size = new System.Drawing.Size(345, 33);
            this.CountMagazines.TabIndex = 4;
            this.CountMagazines.Text = "Количество магазинов: ";
            // 
            // CountMagazines_number
            // 
            this.CountMagazines_number.AutoSize = true;
            this.CountMagazines_number.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountMagazines_number.Location = new System.Drawing.Point(345, 11);
            this.CountMagazines_number.Name = "CountMagazines_number";
            this.CountMagazines_number.Size = new System.Drawing.Size(30, 33);
            this.CountMagazines_number.TabIndex = 5;
            this.CountMagazines_number.Text = "0";
            // 
            // MagazineInfoButton
            // 
            this.MagazineInfoButton.Location = new System.Drawing.Point(422, 11);
            this.MagazineInfoButton.Name = "MagazineInfoButton";
            this.MagazineInfoButton.Size = new System.Drawing.Size(123, 29);
            this.MagazineInfoButton.TabIndex = 6;
            this.MagazineInfoButton.Text = "Info magazine";
            this.MagazineInfoButton.UseVisualStyleBackColor = true;
            this.MagazineInfoButton.Click += new System.EventHandler(this.MagazineInfoButton_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(215, 476);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(142, 37);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addMagazineButton
            // 
            this.addMagazineButton.Location = new System.Drawing.Point(403, 476);
            this.addMagazineButton.Name = "addMagazineButton";
            this.addMagazineButton.Size = new System.Drawing.Size(142, 37);
            this.addMagazineButton.TabIndex = 9;
            this.addMagazineButton.Text = "AddMagazine";
            this.addMagazineButton.UseVisualStyleBackColor = true;
            this.addMagazineButton.Click += new System.EventHandler(this.addMagazineButton_Click);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ColorPanel.Location = new System.Drawing.Point(221, 110);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(52, 356);
            this.ColorPanel.TabIndex = 10;
            // 
            // magazineOfToysBindingSource
            // 
            this.magazineOfToysBindingSource.DataSource = typeof(SP_Lab_3.MagazineOfToys);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 525);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.addMagazineButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MagazineInfoButton);
            this.Controls.Add(this.CountMagazines_number);
            this.Controls.Add(this.CountMagazines);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ListLotOfToys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListMagazines);
            this.Name = "UI";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazineOfToysBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListMagazines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource magazineOfToysBindingSource;
        private System.Windows.Forms.ListBox ListLotOfToys;
        private System.Windows.Forms.RichTextBox Info;
        private System.Windows.Forms.Label CountMagazines;
        private System.Windows.Forms.Label CountMagazines_number;
        private System.Windows.Forms.Button MagazineInfoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button addMagazineButton;
        private System.Windows.Forms.Panel ColorPanel;
    }
}

