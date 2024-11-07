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
    public partial class Tela_de_Login : Form
    {
        private Panel painelpai;
        public Tela_de_Login(Panel painel)
        {
            InitializeComponent();
            painelpai = painel;
        }
       
       
        private void Bt_Cadastrese_MouseEnter(object sender, EventArgs e) 
        {
            Bt_Cadastrese.ForeColor = Color.Yellow; //muda a cor do Botao
            ToolTip dica = new ToolTip(); //adicion a uma dica apos o mouse ficar um tempo em cima do botao
            dica.AutomaticDelay = 5000; //tempo q ficara exposto 
            dica.InitialDelay = 1000; // tempo necessario q o mouse precisa ficar em cima do botao para aparecer a dica
            dica.SetToolTip(Bt_Cadastrese, "Caso não tenha efetuado cadastro antes.");
        }

        private void Bt_Cadastrese_MouseLeave(object sender, EventArgs e)
        {
            Bt_Cadastrese.ForeColor = Color.White; // volta a cor normal no botao
        }

        private void Bt_Cadastrese_Click(object sender, EventArgs e)
        {
            Cadastro_de_Fornecedor telaC = new Cadastro_de_Fornecedor();
            Mostrar_forms mostrar = new Mostrar_forms();
            mostrar.mostrarForm(telaC, painelpai);
        }
    }
}
