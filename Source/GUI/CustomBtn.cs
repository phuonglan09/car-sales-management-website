using System;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public class CustomBtn : Button
    {
        private int size = 0;
        private Color mausacc = Color.YellowGreen;
        private int radiuss = 20;
        //Thuộc tính
        [Category("Custom Props")]
        // màu viền
        public Color BorderColor
        {
            get { return mausacc; }
            set
            {
                mausacc = value;
                this.Invalidate();
            }
        }
        [Category("Custom Props")]
        // màu chữ
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
        [Category("Custom Props")]
        // 
        public int BorderRadius
        {
            get { return radiuss; }
            set
            {
                radiuss = value;
                this.Invalidate();
            }
        }
        [Category("Custom Props")]
        //size
        public int BorderSize
        {
            get { return size; }
            set
            {
                size = value;
                this.Invalidate();
            }
        }
        //màu nền
        [Category("Custom Props")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        public CustomBtn()
        {
            this.ForeColor = Color.Black;
            this.Size = new Size(139, 37);
            this.FlatStyle = FlatStyle.Flat;
            this.Resize += new EventHandler(Button_Resize);
            this.BackColor = Color.LightGreen;
            this.FlatAppearance.BorderSize = 0;
        }
        // đường dẫn
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = 2F * radius;

            path.StartFigure();

            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);

            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle surf = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(surf, -size, -size);
            int minmang = 2;
            if (size > 0)
                minmang = size;

            if (radiuss <= 2) //btn thường
            {
                //Button surface
                this.Region = new Region(surf);
                //Button border
                if (size > 0)
                {
                    using (Pen penB = new Pen(mausacc, size))
                    {
                        penB.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penB, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
            else // btn tròn
            {
                using (Pen penSurf = new Pen(this.Parent.BackColor, minmang))
                using (GraphicsPath pathSurf = GetFigurePath(surf, radiuss))
                using (GraphicsPath pathBrder = GetFigurePath(rectBorder, radiuss - size))
                using (Pen penBorder = new Pen(mausacc, size))
                {   // bề mặt btn
                    this.Region = new Region(pathSurf);
                    pevent.Graphics.DrawPath(penSurf, pathSurf);
                    // viền btn                 
                    if (size > 0)
                        pevent.Graphics.DrawPath(penBorder, pathBrder);
                }
            }
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (this.Height < radiuss)
                radiuss = this.Height;
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
    }
}
