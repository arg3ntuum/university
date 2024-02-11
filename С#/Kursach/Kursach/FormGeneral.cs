using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;

namespace Kursach
{
    public partial class FormGeneral : Form
    {
        public Bitmap ImageBuffer { get; private set; }
        public string ImagePath { get; private set; }
        
        private int _nextFormNumber { get; set; }

        public FormGeneral()
        {
            InitializeComponent();

            ImageBuffer = null;
            ImagePath = string.Empty;
            _nextFormNumber = 1;

            Text = "Курсовая работа";
            IsMdiContainer = true;

            OpenFileDialogWindow.FileName = "image.png";
            OpenFileDialogWindow.Filter = "Image files(*.bmp;*.jpg;*.png;*.gif;*.tiff)|*.bmp;*.jpg;*.png;*.gif;*.tiff";
        }
        //1 Point
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild newChild = new FormChild(this, "Редактор" + _nextFormNumber++);

            newChild.Show();

            newChild.UploadImageToBuffer();
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogWindow.ShowDialog() == DialogResult.Cancel) 
            { 
                return;
            }

            ImagePath = OpenFileDialogWindow.FileName;

            try
            {
                using (var bitmap = (Bitmap)Image.FromFile(ImagePath)) 
                { 
                    ImageBuffer = new Bitmap(bitmap);
                }
            }
            catch
            {
                MessageBox.Show("Файл не найден по заданому пути!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            FormChild activeChild = (FormChild)this.ActiveMdiChild;

            if (activeChild == null)
            {
                if (MessageBox.Show("Создавать форму для отображения картинки?", "Attention!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CreateToolStripMenuItem_Click(null, null);
                }
            }
            else
            {
                activeChild.UploadImageToBuffer();
                activeChild.Invalidate();
            }
            ImageBuffer = null;
            ImagePath = string.Empty;
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null) 
            { 
                MessageBox.Show("АctiveMdiChild == null!");
                return;
            }

            FormChild activeChild = (FormChild)this.ActiveMdiChild;

            if (MessageBox.Show("Вы желаете сохранить картинку в том же файле или не сохранять?", "Attention!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Save(activeChild, activeChild.ImagePath);
            } 
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null) 
            {
                MessageBox.Show("АctiveMdiChild == null!");
                return;
            }

            SaveFileDialog saveFileDialogObject = new SaveFileDialog();

            saveFileDialogObject.Filter = OpenFileDialogWindow.Filter;

            FormChild activeChild = (FormChild)this.ActiveMdiChild;

            if (saveFileDialogObject.ShowDialog() == DialogResult.OK) 
            { 
                Save(activeChild, saveFileDialogObject.FileName);
            }
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null) 
            {
                MessageBox.Show("АctiveMdiChild == null!");
                return;
            }

            FormChild activeChild = (FormChild)this.ActiveMdiChild;

            GetAnswerToSaveAndSave(activeChild);

            activeChild.Close();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null) 
            { 
                Application.Exit();
            }
            
            foreach (FormChild item in MdiChildren)
            {
                item.Select();
                GetAnswerToSaveAndSave(item);
            }

            Application.Exit();
        }
        private void GetAnswerToSaveAndSave(FormChild activeChild) {
            if (activeChild.Changed == true)
            {
                if (MessageBox.Show("Вы хотите сохранить картинку в том же файле или вы предпочтете не сохранять вовсе?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Save(activeChild, activeChild.ImagePath);
                }
            }
            else 
            { 
                MessageBox.Show("Changed == false!");
            }
        }
        private void Save(FormChild activeChild, string path)
        {
            try {
                if (activeChild.ImageBuffer == null) 
                { 
                    MessageBox.Show("ImageBuffer == null!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(path)) 
                { 
                    MessageBox.Show("Путь сохранения не задан или не существует!");
                    return;
                }

                File.Delete(path);

                activeChild.ImageBuffer.Save(path, activeChild.ImageFormat);
                activeChild.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }
        //2 Пункт
        private void InformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null) 
            { 
                MessageBox.Show("АctiveMdiChild == null!");
                return;
            }

            FormChild activeChild = (FormChild)this.ActiveMdiChild;

            if (activeChild.ImageBuffer == null) 
            { 
                MessageBox.Show("ImageBuffer == null!");
                return;
            }

            float dpiX = 0, dpiY = 0, dpiBase = 96;
            using (var g = new Control().CreateGraphics())
            {
                dpiX = g.DpiX;
                dpiY = g.DpiY;
            }

            string FileName = Path.GetFileName(activeChild.ImagePath);
            string PathToFile = activeChild.ImagePath;
            ImageFormat imageFormat = activeChild.ImageFormat;
            int height = activeChild.ImageBuffer.Height;
            int width = activeChild.ImageBuffer.Width;
            double horizontalResolution = activeChild.ImageBuffer.HorizontalResolution / 2.54;
            double verticalResolution = activeChild.ImageBuffer.VerticalResolution / 2.54;
            double realHeight = activeChild.ImageBuffer.Height * dpiX / dpiBase;
            double realWidth = activeChild.ImageBuffer.Width * dpiY / dpiBase;
            PixelFormat pixelFormat = activeChild.ImageBuffer.PixelFormat;
            bool isAlphaPixelFormat = Image.IsAlphaPixelFormat(activeChild.ImageBuffer.PixelFormat);
            int pixelFormatSize = Image.GetPixelFormatSize(activeChild.ImageBuffer.PixelFormat);
            
            string text =
                $"\nНазвание файла: {FileName};" +
                $"\nПуть к файлу: {PathToFile};" +
                $"\nФормат файла: {imageFormat};" +
                $"\nВысота изображения: {height}px;" +
                $"\nШирина изображення: {width}px;" +
                $"\nГоризонтальная разделительная способность: {horizontalResolution};" +
                $"\nВертикальная разделительная способность: {verticalResolution};" +
                $"\nВысота в см: {realHeight}cm;" +
                $"\nШирина в см: {realWidth}cm;" +
                $"\nИспользованный формат пикселей: {pixelFormat};" +
                $"\nИспользование бита або байта прозрачности: {isAlphaPixelFormat};" +
                $"\nКоличество бит на пиксель: {pixelFormatSize}.";
            
            MessageBox.Show(text);
        }
        //3 Point
        private void Task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new ArgumentException("Задание 1 не прописано!");
        }
        private void Task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new ArgumentException("Задание 2 не прописано!");
        }
        private void FormGeneral_Load(object sender, EventArgs e){}
    }
}