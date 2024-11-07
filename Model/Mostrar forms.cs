using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_de_Fato.Model
{
    public class Mostrar_forms
    {
        private Form Tela;
        public void mostrarForm(Form Tl, Panel Pai)
        {
            Fecha_Form();
            Tela = Tl;
            Tl.TopLevel = false;
            Pai.Controls.Add(Tl);
            Tl.BringToFront();
            Tl.Show();
        }
        public void Fecha_Form() 
        {
;
            if (Tela != null)
            {
                Tela.Close();
            }
        }
    }
}
