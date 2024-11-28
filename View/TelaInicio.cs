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
    public partial class Tela_Inicio : Form
    {
        private Mostrar_forms mostrar;


        public Tela_Inicio()
        {
            InitializeComponent();
            mostrar = new Mostrar_forms();
            Bt_Produto.Enabled = false;
            Bt_Historico.Enabled = false;
            Bt_Fale.Enabled = false;
   
        }

        private void Bt_Login_Click(object sender, EventArgs e)
        {
            mostrar.Fecha_Form();
            Tela_de_Login telaL = new Tela_de_Login(PainelForm, this);
            mostrar.mostrarForm(telaL,PainelForm);
            Bt_Inicio.ForeColor = Color.White;
            Bt_Login.ForeColor = Color.Yellow;
            Bt_Forn.ForeColor = Color.White;
            Bt_Produto.ForeColor = Color.White;
            Bt_Historico.ForeColor = Color.White;
            Bt_Fale.ForeColor = Color.White;
            
            
        }

        private void Bt_Forn_Click(object sender, EventArgs e)
        {
            mostrar.Fecha_Form();
            Cadastro_de_Fornecedor cadastoF = new Cadastro_de_Fornecedor();
            mostrar.mostrarForm(cadastoF, PainelForm);
            Bt_Inicio.ForeColor = Color.White;
            Bt_Login.ForeColor = Color.White;
            Bt_Forn.ForeColor = Color.Yellow;
            Bt_Produto.ForeColor = Color.White;
            Bt_Historico.ForeColor = Color.White;
            Bt_Fale.ForeColor = Color.White;
        }

        private void Bt_Produto_Click(object sender, EventArgs e)
        {
            Cadastro_de_Produto cadastroP = new Cadastro_de_Produto();
            mostrar.mostrarForm(cadastroP, PainelForm);
            Bt_Inicio.ForeColor = Color.White;
            Bt_Login.ForeColor = Color.White;
            Bt_Forn.ForeColor = Color.White;
            Bt_Produto.ForeColor = Color.Yellow;
            Bt_Historico.ForeColor = Color.White;
            Bt_Fale.ForeColor = Color.White;
        }

        private void Bt_Historico_Click(object sender, EventArgs e)
        {
            Historico_de_transacao historico = new Historico_de_transacao();
            mostrar.mostrarForm(historico, PainelForm);
            Bt_Inicio.ForeColor = Color.White;
            Bt_Login.ForeColor = Color.White;
            Bt_Forn.ForeColor = Color.White;
            Bt_Produto.ForeColor = Color.White;
            Bt_Historico.ForeColor = Color.Yellow;
            Bt_Fale.ForeColor = Color.White;

        }

        private void Bt_Inicio_Click(object sender, EventArgs e)
        {
            mostrar.Fecha_Form();
            Bt_Inicio.ForeColor = Color.Yellow;
            Bt_Login.ForeColor = Color.White;
            Bt_Forn.ForeColor = Color.White;
            Bt_Produto.ForeColor = Color.White;
            Bt_Historico.ForeColor = Color.White;
            Bt_Fale.ForeColor = Color.White;

        }

        private void Bt_Fale_Click(object sender, EventArgs e)  
        {
            Fale_conosco fale = new Fale_conosco();
            mostrar.mostrarForm(fale, PainelForm);
            Bt_Inicio.ForeColor = Color.White;
            Bt_Login.ForeColor = Color.White;
            Bt_Forn.ForeColor = Color.White;
            Bt_Produto.ForeColor = Color.White;
            Bt_Historico.ForeColor = Color.White;
            Bt_Fale.ForeColor = Color.Yellow;
        }
    }
    
}
