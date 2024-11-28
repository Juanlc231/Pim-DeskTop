using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pim_de_Fato.Itens_Personalizados
{
    public partial class TextBoxMasck : UserControl
    {
        // Propriedades do controle
        private Color borderColor = Color.Yellow;
        private Color borderFocusColor = Color.Orange;
        private int borderSize = 2;
        private bool isFocused = false;
        private int borderRedonda = 15; // Raio de borda arredondada

        // Construtor
        public TextBoxMasck()
        {
            InitializeComponent();
            maskedTextBox1.Mask = "00/00/0000"; // Máscara padrão (exemplo)
            maskedTextBox1.TextChanged += (s, e) => OnTextChanged();
            maskedTextBox1.Enter += (s, e) => OnFocusEnter();
            maskedTextBox1.Leave += (s, e) => OnFocusLeave();
        }

        private void OnTextChanged()
        {
            TextChanged?.Invoke(this, EventArgs.Empty);
        }

        private void OnFocusLeave()
        {
            isFocused = false;
            this.Invalidate(); // Recria o controle quando o foco é perdido
        }

        private void OnFocusEnter()
        {
            isFocused = true;
            this.Invalidate(); // Recria o controle quando o foco é dado

            // Usando o método Select() para garantir que o cursor está no início
            maskedTextBox1.Select(0, 0); // Coloca o cursor à extrema esquerda

            // Garantindo que o foco foi corretamente aplicado
            maskedTextBox1.Focus();
        }

        // Evento de texto alterado
        public event EventHandler TextChanged;

        // Propriedades
        [Category("Itens Do Pim")]
        public string Mask
        {
            get { return maskedTextBox1.Mask; }
            set { maskedTextBox1.Mask = value; }
        }

        [Category("Itens Do Pim")]
        public string Text
        {
            get { return maskedTextBox1.Text; }
            set
            {
                maskedTextBox1.Text = value;
                maskedTextBox1.SelectionStart = 0; // Garante que o cursor esteja no início
                maskedTextBox1.SelectionLength = 0; // Garante que não haja seleção
            }
        }

        [Category("Itens Do Pim")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate(); // Força a recriação da borda
            }
        }

        [Category("Itens Do Pim")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set
            {
                borderFocusColor = value;
                this.Invalidate(); // Força a recriação da borda
            }
        }

        [Category("Itens Do Pim")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate(); // Força a recriação da borda
            }
        }

        [Category("Itens Do Pim")]
        public int BorderRedonda
        {
            get { return borderRedonda; }
            set
            {
                borderRedonda = value;
                this.Invalidate(); // Força a recriação da borda
            }
        }

        [Category("Itens Do Pim")]
        public void LimparTexto()
        {
            // Limpa o texto da TextBox
            maskedTextBox1.Clear();
        }

        // Métodos de controle de foco

        private void OnFocusLeave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate(); // Recria o controle quando o foco é perdido
        }


        // Sobrescrita do método OnPaint para customizar a borda
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRedonda > 1) // Borda arredondada
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRedonda))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRedonda - BorderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, BorderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (isFocused) penBorder.Color = borderFocusColor;

                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
            else // Borda normal
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        // Método auxiliar para definir a região arredondada
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

        // Sobrescrita do método OnResize para garantir o ajuste da altura do controle
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        // Sobrescrita do método OnLoad para inicializar o controle no momento de carregamento
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        // Atualiza a altura do controle (sem multiline)
        private void UpdateControlHeight()
        {
            int txtHeight = TextRenderer.MeasureText("Texto", this.Font).Height + 1;
            this.Height = txtHeight + this.Padding.Top + this.Padding.Bottom;
        }
    }
}
