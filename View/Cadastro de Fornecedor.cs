using Pim_de_Fato.Controller;
using Pim_de_Fato.Itens_Personalizados;
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

namespace Pim_de_Fato.View
{
    public partial class Cadastro_de_Fornecedor : Form
    {
        Mostrar_forms mostar = new Mostrar_forms();
        Validacao valida = new Validacao();
        
        public Cadastro_de_Fornecedor()
        {
            InitializeComponent();
            
        }

        private void Bt_Volta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_Fornecedor_Click(object sender, EventArgs e)
        {
            string Data;
            string tele;
            Data = textbox_Data.Text.ToString();
            tele = textbox_Telefone.Text.ToString();


            if (valida.ValidaNome(TextBox_Nome.Texts) &&valida.validaEmail(TextBox_Email.Texts) && valida.validaData(Data) && valida.validaCnpj(TextBox_Cnpj.Texts) && valida.validaEndereco(TextBox_Endereco.Texts) && valida.validaSenha(TextBox_Senha.Texts) == true)
            {
                Cadastro cadas = new Cadastro(TextBox_Nome.Texts, tele, TextBox_Email.Texts, Data, TextBox_Cnpj.Texts, TextBox_Endereco.Texts, TextBox_Senha.Texts);
                TextBox_Nome.LimparTexto();
                TextBox_Email.LimparTexto();
                TextBox_Endereco.LimparTexto();
                textbox_Data.LimparTexto();
                textbox_Telefone.LimparTexto();
                TextBox_Cnpj.LimparTexto();
                TextBox_Senha.LimparTexto();
            }
            else 
            {
                MessageBox.Show("Campos não preenchidos corretamente, verifique", "Erro de Cadastro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }                                               
        }

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
