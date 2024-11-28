using Pim_de_Fato.Controller;
using Pim_de_Fato.Model;
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

namespace Pim_de_Fato.View
{
    public partial class Cadastro_de_Produto : Form
    {
        Validacao vali = new Validacao(); // classe de validaco

        public Cadastro_de_Produto()
        {
            InitializeComponent();
        
        }
        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            double QTD = 0;
            double VALOR = 0 ;
            string cate = "";
           


            if (vali.validaProduto(TextBox_NomeP.Texts) && vali.validaQuantidade(QTD) && vali.validaValor(VALOR) && vali.validadeDescri(TextBox_Descri.Texts) == true) //fazendo as valizadações
            {
                if (double.TryParse(Textbox_Valor.Text, out VALOR) && double.TryParse(Textbox_Quantidade.Text, out QTD))
                 cate = comboBox1.SelectedItem.ToString();

                Produto produto = new Produto(TextBox_NomeP.Texts, cate, QTD, VALOR, TextBox_Descri.Texts);
                TextBox_NomeP.LimparTexto();
                TextBox_Descri.LimparTexto();
                Textbox_Valor.LimparTexto();
                Textbox_Quantidade.LimparTexto();

            }
           else 
            {
                MessageBox.Show("Erro ao Cadastrar Produto, reveja os itens", "Erro Cadastro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
           
        } // click do botao q passa pelas validações e salva os dados

        private void Bt_VoltaProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        } //evento q volta para a tela de inicio

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
