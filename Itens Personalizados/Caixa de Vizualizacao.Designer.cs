namespace Pim_C_
{
    partial class CaixaVizualizacao
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaixaVizualizacao));
            this.Vizu = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Vizu
            // 
            this.Vizu.Appearance = System.Windows.Forms.Appearance.Button;
            this.Vizu.BackColor = System.Drawing.Color.Transparent;
            this.Vizu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vizu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Vizu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vizu.ForeColor = System.Drawing.Color.Transparent;
            this.Vizu.Image = ((System.Drawing.Image)(resources.GetObject("Vizu.Image")));
            this.Vizu.Location = new System.Drawing.Point(184, 7);
            this.Vizu.Name = "Vizu";
            this.Vizu.Size = new System.Drawing.Size(50, 20);
            this.Vizu.TabIndex = 0;
            this.Vizu.UseVisualStyleBackColor = false;
            this.Vizu.CheckedChanged += new System.EventHandler(this.Vizu_CheckedChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(10, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 18);
            this.textBox1.TabIndex = 1;
            // 
            // CaixaVizualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Vizu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CaixaVizualizacao";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(244, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Vizu;
        private System.Windows.Forms.TextBox textBox1;
    }
}
