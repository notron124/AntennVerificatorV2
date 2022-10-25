using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AntennVerificator
{
    public class MyCard : Control
    {
        #region -- Variables --

        Animation animCurtain;
        private float curtainHeight;
        private int curtainMinHeight = 50;

        private bool mouseEntered = false;
        //private bool MousePressed = false;

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

            animCurtain = new Animation();
            animCurtain.Value = curtainHeight;
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

            if (animCurtain.Value == 50)
            {
                graph.DrawString(textDescription, fontDescription, new SolidBrush(foreColorDescription),
                new Rectangle(15, 70, Width - 15, Height - 70));
            }

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

            animCurtain = new Animation();
            animCurtain.Value = curtainHeight;

            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            mouseEntered = true;

            DoCurtainAnimation();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            mouseEntered = false;

            DoCurtainAnimation();
        }

        private void DoCurtainAnimation()
        {
            if (mouseEntered)
                animCurtain = new Animation("Curtain_" + Handle, Invalidate, animCurtain.Value, 50);
            else
                animCurtain = new Animation("Curtain_" + Handle, Invalidate, animCurtain.Value, curtainHeight);

            Animator.Request(animCurtain, true);
        }
    }
}
