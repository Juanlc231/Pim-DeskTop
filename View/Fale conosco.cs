using Pim_de_Fato.Controller;
using Pim_de_Fato.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pim_de_Fato.View 
{
    public partial class Fale_conosco : Form
    {
        int con  = 0; // contador para a imagem de estrela
        int con1 = 0; // contador para a imagem de estrela
        int con2 = 0; // contador para a imagem de estrela
        int con3 = 0; // contador para a imagem de estrela
        int con4 = 0; // contador para a imagem de estrela
        public Fale_conosco()
        {
            InitializeComponent();
        }
        private void ExibirEmails(List<string> emails)
        {
            int panelIndex = 0;

            Label numeroLabel = this.Controls["numeros"] as Label;
            if (numeroLabel != null)
            {
                numeroLabel.Text = $"Total de e-mails: {emails.Count}"; // Atualiza o texto com a contagem
            }

            foreach (var email in emails)
            {
                if (panelIndex >= 5) // Limitar a 5 painéis
                    break;

               
                var panel = this.Controls["Local_Text" + (panelIndex > 0 ? panelIndex.ToString() : "")] as Panel;

                if (panel != null)
                {
                    Label emailLabel = new Label
                    {

                        Text = "Nova Mensagem de: " + email,
                        AutoSize = true,
                        Location = new Point(75, panel.Controls.Count * 8), // Exibir em linhas
                        ForeColor = Color.Black,
                        BackColor = Color.White,
                        Padding = new Padding(5),
                        Font = new Font("Consolas", 18, FontStyle.Regular)
                    };

                    panel.Controls.Add(emailLabel);
                }

                panelIndex++;
                
                
            }
        }

        private void Fale_conosco_Load(object sender, EventArgs e)
        {

            // Configurar o controlador com a conexão e o modelo de busca
            Conexao conexao = new Conexao();
            BuscaBanco buscaBanco = new BuscaBanco(conexao);
            EmailControler controller = new EmailControler(buscaBanco);

            // Obter os e-mails do controlador e exibi-los
            List<string> emails = controller.ObterEmails();
            ExibirEmails(emails);

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con ++;
            if (con > 0 && con < 2 ) // a estrela, sei q é uma gambiarra, mas e o melhor jeito q eu arrumei no momento
            {
                pictureBox2.Image = Properties.Resources.estrela_amarela;
               
            }
            else if(con > 1)
            {
                pictureBox2.Image = Properties.Resources.estrela_removebg_preview;
                con = 0;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            con1++;
            if (con1 > 0 && con1 < 2) //estrela 2
            {
                pictureBox3.Image = Properties.Resources.estrela_amarela;
            }
            else if (con1 > 1)
            {
                pictureBox3.Image = Properties.Resources.estrela_removebg_preview;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con2++;
            if (con2 > 0 && con2 < 2) // estrela 3
            {
                pictureBox4.Image = Properties.Resources.estrela_amarela;
            }
            else if (con2 > 1)
            {
                pictureBox4.Image = Properties.Resources.estrela_removebg_preview;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            con++;
            if (con3 > 0 && con3 < 2) // estrela 4
            {
                pictureBox5.Image = Properties.Resources.estrela_amarela;
            }
            else if (con3 > 1)
            {
                pictureBox5.Image = Properties.Resources.estrela_removebg_preview;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)

        {
            con++;
            if (con4 > 0 && con4 < 2) //estrela 5
            {
                pictureBox6.Image = Properties.Resources.estrela_amarela;
            }
            else if (con4 > 1)
            {
                pictureBox6.Image = Properties.Resources.estrela_removebg_preview;
            }
        }
    }
    
}