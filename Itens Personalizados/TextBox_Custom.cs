using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pim_C_
{
    [DefaultEvent("_TexteChanged")]
    public partial class TextBoxCostume : UserControl
    {
        //Protegidos

        private Color boderColor = Color.MediumBlue;
        private int boderSize = 2;
        private bool underlineStyle = false;
        private Color borderFocusColor = Color.Transparent;
        private bool isFocused = false;

        //Construcao
        public TextBoxCostume()
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
                return boderColor;
            }

            set
            {
                boderColor = value;
                this.Invalidate();
            }
        }
        [Category("Itens Do Pim")]
        public int BoderSize
        {
            get
            {
                return boderSize;
            }
            set
            {
                boderSize = value;
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
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("Itens Do Pim")]
        public bool Multileine
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
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
                textBox1.BackColor = value;
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
                textBox1.ForeColor = value;
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
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Itens Do Pim")]
        public string Texts
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
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
            }
        }

        //Metodos Overriden

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Desenhando a borda
            using (Pen penBorder = new Pen(boderColor, boderSize))
            {

                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!isFocused)
                {
                    if (underlineStyle) //estilo de linha
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else // estilo normal
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;

                    if (underlineStyle) //estilo de linha
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else // estilo normal
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

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
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
