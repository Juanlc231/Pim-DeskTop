using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_de_Fato.Controller
{
    public class EmailControler
    {
        private BuscaBanco _buscaBanco;

        public EmailControler(BuscaBanco buscaBanco)
        {
            _buscaBanco = buscaBanco;
        }

        public List<string> ObterEmails()
        {
            return _buscaBanco.ObterEmails();
        }
    }
}
