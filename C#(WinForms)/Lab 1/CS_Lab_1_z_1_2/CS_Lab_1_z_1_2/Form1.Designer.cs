
namespace CS_Lab_1_z_1_2
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
            this.exitBut = new System.Windows.Forms.Button();
            this.changeBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBut
            // 
            this.exitBut.BackColor = System.Drawing.Color.Gold;
            this.exitBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBut.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitBut.Location = new System.Drawing.Point(698, 12);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(90, 28);
            this.exitBut.TabIndex = 1;
            this.exitBut.Text = "Выход";
            this.exitBut.UseVisualStyleBackColor = false;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // changeBut
            // 
            this.changeBut.BackColor = System.Drawing.Color.IndianRed;
            this.changeBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeBut.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.changeBut.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeBut.Location = new System.Drawing.Point(205, 177);
            this.changeBut.Name = "changeBut";
            this.changeBut.Size = new System.Drawing.Size(380, 100);
            this.changeBut.TabIndex = 2;
            this.changeBut.Text = "Цвет фона";
            this.changeBut.UseVisualStyleBackColor = false;
            this.changeBut.Click += new System.EventHandler(this.changeBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeBut);
            this.Controls.Add(this.exitBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.Button changeBut;
    }
}

