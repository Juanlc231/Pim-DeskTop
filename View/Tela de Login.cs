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
    public partial class Tela_de_Login : Form
    {
        private Panel painelpai;
        private Tela_Inicio telaInicio; //adicionando referencia a tela inicial
        Validacao validacao = new Validacao(); // validacao de campos
        public Tela_de_Login(Panel painel, Tela_Inicio telaInicio)
        {
            InitializeComponent();
            painelpai = painel; 
            this.telaInicio = telaInicio;
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
            this.Close();
        }

        private void Bt_Entrar_Click(object sender, EventArgs e)
        {
            
            Login log = new Login() ; //comando de busca de Login
            log.Logi(TextBox_Usuario.Texts, TextBox_Email.Texts, Textbox_Senha.Texts); //realiza a busca no banco de dados
            if (log.Val() == true) //apos a validacao da classe de busca de login
            {
                telaInicio.Bt_Produto.Enabled = true;
                telaInicio.Bt_Historico.Enabled = true;
                telaInicio.Bt_Fale.Enabled = true;
                this.Close();
            }
            
        }
    }
}
