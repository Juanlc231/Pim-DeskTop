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
    public partial class TextRedonda : UserControl
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
        private bool isNumero = false;
        



        //Construcao
        public TextRedonda()
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
        }  //codigo de cor das bordas
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
        } //codigo de tamanho das bordas
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
        }   //codigo para sublinhar as escritas de texto da textbox

        [Category("Itens Do Pim")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
            }
        } //codigo para ocultar as escritas de texto da textbox

        [Category("Itens Do Pim")]
        public bool Multileine
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        } //codigo para textbox aceitar multiline

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
                textBox1.BackColor = value;
            }
        } //codigo para cor de fundo da textbox

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
                textBox1.ForeColor = value;
            }
        } //codigo para cor de texto da textbox

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
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        } //codigo para font de texto da textbox

        [Category("Itens Do Pim")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return textBox1.Text;

            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        } //codigo para texto da textbox

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
        } //codigo para o foco das bordas arredondadas da textbox

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
        } //codigo para as bordas arredondadas da textbox

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
                    textBox1.ForeColor = value;
            }
        } //codigo para a cor do texto de fundo da textbox

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
                textBox1.Text = "";
                SetPlaceholder();
            }
        } //codigo para texto de fundo de textbox

        [Category("Itens Do Pim")]
        public bool IsNumero
        {
            get
            {
                return isNumero;
            }
            set
            {
                isNumero = value;

            }
        } //codigo para aceitar somente numeros

        [Category("Itens Do Pim")]
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }

        [Category("Itens Do Pim")]
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }

        [Category("Itens Do Pim")]
        public void LimparTexto()
        {
   
            textBox1.Clear();
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
                pathText = GetFigurePath(textBox1.ClientRectangle, borderRedonda - borderSize);
                textBox1.Region = new Region(pathText);
            }
            else
            {
                pathText = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathText);
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
            if (textBox1.Multiline == false)
            {
                int txtAltura = TextRenderer.MeasureText("Texto", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtAltura);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;

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
            this.Invalidate(); //entarda de foco na textbox
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate(); // saida de foco de textbox
            SetPlaceholder();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNumero == true)
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar)) // aceita somente numeros e pontos
                {
                    e.Handled = true; 
                }
            }
        }
    }
}
