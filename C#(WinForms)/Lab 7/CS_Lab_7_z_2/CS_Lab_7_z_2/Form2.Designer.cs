
namespace CS_Lab_7_z_2
{
    partial class Form2
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OKBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butWhite = new System.Windows.Forms.RadioButton();
            this.butYellow = new System.Windows.Forms.RadioButton();
            this.butBlue = new System.Windows.Forms.RadioButton();
            this.butRed = new System.Windows.Forms.RadioButton();
            this.butGreen = new System.Windows.Forms.RadioButton();
            this.butBlack = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // OKBut
            // 
            this.OKBut.Location = new System.Drawing.Point(9, 202);
            this.OKBut.Name = "OKBut";
            this.OKBut.Size = new System.Drawing.Size(75, 23);
            this.OKBut.TabIndex = 0;
            this.OKBut.Text = "OK";
            this.OKBut.UseVisualStyleBackColor = true;
            this.OKBut.Click += new System.EventHandler(this.OKBut_Click);
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(95, 202);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 1;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // fill
            // 
            this.fill.AutoSize = true;
            this.fill.Location = new System.Drawing.Point(13, 179);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(71, 17);
            this.fill.TabIndex = 2;
            this.fill.Text = "Fill Ellipse";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.CheckedChanged += new System.EventHandler(this.fill_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butWhite);
            this.groupBox1.Controls.Add(this.butYellow);
            this.groupBox1.Controls.Add(this.butBlue);
            this.groupBox1.Controls.Add(this.butRed);
            this.groupBox1.Controls.Add(this.butGreen);
            this.groupBox1.Controls.Add(this.butBlack);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // butWhite
            // 
            this.butWhite.AutoSize = true;
            this.butWhite.Location = new System.Drawing.Point(5, 135);
            this.butWhite.Name = "butWhite";
            this.butWhite.Size = new System.Drawing.Size(53, 17);
            this.butWhite.TabIndex = 5;
            this.butWhite.Text = "White";
            this.butWhite.UseVisualStyleBackColor = true;
            this.butWhite.CheckedChanged += new System.EventHandler(this.butWhite_CheckedChanged);
            // 
            // butYellow
            // 
            this.butYellow.AutoSize = true;
            this.butYellow.Location = new System.Drawing.Point(5, 112);
            this.butYellow.Name = "butYellow";
            this.butYellow.Size = new System.Drawing.Size(56, 17);
            this.butYellow.TabIndex = 4;
            this.butYellow.Text = "Yellow";
            this.butYellow.UseVisualStyleBackColor = true;
            this.butYellow.CheckedChanged += new System.EventHandler(this.butYellow_CheckedChanged);
            // 
            // butBlue
            // 
            this.butBlue.AutoSize = true;
            this.butBlue.Location = new System.Drawing.Point(5, 89);
            this.butBlue.Name = "butBlue";
            this.butBlue.Size = new System.Drawing.Size(46, 17);
            this.butBlue.TabIndex = 3;
            this.butBlue.Text = "Blue";
            this.butBlue.UseVisualStyleBackColor = true;
            this.butBlue.CheckedChanged += new System.EventHandler(this.butBlue_CheckedChanged);
            // 
            // butRed
            // 
            this.butRed.AutoSize = true;
            this.butRed.Location = new System.Drawing.Point(5, 66);
            this.butRed.Name = "butRed";
            this.butRed.Size = new System.Drawing.Size(45, 17);
            this.butRed.TabIndex = 2;
            this.butRed.Text = "Red";
            this.butRed.UseVisualStyleBackColor = true;
            this.butRed.CheckedChanged += new System.EventHandler(this.butRed_CheckedChanged);
            // 
            // butGreen
            // 
            this.butGreen.AutoSize = true;
            this.butGreen.Location = new System.Drawing.Point(5, 43);
            this.butGreen.Name = "butGreen";
            this.butGreen.Size = new System.Drawing.Size(54, 17);
            this.butGreen.TabIndex = 1;
            this.butGreen.Text = "Green";
            this.butGreen.UseVisualStyleBackColor = true;
            this.butGreen.CheckedChanged += new System.EventHandler(this.butGreen_CheckedChanged);
            // 
            // butBlack
            // 
            this.butBlack.AutoSize = true;
            this.butBlack.Location = new System.Drawing.Point(5, 20);
            this.butBlack.Name = "butBlack";
            this.butBlack.Size = new System.Drawing.Size(52, 17);
            this.butBlack.TabIndex = 0;
            this.butBlack.Text = "Black";
            this.butBlack.UseVisualStyleBackColor = true;
            this.butBlack.CheckedChanged += new System.EventHandler(this.butBlack_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 237);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.OKBut);
            this.Name = "Form2";
            this.Text = "Color/Fill Select";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OKBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.CheckBox fill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton butYellow;
        private System.Windows.Forms.RadioButton butBlue;
        private System.Windows.Forms.RadioButton butRed;
        private System.Windows.Forms.RadioButton butGreen;
        private System.Windows.Forms.RadioButton butBlack;
        private System.Windows.Forms.RadioButton butWhite;
    }
}