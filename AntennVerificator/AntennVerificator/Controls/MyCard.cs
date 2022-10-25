using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AntennVerificator
{
    public class MyCard : Control
    {
        #region -- Variables --

        private float curtainHeight;

        private bool MouseEntered = false;
        private bool MousePressed = false;


        #endregion

        #region -- Properties --
        public string textHeader { get; set; } = "Header";
        public Font fontHeader { get; set; } = new Font("Verdana", 12F, FontStyle.Bold);
        public Color foreColorHeader { get; set; } = Color.White;
        public string textDescription { get; set; } = "Your description";
        public Font fontDescription { get; set; } = new Font("Verdana", 8.25F, FontStyle.Bold);
        public Color foreColorDescription { get; set; } = Color.Black;

        public Color backColorCurtain { get; set; } = Color.Blue;

        #endregion
        public MyCard()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(250, 200);
            curtainHeight = Height - 60;

            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectCurtain = new Rectangle(0, 0, Width - 1, (int)curtainHeight);

            //back
            graph.FillRectangle(new SolidBrush(BackColor), rect);

            //Curtain
            graph.DrawRectangle(new Pen(backColorCurtain), rectCurtain);
            graph.FillRectangle(new SolidBrush(backColorCurtain), rectCurtain);

            //Stroke
            graph.DrawRectangle(new Pen(BackColor), rect);

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), 15, Height - 37);
            graph.DrawString(textHeader, fontHeader, new SolidBrush(foreColorHeader), 
                new Rectangle(15, 15, rectCurtain.Width, rectCurtain.Width));
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (Height <= 100)
                Height = 100;
            if (Width <= 100)
                Width = 100;
            curtainHeight = Height - 60;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MousePressed = true;

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MousePressed = false;

            Invalidate();
        }
    }
}
