namespace ProducerConsumerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.producerCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.consumerCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.producerCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // producerCountNumericUpDown
            // 
            this.producerCountNumericUpDown.Location = new System.Drawing.Point(13, 13);
            this.producerCountNumericUpDown.Name = "producerCountNumericUpDown";
            this.producerCountNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.producerCountNumericUpDown.TabIndex = 0;
            // 
            // consumerCountNumericUpDown
            // 
            this.consumerCountNumericUpDown.Location = new System.Drawing.Point(165, 13);
            this.consumerCountNumericUpDown.Name = "consumerCountNumericUpDown";
            this.consumerCountNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.consumerCountNumericUpDown.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(458, 164);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 230);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.consumerCountNumericUpDown);
            this.Controls.Add(this.producerCountNumericUpDown);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Producer-Consumer";
            ((System.ComponentModel.ISupportInitialize)(this.producerCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.NumericUpDown producerCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown consumerCountNumericUpDown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

