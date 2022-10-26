using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace AntennVerificator
{
    public class MyToggleSwitch : Control
    {
        #region -- Variables --
        Rectangle rect;
        int togglePosOn;
        int togglePosOff;
        Animation toggleAnim;
        #endregion

        #region -- Properties --
        public bool Checked { get; set; } = false;
        public Color backColorOn { get; set; } = Color.Green;
        public Color strokeColor { get; set; } = Color.Gray;
        #endregion

        public MyToggleSwitch()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(40, 15);

            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;

            rect = new Rectangle(1, 1, Width - 3, Height - 3);
            togglePosOff = rect.X;
            togglePosOn = rect.Width - rect.Height;

            toggleAnim = new Animation();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            toggleAnim.Value = Checked ? togglePosOn : togglePosOff;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);

            Pen TSPen = new Pen(strokeColor, 3);
            Pen TSPenToggle = new Pen(strokeColor, 3);

            GraphicsPath rectGP = RoundedRectange(rect, rect.Height);

            Rectangle rectToggle = new Rectangle((int)toggleAnim.Value, rect.Y, rect.Height, rect.Height);

            graph.DrawPath(TSPen, rectGP);

            if (Checked)
            {
                if (Animator.isWork == false)
                    rectToggle.Location = new Point(togglePosOn, rect.Y);
                //if (rectToggle.Location == new Point(togglePosOn, rect.Y))
                    graph.FillPath(new SolidBrush(backColorOn), rectGP);
            }
            else
            {   
                if (Animator.isWork == false)
                    rectToggle.Location = new Point(togglePosOff, rect.Y);
                   
                //if (rectToggle.Location == new Point(togglePosOff, rect.Y))
                    graph.FillPath(new SolidBrush(BackColor), rectGP);
            }

            graph.DrawEllipse(TSPenToggle, rectToggle);
            graph.FillEllipse(new SolidBrush(Color.White), rectToggle);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            rect = new Rectangle(1, 1, Width - 3, Height - 3);
            togglePosOff = rect.X;
            togglePosOn = rect.Width - rect.Height;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            SwitchToggle();
        }

        private void SwitchToggle()
        {
            if (Checked)
                toggleAnim = new Animation("Toggle_" + Handle, Invalidate, toggleAnim.Value, togglePosOff);
            else
                toggleAnim = new Animation("Toggle_" + Handle, Invalidate, toggleAnim.Value, togglePosOn);

            Checked = !Checked;

            toggleAnim.stepDivider = 7;
            Animator.Request(toggleAnim, true);
        }

        private GraphicsPath RoundedRectange(Rectangle rect, int roundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, roundSize, roundSize, 180, 90);
            gp.AddArc(rect.X + rect.Width - roundSize, rect.Y, roundSize, roundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - roundSize, rect.Y + rect.Height - roundSize, roundSize, roundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - roundSize, roundSize, roundSize, 90, 90);

            gp.CloseFigure();

            return gp;
        }
    }
}
