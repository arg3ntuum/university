using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphEditorApp
{

    public partial class GraphApp : Form
    {
        public Point PreviousPoint;

        public bool DrawPen = false;
        public bool FirstClick = false;

        private TextureBrush _textureBrush = new TextureBrush(new Bitmap("1.jpg"));      
        private SolidBrush _solidBrush1 = new SolidBrush(Color.Black);
        private SolidBrush _solidBrush2 = new SolidBrush(Color.Red); 
        private Pen _pen = new Pen(Color.Black, 5);
        
        private FillerTools _fillTool = FillerTools.NULL;
        private Tools _curentTool = Tools.PEN;
        
        private float _width = 5;
        private string _text = "Программирование на С#";

        public enum Tools
        {
            PEN = 1, TEXT, LINE, ELLIPSE, FILLER, NULL = 0
        }

        public enum FillerTools
        { 
            Color = 1, Gradient, Texture, NULL = 0
        }

        public GraphApp()
        {
            InitializeComponent();
        }

        private void PenMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllItems();
            pentypeToolStripMenuItem.Enabled = false;
            arrowheadToolStripMenuItem.Enabled = false;
            PenMenuItem.Checked = true;
            _curentTool = Tools.PEN; 
        }

        private void TextMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllItems();
            pentypeToolStripMenuItem.Enabled = false;
            arrowheadToolStripMenuItem.Enabled = false;
            TextMenuItem.Checked = true;
            _curentTool = Tools.TEXT;
            _text = Microsoft.VisualBasic.Interaction.InputBox("Введите текст:");
            if (_text == "")
                _text = "Программирование на С#";
        }

        private void LineMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllItems();
            pentypeToolStripMenuItem.Enabled = true;
            arrowheadToolStripMenuItem.Enabled = true;
            flatToolStripMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = true;
            _pen.StartCap = LineCap.Flat;
            _pen.EndCap = LineCap.Flat;
            _pen.DashStyle = DashStyle.Solid;
            LineMenuItem.Checked = true;
            _curentTool = Tools.LINE;
        }

        private void EllipseMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllItems();
            pentypeToolStripMenuItem.Enabled = false;
            arrowheadToolStripMenuItem.Enabled = false;
            EllipseMenuItem.Checked = true;
            _curentTool = Tools.ELLIPSE;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (_curentTool)
            {
                case Tools.LINE:
                    DrawLine(new Point (e.X, e.Y));
                    break;
                case Tools.ELLIPSE:
                    DrawEllipse(new Point (e.X, e.Y));
                    break;
                case Tools.TEXT:
                    DrawText(new Point(e.X, e.Y));
                    break;
                case Tools.FILLER:
                    FillForm(new Point(e.X, e.Y));
                    break;
                case Tools.PEN:
                    DrawPen = true;
                    break;
            }
            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }

        private void GraphApp_MouseUp(object sender, MouseEventArgs e)
        {
            DrawPen = false;
        }

        private void GraphApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (DrawPen)
            {
                Point point = new Point(e.X, e.Y);
                Graphics g = this.CreateGraphics();
                g.DrawLine(_pen, PreviousPoint, point);
                PreviousPoint = point;
            }

        }

        void DrawLine(Point point)
        {
            if (FirstClick == true)
            {
                Graphics g = this.CreateGraphics();
                g.DrawLine(_pen, PreviousPoint, point);
                FirstClick = false;
            }
            else
            {
                FirstClick = true;
            }
        }

        void DrawEllipse(Point point)
        {
            if (FirstClick == true)
            {
                Graphics g = this.CreateGraphics();
                g.DrawEllipse(_pen,
                PreviousPoint.X, PreviousPoint.Y,
                point.X - PreviousPoint.X, point.Y - PreviousPoint.Y);
                FirstClick = false;
            }
            else
                FirstClick = true;
        }

        void DrawText(Point point)
        {
            Graphics g = this.CreateGraphics();
            Font titleFont = new Font("Lucida Sans Unicode", _width);
            g.DrawString(_text,
              titleFont, _solidBrush1, point.X, point.Y);
        }
        
        void FillForm(Point point)
        {
            if (FirstClick == true)
            {
                Graphics g = this.CreateGraphics();
                int height, width, x, y;

                if (point.X > PreviousPoint.X)
                {
                    x = PreviousPoint.X;
                    width = point.X - PreviousPoint.X;
                }
                else if (point.X < PreviousPoint.X)
                {
                    x = point.X;
                    width = PreviousPoint.X - point.X;
                }
                else
                {
                    FirstClick = false;
                    return;
                }

                if (point.Y > PreviousPoint.Y)
                {
                    y = PreviousPoint.Y;
                    height = point.Y - PreviousPoint.Y;
                }
                else if (point.Y < PreviousPoint.Y)
                {
                    y = point.Y;
                    height = PreviousPoint.Y - point.Y;
                }
                else
                {
                    FirstClick = false;
                    return;
                }

                switch (_fillTool) 
                {
                    case FillerTools.Color:
                        g.FillRectangle(_solidBrush1, new Rectangle(x, y, width, height));
                         break;
                    case FillerTools.Gradient:
                       Brush grBrh = new LinearGradientBrush(new Rectangle(point.X, point.Y, width, height), _solidBrush1.Color, _solidBrush2.Color, 45);
                       g.FillRectangle(grBrh, new Rectangle(x, y, width, height));
                        break;
                    case FillerTools.Texture:
                        g.FillRectangle(_textureBrush, new Rectangle(x, y, width, height));
                        break;
                }
                FirstClick = false;
            }
            else
                FirstClick = true;
        }
        


        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllItems();
            pentypeToolStripMenuItem.Enabled = false;
            arrowheadToolStripMenuItem.Enabled = false;
            fillToolStripMenuItem.Checked = true;
            ColorToolStripMenuItem.Checked = true;
            _curentTool = Tools.FILLER;
            _fillTool = FillerTools.Color;

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                _solidBrush1 = new SolidBrush(colorDialog.Color);
        }

        private void GradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllItems();
            pentypeToolStripMenuItem.Enabled = false;
            arrowheadToolStripMenuItem.Enabled = false;
            fillToolStripMenuItem.Checked = true;
            GradientToolStripMenuItem.Checked = true;
            _curentTool = Tools.FILLER;
            _fillTool = FillerTools.Gradient;

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                _solidBrush1 = new SolidBrush(colorDialog.Color);
            if (colorDialog.ShowDialog() == DialogResult.OK)
                _solidBrush2 = new SolidBrush(colorDialog.Color);
            
        }

        private void TextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllItems();
            pentypeToolStripMenuItem.Enabled = false;
            arrowheadToolStripMenuItem.Enabled = false;
            fillToolStripMenuItem.Checked = true;
            TextureToolStripMenuItem.Checked = true;
            _curentTool = Tools.FILLER;
            _fillTool = FillerTools.Texture;

            FileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "Image files(*.bmp, *.png, *.jpg, *.jpeg)|*.bmp, *.png, *.jpg, *.jpeg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
                _textureBrush = new TextureBrush(new Bitmap(fileDialog.FileName));
        }

        private void UncheckAllItems()
        {
            foreach (ToolStripMenuItem menu in
                     ToolsMenuItem.DropDownItems)
                menu.Checked = false;
            foreach (ToolStripMenuItem menu in
                    fillToolStripMenuItem.DropDownItems)
                menu.Checked = false;
            foreach (ToolStripMenuItem menu in
                   arrowheadToolStripMenuItem.DropDownItems)
                menu.Checked = false;
            foreach (ToolStripMenuItem menu in
                   pentypeToolStripMenuItem.DropDownItems)
                menu.Checked = false;
        }

        private void flatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menu in
                   arrowheadToolStripMenuItem.DropDownItems)
                menu.Checked = false;
            LineMenuItem.Checked = true;
            flatToolStripMenuItem.Checked = true;
            _curentTool = Tools.LINE;
            _pen.StartCap = LineCap.Flat;
            _pen.EndCap = LineCap.Flat;
        }

        private void ArrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menu in
                   arrowheadToolStripMenuItem.DropDownItems)
                menu.Checked = false;
            LineMenuItem.Checked = true;
            ArrowToolStripMenuItem.Checked = true;
            _curentTool = Tools.LINE;
            _pen.StartCap = LineCap.ArrowAnchor;
            _pen.EndCap = LineCap.ArrowAnchor;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menu in
                   arrowheadToolStripMenuItem.DropDownItems)
                menu.Checked = false;
            LineMenuItem.Checked = true;
            circleToolStripMenuItem.Checked = true;
            _curentTool = Tools.LINE;
            _pen.StartCap = LineCap.Round;
            _pen.EndCap = LineCap.Round;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menu in
                   pentypeToolStripMenuItem.DropDownItems)
                menu.Checked = false;
            LineMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = true;
            _curentTool = Tools.LINE;
            _pen.DashStyle = DashStyle.Solid;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menu in
                   pentypeToolStripMenuItem.DropDownItems)
                menu.Checked = false;
            LineMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = true;
            _curentTool = Tools.LINE;
            _pen.DashStyle = DashStyle.Dot;
        }

        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menu in
                   pentypeToolStripMenuItem.DropDownItems)
                menu.Checked = false;
            LineMenuItem.Checked = true;
            dashToolStripMenuItem.Checked = true;
            _curentTool = Tools.LINE;
            _pen.DashStyle = DashStyle.Dash;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _pen = new Pen(colorDialog.Color, _pen.Width);
                _solidBrush1 = new SolidBrush(colorDialog.Color);
            }
        }

        private void толщинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _text = Microsoft.VisualBasic.Interaction.InputBox("Введите толщину(0,1 +∞):", "Толщина инструментов", _width.ToString());
            try
            {
                float res = (float)Convert.ToDouble(_text);
                if (res > 0)
                {
                    _width = res;
                    _pen = new Pen(_pen.Color, _width);
                }
            }
            catch{}
        }
    }
}
