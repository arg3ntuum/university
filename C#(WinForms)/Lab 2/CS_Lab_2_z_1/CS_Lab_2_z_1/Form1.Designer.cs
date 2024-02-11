
namespace CS_Lab_2_z_1
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
            this.components = new System.ComponentModel.Container();
            this.timeZeroMinutes = new System.Windows.Forms.Label();
            this.timeZeroSecond = new System.Windows.Forms.Label();
            this.timeZeroPoints1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeText = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timeZeroHours = new System.Windows.Forms.Label();
            this.timeZeroPoints2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // timeZeroMinutes
            // 
            this.timeZeroMinutes.AutoSize = true;
            this.timeZeroMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeZeroMinutes.Location = new System.Drawing.Point(366, 67);
            this.timeZeroMinutes.Name = "timeZeroMinutes";
            this.timeZeroMinutes.Size = new System.Drawing.Size(104, 73);
            this.timeZeroMinutes.TabIndex = 1;
            this.timeZeroMinutes.Text = "00";
            // 
            // timeZeroSecond
            // 
            this.timeZeroSecond.AutoSize = true;
            this.timeZeroSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeZeroSecond.Location = new System.Drawing.Point(557, 67);
            this.timeZeroSecond.Name = "timeZeroSecond";
            this.timeZeroSecond.Size = new System.Drawing.Size(104, 73);
            this.timeZeroSecond.TabIndex = 2;
            this.timeZeroSecond.Text = "00";
            // 
            // timeZeroPoints1
            // 
            this.timeZeroPoints1.AutoSize = true;
            this.timeZeroPoints1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeZeroPoints1.Location = new System.Drawing.Point(491, 67);
            this.timeZeroPoints1.Name = "timeZeroPoints1";
            this.timeZeroPoints1.Size = new System.Drawing.Size(50, 73);
            this.timeZeroPoints1.TabIndex = 3;
            this.timeZeroPoints1.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeText.Location = new System.Drawing.Point(3, 196);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(415, 29);
            this.timeText.TabIndex = 4;
            this.timeText.Text = "Выберите время работы таймера: ";
            this.timeText.Click += new System.EventHandler(this.timeText_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(433, 196);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(176, 35);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timeZeroHours
            // 
            this.timeZeroHours.AutoSize = true;
            this.timeZeroHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeZeroHours.Location = new System.Drawing.Point(165, 67);
            this.timeZeroHours.Name = "timeZeroHours";
            this.timeZeroHours.Size = new System.Drawing.Size(104, 73);
            this.timeZeroHours.TabIndex = 7;
            this.timeZeroHours.Text = "00";
            this.timeZeroHours.Click += new System.EventHandler(this.timeZeroHours_Click);
            // 
            // timeZeroPoints2
            // 
            this.timeZeroPoints2.AutoSize = true;
            this.timeZeroPoints2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeZeroPoints2.Location = new System.Drawing.Point(292, 67);
            this.timeZeroPoints2.Name = "timeZeroPoints2";
            this.timeZeroPoints2.Size = new System.Drawing.Size(50, 73);
            this.timeZeroPoints2.TabIndex = 8;
            this.timeZeroPoints2.Text = ":";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Секунды",
            "Минуты",
            "Часы"});
            this.comboBox1.Location = new System.Drawing.Point(625, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 37);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop.Location = new System.Drawing.Point(625, 352);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(112, 56);
            this.stop.TabIndex = 10;
            this.stop.Text = "Стоп";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(54, 352);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(131, 56);
            this.start.TabIndex = 11;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 266);
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(683, 51);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Value = 100;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.timeZeroPoints2);
            this.Controls.Add(this.timeZeroHours);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.timeZeroPoints1);
            this.Controls.Add(this.timeZeroSecond);
            this.Controls.Add(this.timeZeroMinutes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timeZeroSecond;
        private System.Windows.Forms.Label timeZeroPoints1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        protected System.Windows.Forms.Label timeZeroMinutes;
        protected System.Windows.Forms.Label timeZeroHours;
        private System.Windows.Forms.Label timeZeroPoints2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

