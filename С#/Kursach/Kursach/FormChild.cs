using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class FormChild : Form
    {
        public Bitmap ImageBuffer { get; private set; }
        public ImageFormat ImageFormat { get; private set; }
        public string ImagePath { get; private set; }
        public bool Changed { get; private set; }

        private FormGeneral _parent { get; set; }

        public FormChild(FormGeneral parent, string caption)
        {
            InitializeComponent();

            ImageBuffer = null;
            ImagePath = string.Empty;
            Changed = false;

            _parent = parent;

            this.Paint += FormChild_Paint;
            this.Resize += FormChild_Resize;

            this.MdiParent = parent;

            this.Text = caption;
        }
        public void FormChild_Paint(object sender, PaintEventArgs e)
        {
            if (ImageBuffer == null) 
            { 
                MessageBox.Show("ImageBuffer == null!");
                return;
            }

            Graphics graphics = e.Graphics;

            Bitmap userImage = null;
            
            if (Changed)
                userImage = ImageBuffer;//место для подгрузки нового изображения
            else 
                userImage = ImageBuffer;

            graphics.DrawImage(userImage, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

            graphics.Dispose();

            if (Changed)
            {
                if(MessageBox.Show("Вы хотите загрузить измененную версию картинки в данной форме в ImageBuffer?", "Attention!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    ImageBuffer = userImage;
            }
        }
        public void UploadImageToBuffer()
        {
            if (_parent.ImageBuffer == null) 
            { 
                MessageBox.Show("ImageBuffer == null!");
                return;
            }

            if (_parent.ImagePath == string.Empty) { 
                MessageBox.Show("ImagePath == empty!");
                return;
            }

            ImageBuffer = _parent.ImageBuffer;
            ImagePath = _parent.ImagePath;
            ImageFormat = ImageBuffer.RawFormat;
        }
        private void FormChild_Resize(object sender, EventArgs e) {
            Invalidate();
        }
        private void FormChild_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void FormChild_Load(object sender, EventArgs e) {  }
    }
}
