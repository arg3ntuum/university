
namespace CS_Lab_3_z_6
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.Poluzhirniy = new System.Windows.Forms.Button();
            this.LSize = new System.Windows.Forms.Label();
            this.textSize = new System.Windows.Forms.TextBox();
            this.Podcherknutiy = new System.Windows.Forms.Button();
            this.Naklonniy = new System.Windows.Forms.Button();
            this.center = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(26, 79);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(578, 240);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // openBut
            // 
            this.openBut.Location = new System.Drawing.Point(232, 325);
            this.openBut.Name = "openBut";
            this.openBut.Size = new System.Drawing.Size(83, 22);
            this.openBut.TabIndex = 1;
            this.openBut.Text = "Открыть";
            this.openBut.UseVisualStyleBackColor = true;
            this.openBut.Click += new System.EventHandler(this.openBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(321, 325);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(83, 22);
            this.saveBut.TabIndex = 2;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // Poluzhirniy
            // 
            this.Poluzhirniy.Location = new System.Drawing.Point(216, 12);
            this.Poluzhirniy.Name = "Poluzhirniy";
            this.Poluzhirniy.Size = new System.Drawing.Size(100, 23);
            this.Poluzhirniy.TabIndex = 3;
            this.Poluzhirniy.Text = "Полужирный";
            this.Poluzhirniy.UseVisualStyleBackColor = true;
            this.Poluzhirniy.Click += new System.EventHandler(this.Poluzhirniy_Click);
            // 
            // LSize
            // 
            this.LSize.AutoSize = true;
            this.LSize.Location = new System.Drawing.Point(213, 53);
            this.LSize.Name = "LSize";
            this.LSize.Size = new System.Drawing.Size(46, 13);
            this.LSize.TabIndex = 4;
            this.LSize.Text = "Размер";
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(275, 50);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(100, 20);
            this.textSize.TabIndex = 5;
            this.textSize.Text = "8,25";
            this.textSize.TextChanged += new System.EventHandler(this.textSize_TextChanged);
            // 
            // Podcherknutiy
            // 
            this.Podcherknutiy.Location = new System.Drawing.Point(110, 12);
            this.Podcherknutiy.Name = "Podcherknutiy";
            this.Podcherknutiy.Size = new System.Drawing.Size(100, 23);
            this.Podcherknutiy.TabIndex = 6;
            this.Podcherknutiy.Text = "Подчеркнутый";
            this.Podcherknutiy.UseVisualStyleBackColor = true;
            this.Podcherknutiy.Click += new System.EventHandler(this.Podcherknutiy_Click);
            // 
            // Naklonniy
            // 
            this.Naklonniy.Location = new System.Drawing.Point(322, 12);
            this.Naklonniy.Name = "Naklonniy";
            this.Naklonniy.Size = new System.Drawing.Size(100, 23);
            this.Naklonniy.TabIndex = 7;
            this.Naklonniy.Text = "Наклонный";
            this.Naklonniy.UseVisualStyleBackColor = true;
            this.Naklonniy.Click += new System.EventHandler(this.Naklonniy_Click);
            // 
            // center
            // 
            this.center.Location = new System.Drawing.Point(428, 12);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(100, 23);
            this.center.TabIndex = 8;
            this.center.Text = "По центру";
            this.center.UseVisualStyleBackColor = true;
            this.center.Click += new System.EventHandler(this.center_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 369);
            this.Controls.Add(this.center);
            this.Controls.Add(this.Naklonniy);
            this.Controls.Add(this.Podcherknutiy);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.LSize);
            this.Controls.Add(this.Poluzhirniy);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.openBut);
            this.Controls.Add(this.richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button openBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Button Poluzhirniy;
        private System.Windows.Forms.Label LSize;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Button Podcherknutiy;
        private System.Windows.Forms.Button Naklonniy;
        private System.Windows.Forms.Button center;
    }
}

