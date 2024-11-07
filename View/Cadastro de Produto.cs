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

namespace Pim_de_Fato.View
{
    public partial class Cadastro_de_Produto : Form
    {
    
        public Cadastro_de_Produto()
        {
            InitializeComponent();
        
        }
        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            double QTD;
            double VALOR;
            string Sele;
            VALOR = Convert.ToDouble(TextBox_Valor.Texts);
            QTD = Convert.ToDouble(TextBox_Quantidade.Texts);
            Sele = comboBox1.SelectedItem.ToString();
            Produto produto = new Produto(TextBox_NomeP.Texts, Sele, QTD, VALOR, TextBox_Descri.Texts);
            
        }
    }
}
