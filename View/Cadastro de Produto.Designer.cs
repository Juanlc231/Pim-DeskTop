namespace Pim_de_Fato.View
{
    partial class Cadastro_de_Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bt_VoltaProduto = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundPanel1 = new RoundPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox_NomeP = new Pim_de_Fato.Itens_Personalizados.TextRedonda();
            this.roundPanel2 = new RoundPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Textbox_Quantidade = new Pim_de_Fato.Itens_Personalizados.TextRedonda();
            this.Textbox_Valor = new Pim_de_Fato.Itens_Personalizados.TextRedonda();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox_Descri = new Pim_de_Fato.Itens_Personalizados.TextRedonda();
            this.Bt_Cadastrar = new Pim_C_.Itens_Costume.Botao();
            this.Bt_VoltaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bt_VoltaProduto
            // 
            this.Bt_VoltaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bt_VoltaProduto.BackColor = System.Drawing.Color.Transparent;
            this.Bt_VoltaProduto.ColumnCount = 2;
            this.Bt_VoltaProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.Bt_VoltaProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.Bt_VoltaProduto.Controls.Add(this.pictureBox2, 0, 0);
            this.Bt_VoltaProduto.Controls.Add(this.label2, 1, 0);
            this.Bt_VoltaProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_VoltaProduto.Location = new System.Drawing.Point(72, 623);
            this.Bt_VoltaProduto.Name = "Bt_VoltaProduto";
            this.Bt_VoltaProduto.RowCount = 1;
            this.Bt_VoltaProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Bt_VoltaProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Bt_VoltaProduto.Size = new System.Drawing.Size(258, 60);
            this.Bt_VoltaProduto.TabIndex = 5;
            this.Bt_VoltaProduto.Click += new System.EventHandler(this.Bt_VoltaProduto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Pim_de_Fato.Properties.Resources.Seta_amarela_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voltar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.92104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.07896F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1697, 143);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Pim_de_Fato.Properties.Resources.images__1__removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(220, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 143);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundPanel1
            // 
            this.roundPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.roundPanel1.BorderRadius = 60;
            this.roundPanel1.Controls.Add(this.tableLayoutPanel3);
            this.roundPanel1.Controls.Add(this.tableLayoutPanel2);
            this.roundPanel1.Location = new System.Drawing.Point(189, 132);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Opacity = 0.002F;
            this.roundPanel1.Size = new System.Drawing.Size(1343, 465);
            this.roundPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.354244F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.64576F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.tableLayoutPanel3.Controls.Add(this.TextBox_NomeP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.roundPanel2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.Textbox_Quantidade, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Textbox_Valor, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.3131F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.6869F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1343, 332);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // TextBox_NomeP
            // 
            this.TextBox_NomeP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_NomeP.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_NomeP.BoderColor = System.Drawing.Color.Transparent;
            this.TextBox_NomeP.BoderSize = 2;
            this.TextBox_NomeP.BorderFocusColor = System.Drawing.Color.Black;
            this.TextBox_NomeP.BorderRedonda = 15;
            this.TextBox_NomeP.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_NomeP.ForeColor = System.Drawing.Color.Black;
            this.TextBox_NomeP.IsNumero = false;
            this.TextBox_NomeP.Location = new System.Drawing.Point(30, 123);
            this.TextBox_NomeP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_NomeP.Multileine = false;
            this.TextBox_NomeP.Name = "TextBox_NomeP";
            this.TextBox_NomeP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBox_NomeP.PasswordChar = false;
            this.TextBox_NomeP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBox_NomeP.PlaceholderText = "Nome do Produto:";
            this.TextBox_NomeP.Size = new System.Drawing.Size(603, 53);
            this.TextBox_NomeP.TabIndex = 0;
            this.TextBox_NomeP.Texts = "";
            this.TextBox_NomeP.UnderlineStyle = false;
            // 
            // roundPanel2
            // 
            this.roundPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel2.BackColor = System.Drawing.Color.White;
            this.roundPanel2.BorderRadius = 20;
            this.roundPanel2.Controls.Add(this.comboBox1);
            this.roundPanel2.Location = new System.Drawing.Point(30, 292);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Opacity = 0.5F;
            this.roundPanel2.Size = new System.Drawing.Size(603, 37);
            this.roundPanel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Frutas"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(603, 35);
            this.comboBox1.TabIndex = 0;
            // 
            // Textbox_Quantidade
            // 
            this.Textbox_Quantidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Textbox_Quantidade.BackColor = System.Drawing.Color.White;
            this.Textbox_Quantidade.BoderColor = System.Drawing.Color.White;
            this.Textbox_Quantidade.BoderSize = 2;
            this.Textbox_Quantidade.BorderFocusColor = System.Drawing.Color.Black;
            this.Textbox_Quantidade.BorderRedonda = 15;
            this.Textbox_Quantidade.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Quantidade.ForeColor = System.Drawing.Color.Black;
            this.Textbox_Quantidade.IsNumero = true;
            this.Textbox_Quantidade.Location = new System.Drawing.Point(720, 123);
            this.Textbox_Quantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Textbox_Quantidade.Multileine = false;
            this.Textbox_Quantidade.Name = "Textbox_Quantidade";
            this.Textbox_Quantidade.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Textbox_Quantidade.PasswordChar = false;
            this.Textbox_Quantidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Textbox_Quantidade.PlaceholderText = "Quantidade:";
            this.Textbox_Quantidade.Size = new System.Drawing.Size(538, 53);
            this.Textbox_Quantidade.TabIndex = 2;
            this.Textbox_Quantidade.Texts = "";
            this.Textbox_Quantidade.UnderlineStyle = false;
            // 
            // Textbox_Valor
            // 
            this.Textbox_Valor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Textbox_Valor.BackColor = System.Drawing.Color.White;
            this.Textbox_Valor.BoderColor = System.Drawing.Color.White;
            this.Textbox_Valor.BoderSize = 2;
            this.Textbox_Valor.BorderFocusColor = System.Drawing.Color.Black;
            this.Textbox_Valor.BorderRedonda = 15;
            this.Textbox_Valor.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Valor.ForeColor = System.Drawing.Color.Black;
            this.Textbox_Valor.IsNumero = true;
            this.Textbox_Valor.Location = new System.Drawing.Point(720, 275);
            this.Textbox_Valor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Textbox_Valor.Multileine = false;
            this.Textbox_Valor.Name = "Textbox_Valor";
            this.Textbox_Valor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Textbox_Valor.PasswordChar = false;
            this.Textbox_Valor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Textbox_Valor.PlaceholderText = "Valor R$:";
            this.Textbox_Valor.Size = new System.Drawing.Size(538, 53);
            this.Textbox_Valor.TabIndex = 3;
            this.Textbox_Valor.Texts = "";
            this.Textbox_Valor.UnderlineStyle = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.214022F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.78598F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.Controls.Add(this.TextBox_Descri, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1343, 376);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // TextBox_Descri
            // 
            this.TextBox_Descri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Descri.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_Descri.BoderColor = System.Drawing.Color.Transparent;
            this.TextBox_Descri.BoderSize = 2;
            this.TextBox_Descri.BorderFocusColor = System.Drawing.Color.Black;
            this.TextBox_Descri.BorderRedonda = 15;
            this.TextBox_Descri.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Descri.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Descri.IsNumero = false;
            this.TextBox_Descri.Location = new System.Drawing.Point(31, 4);
            this.TextBox_Descri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Descri.Multileine = true;
            this.TextBox_Descri.Name = "TextBox_Descri";
            this.TextBox_Descri.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBox_Descri.PasswordChar = false;
            this.TextBox_Descri.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBox_Descri.PlaceholderText = "Descrição (Max 200):";
            this.TextBox_Descri.Size = new System.Drawing.Size(1231, 313);
            this.TextBox_Descri.TabIndex = 0;
            this.TextBox_Descri.Texts = "";
            this.TextBox_Descri.UnderlineStyle = false;
            // 
            // Bt_Cadastrar
            // 
            this.Bt_Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_Cadastrar.BackColor = System.Drawing.Color.ForestGreen;
            this.Bt_Cadastrar.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.Bt_Cadastrar.BorderColor = System.Drawing.Color.Green;
            this.Bt_Cadastrar.BorderRadius = 38;
            this.Bt_Cadastrar.BorderSize = 0;
            this.Bt_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Cadastrar.FlatAppearance.BorderSize = 0;
            this.Bt_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Cadastrar.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Cadastrar.ForeColor = System.Drawing.Color.Black;
            this.Bt_Cadastrar.Location = new System.Drawing.Point(698, 603);
            this.Bt_Cadastrar.Name = "Bt_Cadastrar";
            this.Bt_Cadastrar.Size = new System.Drawing.Size(316, 52);
            this.Bt_Cadastrar.TabIndex = 6;
            this.Bt_Cadastrar.Text = "Cadastrar";
            this.Bt_Cadastrar.TextColor = System.Drawing.Color.Black;
            this.Bt_Cadastrar.UseVisualStyleBackColor = false;
            this.Bt_Cadastrar.Click += new System.EventHandler(this.Bt_Cadastrar_Click);
            // 
            // Cadastro_de_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pim_de_Fato.Properties.Resources.usuário_novo_desk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1697, 711);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Bt_Cadastrar);
            this.Controls.Add(this.Bt_VoltaProduto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro_de_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_de_Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Bt_VoltaProduto.ResumeLayout(false);
            this.Bt_VoltaProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.roundPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel1;
        private System.Windows.Forms.TableLayoutPanel Bt_VoltaProduto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Pim_C_.Itens_Costume.Botao Bt_Cadastrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Itens_Personalizados.TextRedonda TextBox_NomeP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Itens_Personalizados.TextRedonda TextBox_Descri;
        private RoundPanel roundPanel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Itens_Personalizados.TextRedonda Textbox_Quantidade;
        private Itens_Personalizados.TextRedonda Textbox_Valor;
    }
}
