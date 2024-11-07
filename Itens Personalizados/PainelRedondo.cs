using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

[ToolboxItem(true)]
public class RoundPanel : Panel
{
    private int borderRadius = 20;
    private float opacity = 0.5f; // Valor de opacidade padrão (0.0f a 1.0f)

    // Propriedade BorderRadius
    [Category("Appearance")]
    public int BorderRadius
    {
        get { return borderRadius; }
        set { borderRadius = value; Invalidate(); } // Redesenha o painel quando a borda é alterada
    }

    // Propriedade Opacity
    [Category("Appearance")]
    [Description("The opacity of the panel.")]
    public float Opacity
    {
        get { return opacity; }
        set
        {
            if (value < 0.0f) value = 0.0f;
            if (value > 1.0f) value = 1.0f;
            opacity = value;
            Invalidate(); // Redesenha o painel quando a opacidade é alterada
        }
    }

    // Sobrescreve o método OnPaint para desenhar o painel com bordas arredondadas
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
            path.AddArc(new Rectangle(Width - borderRadius, Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, Height - borderRadius, borderRadius, borderRadius), 90, 90);
            path.CloseAllFigures();

            // Define a região do painel com base no caminho
            this.Region = new Region(path);

            // Cria uma cor com opacidade
            Color fillColor = Color.FromArgb((int)(opacity * 255), this.BackColor);
            using (Brush brush = new SolidBrush(fillColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Desenha a borda, se necessário
            using (Pen pen = new Pen(Color.Black)) // Ajuste a cor da borda se necessário
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    // Adiciona um método Dispose para limpar recursos
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            // Liberar recursos gerenciados, se necessário
        }
        base.Dispose(disposing);
    }
}