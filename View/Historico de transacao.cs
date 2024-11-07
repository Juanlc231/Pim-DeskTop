using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pim_de_Fato.View
{
    public partial class Historico_de_transacao : Form
    {
        private Panel panel;
        private Chart chart;
        private int con = 0;

        public Historico_de_transacao()
        {
            InitializeComponent();
            configuracao();
        }

        private void configuracao()
        {


            this.Text = "Gráfico de Colunas com Fundo Transparente";
            this.Size = new Size(1500, 900);
            this.BackColor = Color.White; // Cor de fundo do formulário

            // Inicializar o painel
            panel = new Panel
            {
                Size = new Size(920, 700), // Tamanho do painel
                Location = new Point(300, 100), // Posição do painel
                BackColor = Color.Transparent // Fundo do painel transparente
            };
            this.Controls.Add(panel);

            // Inicializar e configurar o gráfico
            chart = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent, // Fundo do gráfico transparente
                BorderlineColor = Color.Transparent // Borda do gráfico transparente
            };
            panel.Controls.Add(chart);

            // Criar área do gráfico
            ChartArea chartArea = new ChartArea
            {
                BackColor = Color.Transparent // Fundo da área do gráfico transparente
            };
            chart.ChartAreas.Add(chartArea);

            chartArea.AxisY.MajorGrid.LineColor = Color.Black; // Cor das linhas horizontais
            chartArea.AxisY.MajorGrid.Enabled = true; // Ativar linhas horizontais
            chartArea.AxisX.MajorGrid.Enabled = false; // Desativar linhas verticais

            chartArea.AxisY.Maximum = 3500; // Limite máximo do eixo Y

            // Criar série de dados
            Series series = new Series
            {
                Name = "Série1",
                Color = Color.Green,
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Column
            };

            // Adicionar pontos à série
            series.Points.AddXY("Janeiro", 2000);
            series.Points.AddXY("Fevereiro", 1800);
            series.Points.AddXY("Março", 2200);
            series.Points.AddXY("Abril", 2900);
            chart.Series.Add(series);
            Seta1.Hide();
     
        }

        private void Bt_Download_MouseEnter(object sender, EventArgs e)
        {
            Bt_Download.ForeColor = Color.Yellow;

        }
        private void Bt_Download_MouseLeave(object sender, EventArgs e)
        {
            Bt_Download.ForeColor= Color.White;
        }
        private void Bt_Compartilhar_MouseEnter(object sender, EventArgs e)
         {
            Bt_Compartilhar.ForeColor = Color.Yellow;
         }
        private void Bt_Compartilhar_MouseLeave(object sender, EventArgs e)
        {
            Bt_Compartilhar.ForeColor= Color.White;
        }
        private void Bt_Gerenciar_MouseEnter(object sender, EventArgs e)
        {
            Bt_Gerenciar.ForeColor= Color.Yellow;
        }
        private void Bt_Gerenciar_MouseLeave(object sender, EventArgs e)
        {
            Bt_Gerenciar.ForeColor = Color.White;
        }

        private void Seta2_Click(object sender, EventArgs e)
        {
            con++;
            chart.Series["Série1"].Points.Clear();
            switch (con)
            {
                case 0:
                    Seta2.Show();
                    chart.Series["Série1"].Points.AddXY("Janeiro", 2000);
                    chart.Series["Série1"].Points.AddXY("Fevereiro", 1800);
                    chart.Series["Série1"].Points.AddXY("Março", 2200);
                    chart.Series["Série1"].Points.AddXY("Abril", 2900);
                    Seta1.Hide();
                    break;

                case 1:
            
                 Seta2.Show();
                chart.Series["Série1"].Points.AddXY("Maio", 1100);
                chart.Series["Série1"].Points.AddXY("Junho", 2100);
                chart.Series["Série1"].Points.AddXY("Julho", 2560);
                chart.Series["Série1"].Points.AddXY("Agosto", 1750);
                    Seta1.Show();
                break;
                
                    case 2:

                     // Adiciona novos dados à série
                    chart.Series["Série1"].Points.AddXY("Setembro", 2050);
                    chart.Series["Série1"].Points.AddXY("Outubro", 2910);
                    chart.Series["Série1"].Points.AddXY("Novembro", 2980);
                    chart.Series["Série1"].Points.AddXY("Desembro", 3000);
                    Seta1.Show();
                    break;
            }
            
            if (con == 2)
                Seta2.Hide();


        }

        private void Seta1_Click(object sender, EventArgs e)
        {
            con--;
             chart.Series["Série1"].Points.Clear();

            if (con == -1)
            {
                con = 0;
            }
            if (con == 2)
            {
                Seta1.Show();
                chart.Series["Série1"].Points.AddXY("Setembro", 2050);
                chart.Series["Série1"].Points.AddXY("Outubro", 2910);
                chart.Series["Série1"].Points.AddXY("Novembro", 2980);
                chart.Series["Série1"].Points.AddXY("Desembro", 3000);
                Seta2.Hide();
                
            }
            else if (con == 1)
            {
                Seta1.Show();
                chart.Series["Série1"].Points.AddXY("Maio", 1100);
                chart.Series["Série1"].Points.AddXY("Junho", 2100);
                chart.Series["Série1"].Points.AddXY("Julho", 2560);
                chart.Series["Série1"].Points.AddXY("Agosto", 1750);
                Seta2.Show();
                
            }
            else if (con == 0 || con == -1)
            {
                Seta1.Hide();
                chart.Series["Série1"].Points.AddXY("Janeiro", 2000);
                chart.Series["Série1"].Points.AddXY("Fevereiro", 1800);
                chart.Series["Série1"].Points.AddXY("Março", 2200);
                chart.Series["Série1"].Points.AddXY("Abril", 2900);
                Seta2.Show();
            }

        }
    }
}
