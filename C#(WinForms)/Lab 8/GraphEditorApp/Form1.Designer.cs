namespace GraphEditorApp
{
    partial class GraphApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrowheadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsMenuItem,
            this.свойстваToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolsMenuItem
            // 
            this.ToolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PenMenuItem,
            this.TextMenuItem,
            this.LineMenuItem,
            this.EllipseMenuItem,
            this.fillToolStripMenuItem});
            this.ToolsMenuItem.Name = "ToolsMenuItem";
            this.ToolsMenuItem.Size = new System.Drawing.Size(86, 20);
            this.ToolsMenuItem.Text = "Инструмент";
            // 
            // PenMenuItem
            // 
            this.PenMenuItem.Checked = true;
            this.PenMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PenMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PenMenuItem.Image")));
            this.PenMenuItem.Name = "PenMenuItem";
            this.PenMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PenMenuItem.Text = "Карандаш";
            this.PenMenuItem.Click += new System.EventHandler(this.PenMenuItem_Click);
            // 
            // TextMenuItem
            // 
            this.TextMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TextMenuItem.Image")));
            this.TextMenuItem.Name = "TextMenuItem";
            this.TextMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TextMenuItem.Text = "Текст";
            this.TextMenuItem.Click += new System.EventHandler(this.TextMenuItem_Click);
            // 
            // LineMenuItem
            // 
            this.LineMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrowheadToolStripMenuItem,
            this.pentypeToolStripMenuItem});
            this.LineMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LineMenuItem.Image")));
            this.LineMenuItem.Name = "LineMenuItem";
            this.LineMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LineMenuItem.Text = "Линия";
            this.LineMenuItem.Click += new System.EventHandler(this.LineMenuItem_Click);
            // 
            // arrowheadToolStripMenuItem
            // 
            this.arrowheadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flatToolStripMenuItem,
            this.ArrowToolStripMenuItem,
            this.circleToolStripMenuItem});
            this.arrowheadToolStripMenuItem.Enabled = false;
            this.arrowheadToolStripMenuItem.Name = "arrowheadToolStripMenuItem";
            this.arrowheadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrowheadToolStripMenuItem.Text = "Наконечники";
            // 
            // flatToolStripMenuItem
            // 
            this.flatToolStripMenuItem.Checked = true;
            this.flatToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flatToolStripMenuItem.Name = "flatToolStripMenuItem";
            this.flatToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.flatToolStripMenuItem.Text = "Плоский";
            this.flatToolStripMenuItem.Click += new System.EventHandler(this.flatToolStripMenuItem_Click);
            // 
            // ArrowToolStripMenuItem
            // 
            this.ArrowToolStripMenuItem.Name = "ArrowToolStripMenuItem";
            this.ArrowToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ArrowToolStripMenuItem.Text = "Стрелка";
            this.ArrowToolStripMenuItem.Click += new System.EventHandler(this.ArrowToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.circleToolStripMenuItem.Text = "Круг";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // pentypeToolStripMenuItem
            // 
            this.pentypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.dotToolStripMenuItem,
            this.dashToolStripMenuItem});
            this.pentypeToolStripMenuItem.Enabled = false;
            this.pentypeToolStripMenuItem.Name = "pentypeToolStripMenuItem";
            this.pentypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pentypeToolStripMenuItem.Text = "Тип пера";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Checked = true;
            this.solidToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.dotToolStripMenuItem.Text = "Dot";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.dotToolStripMenuItem_Click);
            // 
            // dashToolStripMenuItem
            // 
            this.dashToolStripMenuItem.Name = "dashToolStripMenuItem";
            this.dashToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.dashToolStripMenuItem.Text = "Dash";
            this.dashToolStripMenuItem.Click += new System.EventHandler(this.dashToolStripMenuItem_Click);
            // 
            // EllipseMenuItem
            // 
            this.EllipseMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EllipseMenuItem.Image")));
            this.EllipseMenuItem.Name = "EllipseMenuItem";
            this.EllipseMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EllipseMenuItem.Text = "Эллипс";
            this.EllipseMenuItem.Click += new System.EventHandler(this.EllipseMenuItem_Click);
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorToolStripMenuItem,
            this.GradientToolStripMenuItem,
            this.TextureToolStripMenuItem});
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fillToolStripMenuItem.Text = "Заливка";
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ColorToolStripMenuItem.Text = "Цветом";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // GradientToolStripMenuItem
            // 
            this.GradientToolStripMenuItem.Name = "GradientToolStripMenuItem";
            this.GradientToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.GradientToolStripMenuItem.Text = "Градиентом";
            this.GradientToolStripMenuItem.Click += new System.EventHandler(this.GradientToolStripMenuItem_Click);
            // 
            // TextureToolStripMenuItem
            // 
            this.TextureToolStripMenuItem.Name = "TextureToolStripMenuItem";
            this.TextureToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.TextureToolStripMenuItem.Text = "Текстурой";
            this.TextureToolStripMenuItem.Click += new System.EventHandler(this.TextureToolStripMenuItem_Click);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem,
            this.толщинаToolStripMenuItem});
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // толщинаToolStripMenuItem
            // 
            this.толщинаToolStripMenuItem.Name = "толщинаToolStripMenuItem";
            this.толщинаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.толщинаToolStripMenuItem.Text = "Толщина";
            this.толщинаToolStripMenuItem.Click += new System.EventHandler(this.толщинаToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // GraphApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(500, 500);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "GraphApp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphApp_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphApp_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EllipseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TextureToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem arrowheadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pentypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толщинаToolStripMenuItem;
    }
}

