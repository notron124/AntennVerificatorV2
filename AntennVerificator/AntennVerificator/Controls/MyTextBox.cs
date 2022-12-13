using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace AntennVerificator
{
    public class MyTextBox : Control
    {
        #region -- Variables --
        StringFormat SF = new StringFormat();

        int topBorderOffset = 0;

        TextBox tbInput = new TextBox();

        Animation LocationTextPreviewAnim = new Animation();
        Animation FontSizeTextPreviewAnim = new Animation();
        #endregion

        #region -- Properties --
        public string TextPreview { get; set; } = "Input Text";
        public Font fontTextPreview { get; set; } = new Font("Arial", 8, FontStyle.Bold);
        public Font FontTextPreview
        {
            get => fontTextPreview;
            set
            {
                // Ограничение, чтобы размер шрифта заголовка нельзя было установить больше, 
                // чем размер основного шрифта
                if (value.Size >= Font.Size)
                    return;
                fontTextPreview = value;
            }
        }
        public Color BorderColor { get; set; } = Color.Blue;
        public Color BorderColorNotActive { get; set; } = Color.DarkBlue;

        public string TextInput
        {
            get => tbInput.Text;
            set
            {
                tbInput.Text = value;
                Refresh();
            }
        }

        public new string Text 
        { get => tbInput.Text; 
            set
            {
                tbInput.Text = value;
                Refresh();
            }
        }
        #endregion

        #region -- Events --
        [Browsable(true)]
        public new event EventHandler TextChanged
        {
            add { tbInput.TextChanged += value; }
            remove { tbInput.TextChanged -= value; }
        }
        #endregion

        public MyTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(150, 40);
            Font = new Font("Arial", 11.25F, FontStyle.Regular);
            ForeColor = Color.Black;
            BackColor = Color.White;

            Cursor = Cursors.IBeam;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;

            AdjustTextBoxInput();
            Controls.Add(tbInput);

            LocationTextPreviewAnim.Value = tbInput.Location.Y;
            FontSizeTextPreviewAnim.Value = Font.Size;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            TextPreviewAction(TextInput.Length > 0);
        }

        private void AdjustTextBoxInput()
        {
            tbInput = new TextBox
            {
                Name = "InputBox",
                BorderStyle = BorderStyle.None,
                BackColor = BackColor,
                ForeColor = ForeColor,
                Font = Font
            };
            tbInput.Visible = false;

            int offset = TextRenderer.MeasureText(TextPreview, FontTextPreview).Height / 2;
            tbInput.Location = new Point(5, Height / 2 - offset);
            tbInput.Size = new Size(Width - 10, tbInput.Height);

            tbInput.LostFocus += TbInputLostFocus;
        }

        private void TbInputLostFocus(object sender, EventArgs e)
        {
            TextPreviewAction(false); 
        }

        #region -- Properties Update --
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            tbInput.BackColor = BackColor;
        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            tbInput.ForeColor = ForeColor;
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            tbInput.Font = Font;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            tbInput.Size = new Size(Width - 10, tbInput.Height);
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);

            topBorderOffset = graph.MeasureString(TextPreview, FontTextPreview).ToSize().Height / 2;

            Font FontTextPreviewActual = new Font(FontTextPreview.FontFamily, FontSizeTextPreviewAnim.Value, FontTextPreview.Style);

            if (tbInput.Visible == false && FontTextPreviewActual.Size <= FontTextPreview.Size)
            {
                tbInput.Visible = true;
                tbInput.Focus();
            }
            else if (tbInput.Visible == true && FontTextPreviewActual.Size > FontTextPreview.Size)
                tbInput.Visible = false;

            Rectangle rectBase = new Rectangle(0, topBorderOffset, Width - 1, Height - 1 - topBorderOffset);

            Size TextPreviewRectSize = graph.MeasureString(TextPreview, FontTextPreviewActual).ToSize();
            Rectangle rectTextPreview = new Rectangle(5, (int)LocationTextPreviewAnim.Value, TextPreviewRectSize.Width + 3, TextPreviewRectSize.Height);

            //Stroke
            graph.DrawRectangle(new Pen(tbInput.Focused == true ? BorderColor : BorderColorNotActive), rectBase);

            //Header/Discription
            graph.DrawRectangle(new Pen(Parent.BackColor), rectTextPreview);
            graph.FillRectangle(new SolidBrush(Parent.BackColor), rectTextPreview);

            //Back
            graph.FillRectangle(new SolidBrush(BackColor), rectBase);

            graph.DrawString(TextPreview, FontTextPreviewActual, new SolidBrush(tbInput.Focused == true ? BorderColor : BorderColorNotActive), rectTextPreview, SF);
        }

        private void TextPreviewAction(bool onTop)
        {
            if (onTop)
            {
                if (tbInput.Visible == false)
                {
                    LocationTextPreviewAnim = new Animation("TextPreviewLocation" + Handle, Invalidate, LocationTextPreviewAnim.Value, 10);
                    FontSizeTextPreviewAnim = new Animation("TextPreviewFontSize" + Handle, Invalidate, FontSizeTextPreviewAnim.Value, FontTextPreview.Size);
                }
                else
                {
                    tbInput.Focus();
                    return;
                }
            }
            else
            {
                if (TextInput.Length == 0)
                {
                    LocationTextPreviewAnim = new Animation("TextPreviewLocation" + Handle, Invalidate, LocationTextPreviewAnim.Value, tbInput.Location.Y);
                    FontSizeTextPreviewAnim = new Animation("TextPreviewFontSize" + Handle, Invalidate, FontSizeTextPreviewAnim.Value, Font.Size);
                }
                else
                    return;
            }

            LocationTextPreviewAnim.stepDivider = 4;
            FontSizeTextPreviewAnim.stepDivider = 4;

            Animator.Request(LocationTextPreviewAnim, true);
            Animator.Request(FontSizeTextPreviewAnim, true);
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            TextPreviewAction(true);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            TextPreviewAction(true);
        }
    }
}
