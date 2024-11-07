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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pim_de_Fato.Itens_Personalizados
{
    [DefaultEvent("_TexteChanged")]
    public partial class TextBoxMasck: UserControl
    {
        //Protegidos
        private Color borderColor = Color.Yellow;
        private Color borderFocusColor = Color.Orange;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private bool isFocused = false;

        private int borderRedonda = 15;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        private string Mask;

        //Construcao
        public TextBoxMasck()
        {
            InitializeComponent();
        }

        //Eventos
        public event EventHandler _TexteChanged;

        //Propiedades
        [Category("Itens Do Pim")]
        public Color BoderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Itens Do Pim")]
        public int BoderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Itens Do Pim")]
        public bool UnderlineStyle
        {
            get
            {
                return underlineStyle;
            }
            set
            {
                underlineStyle = value;
                this.Invalidate();
            }
        }

        [Category("Itens Do Pim")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                maskedTextBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("Itens Do Pim")]
        public bool Multileine
        {
            get { return maskedTextBox1.Multiline; }
            set { maskedTextBox1.Multiline = value; }
        }

        [Category("Itens Do Pim")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                maskedTextBox1.BackColor = value;
            }
        }

        [Category("Itens Do Pim")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                maskedTextBox1.ForeColor = value;
            }
        }

        [Category("Itens Do Pim")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                maskedTextBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Itens Do Pim")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return maskedTextBox1.Text;

            }
            set
            {
                maskedTextBox1.Text = value;
                SetPlaceholder();
            }
        }

        [Category("Itens Do Pim")]
        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
                this.Invalidate();
            }
        }

        [Category("Itens Do Pim")]
        public int BorderRedonda
        {
            get
            {
                return borderRedonda;
            }
            set
            {
                if (value >= 0)
                {
                    borderRedonda = value;
                    this.Invalidate();//redesenhando controle
                }

            }
        }

        [Category("Itens Do Pim")]
        public Color PlaceholderColor
        {
            get
            {
                return placeholderColor;
            }
            set
            {
                placeholderColor = value;
                if (isPasswordChar)
                    maskedTextBox1.ForeColor = value;
            }
        }

        [Category("Itens Do Pim")]
        public string PlaceholderText
        {
            get
            {
                return placeholderText;
            }
            set
            {
                placeholderText = value;
                maskedTextBox1.Text = "";
                SetPlaceholder();
            }
        }

        public string Mask1
        {
            get
            {  
                return maskedTextBox1.Mask;
            }
            set 
            {  
                maskedTextBox1.Mask = value;
                this.Invalidate();
            }
        }

        [Category("Itens Do Pim")]
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                maskedTextBox1.Text = placeholderText;
                maskedTextBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    maskedTextBox1.UseSystemPasswordChar = false;
            }
        }

        [Category("Itens Do Pim")]
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                maskedTextBox1.Text = "";
                maskedTextBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    maskedTextBox1.UseSystemPasswordChar = true;
            }
        }


        //Metodos Overriden
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRedonda > 1) // textBox redonda
            {
                //protegidos
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRedonda))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRedonda - BoderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, BoderSize))
                {
                    //desenhando a borda
                    this.Region = new Region(pathBorderSmooth);//definindo a regiao redonda do controle do usuario
                    if (borderRedonda > 15) SetTextBoxRoundedRegion();//definindo a regiao redonda do componente TextBox
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlineStyle)//estilo de linha
                    {
                        //desenhando a borada suavizada
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //desenhando a borada 
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else // estilo normal
                    {
                        //desenhando a borada suavizada
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //desenhando a borada 
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Textbox, Normal
            {
                using (Pen penBorder = new Pen(borderColor, borderSize)) //Desenhando a borda
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlineStyle) //estilo de linha
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);

                    else // estilo normal
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathText;
            if (Multileine)
            {
                pathText = GetFigurePath(maskedTextBox1.ClientRectangle, borderRedonda - borderSize);
                maskedTextBox1.Region = new Region(pathText);
            }
            else
            {
                pathText = GetFigurePath(maskedTextBox1.ClientRectangle, borderSize * 2);
                maskedTextBox1.Region = new Region(pathText);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;

        }



        //Metodods Privados
        private void UpdateControlHeight()
        {
            if (maskedTextBox1.Multiline == false)
            {
                int txtAltura = TextRenderer.MeasureText("Texto", this.Font).Height + 1;
                maskedTextBox1.Multiline = true;
                maskedTextBox1.MinimumSize = new Size(0, txtAltura);
                maskedTextBox1.Multiline = false;

                this.Height = maskedTextBox1.Height + this.Padding.Top + this.Padding.Bottom;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TexteChanged != null)
                _TexteChanged.Invoke(sender, e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
    }
}
