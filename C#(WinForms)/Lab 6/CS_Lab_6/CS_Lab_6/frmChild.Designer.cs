
namespace CS_Lab_6
{
    partial class frmChild
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChild));
            this.rtfText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemBold = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBold = new System.Windows.Forms.ToolStripButton();
            this.toolKursive = new System.Windows.Forms.ToolStripButton();
            this.toolUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolPravka = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfText
            // 
            this.rtfText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfText.Location = new System.Drawing.Point(24, 24);
            this.rtfText.Name = "rtfText";
            this.rtfText.Size = new System.Drawing.Size(395, 262);
            this.rtfText.TabIndex = 0;
            this.rtfText.Text = "";
            this.rtfText.TextChanged += new System.EventHandler(this.rtfText_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemBold,
            this.MenuItemItalic,
            this.MenuItemUnderline});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 70);
            // 
            // MenuItemBold
            // 
            this.MenuItemBold.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemBold.Image")));
            this.MenuItemBold.Name = "MenuItemBold";
            this.MenuItemBold.Size = new System.Drawing.Size(156, 22);
            this.MenuItemBold.Text = "Полужирный";
            this.MenuItemBold.Click += new System.EventHandler(this.MenuItemBold_Click);
            // 
            // MenuItemItalic
            // 
            this.MenuItemItalic.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemItalic.Image")));
            this.MenuItemItalic.Name = "MenuItemItalic";
            this.MenuItemItalic.Size = new System.Drawing.Size(156, 22);
            this.MenuItemItalic.Text = "Курсив";
            this.MenuItemItalic.Click += new System.EventHandler(this.MenuItemItalic_Click);
            // 
            // MenuItemUnderline
            // 
            this.MenuItemUnderline.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemUnderline.Image")));
            this.MenuItemUnderline.Name = "MenuItemUnderline";
            this.MenuItemUnderline.Size = new System.Drawing.Size(156, 22);
            this.MenuItemUnderline.Text = "Подчеркнутый";
            this.MenuItemUnderline.Click += new System.EventHandler(this.MenuItemUnderline_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemNew,
            this.MenuItemOpen,
            this.MenuItemSave,
            this.toolPravka});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.MenuItemFile.Text = "Файл";
            this.MenuItemFile.Click += new System.EventHandler(this.MenuItemFile_Click);
            // 
            // MenuItemNew
            // 
            this.MenuItemNew.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.MenuItemNew.MergeIndex = 1;
            this.MenuItemNew.Name = "MenuItemNew";
            this.MenuItemNew.Size = new System.Drawing.Size(62, 20);
            this.MenuItemNew.Text = "Создать";
            this.MenuItemNew.Click += new System.EventHandler(this.MenuItemNew_Click);
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.MenuItemOpen.MergeIndex = 2;
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.Size = new System.Drawing.Size(66, 20);
            this.MenuItemOpen.Text = "Открыть";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.MenuItemSave.MergeIndex = 3;
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Size = new System.Drawing.Size(78, 20);
            this.MenuItemSave.Text = "Сохранить";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBold,
            this.toolKursive,
            this.toolUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 262);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBold
            // 
            this.toolBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBold.Image = ((System.Drawing.Image)(resources.GetObject("toolBold.Image")));
            this.toolBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBold.Name = "toolBold";
            this.toolBold.Size = new System.Drawing.Size(21, 20);
            this.toolBold.Text = "toolStripButton1";
            this.toolBold.Click += new System.EventHandler(this.toolBold_Click);
            // 
            // toolKursive
            // 
            this.toolKursive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolKursive.Image = ((System.Drawing.Image)(resources.GetObject("toolKursive.Image")));
            this.toolKursive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKursive.Name = "toolKursive";
            this.toolKursive.Size = new System.Drawing.Size(21, 20);
            this.toolKursive.Text = "toolStripButton2";
            this.toolKursive.Click += new System.EventHandler(this.toolKursive_Click);
            // 
            // toolUnderline
            // 
            this.toolUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolUnderline.Image")));
            this.toolUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUnderline.Name = "toolUnderline";
            this.toolUnderline.Size = new System.Drawing.Size(21, 20);
            this.toolUnderline.Text = "toolStripButton3";
            this.toolUnderline.Click += new System.EventHandler(this.toolUnderline_Click);
            // 
            // toolPravka
            // 
            this.toolPravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUndo,
            this.menuRedo,
            this.menuCopy,
            this.menuCut,
            this.menuPaste});
            this.toolPravka.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolPravka.Name = "toolPravka";
            this.toolPravka.Size = new System.Drawing.Size(59, 20);
            this.toolPravka.Text = "Правка";
            this.toolPravka.Click += new System.EventHandler(this.toolPravka_Click);
            // 
            // menuUndo
            // 
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.Size = new System.Drawing.Size(180, 22);
            this.menuUndo.Text = "Отменить";
            this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
            // 
            // menuRedo
            // 
            this.menuRedo.Name = "menuRedo";
            this.menuRedo.Size = new System.Drawing.Size(180, 22);
            this.menuRedo.Text = "Повторить";
            this.menuRedo.Click += new System.EventHandler(this.menuRedo_Click);
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.Size = new System.Drawing.Size(180, 22);
            this.menuCopy.Text = "Копировать";
            this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // menuCut
            // 
            this.menuCut.Name = "menuCut";
            this.menuCut.Size = new System.Drawing.Size(180, 22);
            this.menuCut.Text = "Вырезать";
            this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.Size = new System.Drawing.Size(180, 22);
            this.menuPaste.Text = "Вставить";
            this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
            // 
            // frmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 286);
            this.Controls.Add(this.rtfText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChild";
            this.Text = "frmChild";
            this.Load += new System.EventHandler(this.frmChild_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBold;
        private System.Windows.Forms.ToolStripMenuItem MenuItemItalic;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUnderline;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBold;
        private System.Windows.Forms.ToolStripButton toolKursive;
        private System.Windows.Forms.ToolStripButton toolUnderline;
        private System.Windows.Forms.ToolStripMenuItem toolPravka;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuRedo;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
    }
}