using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public partial class RoundedComboBoxControl : UserControl
{
    public RoundedComboBoxControl()
    {
        InitializeComponent();
        this.Size = new Size(150, 30);
        comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.FlatStyle = FlatStyle.Flat;
        comboBox1.DrawItem += comboBox1_DrawItem;
        comboBox1.Location = new Point(0, 0);
        comboBox1.Size = this.ClientSize;
        comboBox1.Location = new Point(0, 0); // Ajuste aqui para mover a ComboBox
        comboBox1.Size = new Size(this.ClientSize.Width - 10, this.ClientSize.Height - 10); // Tamanho ajustado
    }

    public ComboBox.ObjectCollection Items => comboBox1.Items;

    private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
    {
        e.DrawBackground(); // Desenha o fundo

        if (e.Index < 0) return;

        // Desenha a seleção
        Color backgroundColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.Transparent: Color.Transparent;
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(comboBox1.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(comboBox1.Width - 20, comboBox1.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, comboBox1.Height - 20, 20, 20, 90, 90);
            path.CloseFigure();

            e.Graphics.FillPath(new SolidBrush(backgroundColor), path); // Preenche com a cor do fundo
            e.Graphics.DrawString(comboBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
        }

        e.DrawFocusRectangle(); // Desenha o retângulo de foco
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(Width - 20, Height - 20, 20, 20, 0, 90);
            path.AddArc(0, Height - 20, 20, 20, 90, 90);
            path.CloseFigure();
            e.Graphics.FillPath(Brushes.White, path);
        }

        if (comboBox1.SelectedItem != null)
        {
            e.Graphics.DrawString(comboBox1.SelectedItem.ToString(), comboBox1.Font, Brushes.White, new PointF(5, (comboBox1.Height - comboBox1.Font.Height) / 2));
        }
    }
}