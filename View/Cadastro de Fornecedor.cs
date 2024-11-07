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
        
        public Cadastro_de_Fornecedor()
        {
            InitializeComponent();
            
        }

        private void Bt_Volta_Click(object sender, EventArgs e)
        {
        }

        private void Bt_Fornecedor_Click(object sender, EventArgs e)
        {
            Cadastro cadas = new Cadastro(TextBox_Nome.Texts, TextBox_Telefone.Texts,TextBox_Email.Texts, TextBox_Data.Texts,TextBox_Cnpj.Texts,TextBox_Endereco.Texts,TextBox_Senha.Texts);                                               
        }
    }
}
