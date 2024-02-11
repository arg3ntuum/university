
namespace CS_Lab_2_z_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.winter = new System.Windows.Forms.RadioButton();
            this.sunset = new System.Windows.Forms.RadioButton();
            this.lilia = new System.Windows.Forms.RadioButton();
            this.hill = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.height = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // winter
            // 
            resources.ApplyResources(this.winter, "winter");
            this.winter.Name = "winter";
            this.winter.TabStop = true;
            this.winter.UseVisualStyleBackColor = true;
            this.winter.CheckedChanged += new System.EventHandler(this.winter_CheckedChanged);
            // 
            // sunset
            // 
            resources.ApplyResources(this.sunset, "sunset");
            this.sunset.Name = "sunset";
            this.sunset.TabStop = true;
            this.sunset.UseVisualStyleBackColor = true;
            this.sunset.CheckedChanged += new System.EventHandler(this.sunset_CheckedChanged);
            // 
            // lilia
            // 
            resources.ApplyResources(this.lilia, "lilia");
            this.lilia.Name = "lilia";
            this.lilia.TabStop = true;
            this.lilia.UseVisualStyleBackColor = true;
            this.lilia.CheckedChanged += new System.EventHandler(this.lilia_CheckedChanged);
            // 
            // hill
            // 
            resources.ApplyResources(this.hill, "hill");
            this.hill.Name = "hill";
            this.hill.TabStop = true;
            this.hill.UseVisualStyleBackColor = true;
            this.hill.CheckedChanged += new System.EventHandler(this.hill_CheckedChanged);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // height
            // 
            resources.ApplyResources(this.height, "height");
            this.height.Name = "height";
            // 
            // width
            // 
            resources.ApplyResources(this.width, "width");
            this.width.Name = "width";
            // 
            // numHeight
            // 
            resources.ApplyResources(this.numHeight, "numHeight");
            this.numHeight.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.numHeight.ValueChanged += new System.EventHandler(this.numHeight_ValueChanged);
            // 
            // numWidth
            // 
            resources.ApplyResources(this.numWidth, "numWidth");
            this.numWidth.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            resources.GetString("listBox1.Items"),
            resources.GetString("listBox1.Items1"),
            resources.GetString("listBox1.Items2")});
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CS_Lab_2_z_2.Properties.Resources.winter;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.width);
            this.Controls.Add(this.height);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.hill);
            this.Controls.Add(this.lilia);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.winter);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton winter;
        private System.Windows.Forms.RadioButton sunset;
        private System.Windows.Forms.RadioButton lilia;
        private System.Windows.Forms.RadioButton hill;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

