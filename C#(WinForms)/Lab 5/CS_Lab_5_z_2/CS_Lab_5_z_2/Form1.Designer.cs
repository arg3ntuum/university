
namespace CS_Lab_5_z_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.instrument = new System.Windows.Forms.ToolStrip();
            this.instrumentRed = new System.Windows.Forms.ToolStripButton();
            this.instrumentBlue = new System.Windows.Forms.ToolStripButton();
            this.instrumentWhite = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.instrument.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRed,
            this.menuBlue,
            this.menuWhite});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(126, 20);
            this.menu.Text = "Сменить цвет фона";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuRed
            // 
            this.menuRed.Image = ((System.Drawing.Image)(resources.GetObject("menuRed.Image")));
            this.menuRed.Name = "menuRed";
            this.menuRed.Size = new System.Drawing.Size(123, 22);
            this.menuRed.Text = "Красный";
            this.menuRed.Click += new System.EventHandler(this.menuRed_Click);
            // 
            // menuBlue
            // 
            this.menuBlue.Image = ((System.Drawing.Image)(resources.GetObject("menuBlue.Image")));
            this.menuBlue.Name = "menuBlue";
            this.menuBlue.Size = new System.Drawing.Size(123, 22);
            this.menuBlue.Text = "Синий";
            this.menuBlue.Click += new System.EventHandler(this.menuBlue_Click);
            // 
            // menuWhite
            // 
            this.menuWhite.Image = ((System.Drawing.Image)(resources.GetObject("menuWhite.Image")));
            this.menuWhite.Name = "menuWhite";
            this.menuWhite.Size = new System.Drawing.Size(123, 22);
            this.menuWhite.Text = "Белый";
            this.menuWhite.Click += new System.EventHandler(this.menuWhite_Click);
            // 
            // instrument
            // 
            this.instrument.Dock = System.Windows.Forms.DockStyle.Left;
            this.instrument.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentRed,
            this.instrumentBlue,
            this.instrumentWhite});
            this.instrument.Location = new System.Drawing.Point(0, 24);
            this.instrument.Name = "instrument";
            this.instrument.Size = new System.Drawing.Size(24, 426);
            this.instrument.TabIndex = 1;
            this.instrument.Text = "toolStrip1";
            // 
            // instrumentRed
            // 
            this.instrumentRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.instrumentRed.Image = ((System.Drawing.Image)(resources.GetObject("instrumentRed.Image")));
            this.instrumentRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.instrumentRed.Name = "instrumentRed";
            this.instrumentRed.Size = new System.Drawing.Size(21, 20);
            this.instrumentRed.Text = "toolStripButton1";
            this.instrumentRed.Click += new System.EventHandler(this.instrumentRed_Click);
            // 
            // instrumentBlue
            // 
            this.instrumentBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.instrumentBlue.Image = ((System.Drawing.Image)(resources.GetObject("instrumentBlue.Image")));
            this.instrumentBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.instrumentBlue.Name = "instrumentBlue";
            this.instrumentBlue.Size = new System.Drawing.Size(21, 20);
            this.instrumentBlue.Text = "toolStripButton2";
            this.instrumentBlue.Click += new System.EventHandler(this.instrumentBlue_Click);
            // 
            // instrumentWhite
            // 
            this.instrumentWhite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.instrumentWhite.Image = ((System.Drawing.Image)(resources.GetObject("instrumentWhite.Image")));
            this.instrumentWhite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.instrumentWhite.Name = "instrumentWhite";
            this.instrumentWhite.Size = new System.Drawing.Size(21, 20);
            this.instrumentWhite.Text = "toolStripButton3";
            this.instrumentWhite.Click += new System.EventHandler(this.instrumentWhite_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(24, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(776, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel1.Text = "Цвет не выбран.";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(24, 406);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(776, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.instrument);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.instrument.ResumeLayout(false);
            this.instrument.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem menuRed;
        private System.Windows.Forms.ToolStripMenuItem menuBlue;
        private System.Windows.Forms.ToolStripMenuItem menuWhite;
        private System.Windows.Forms.ToolStrip instrument;
        private System.Windows.Forms.ToolStripButton instrumentRed;
        private System.Windows.Forms.ToolStripButton instrumentBlue;
        private System.Windows.Forms.ToolStripButton instrumentWhite;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip2;
    }
}

