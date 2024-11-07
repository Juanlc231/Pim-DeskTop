using Pim_de_Fato.Controller;
using Pim_de_Fato.Itens_Personalizados;
using Pim_de_Fato.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_de_Fato.Model
{
    public static class Validacao
    {

        public static bool validaEmail (String email)
        {
            try
            {
                var enderecoEmail = new System.Net.Mail.MailAddress(email);
                return enderecoEmail.Address == (email);

            }
            catch
            {

                MessageBox.Show("Email invalido", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public static bool ValidaNome(String nome)
        {

            try
            {
                return !string.IsNullOrWhiteSpace(nome);
            }
            catch 
            {
                MessageBox.Show("Digite um nome Valido.", "Nome Invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return false;
                
            }
        }

        public static bool validaTelefone(String telefone) 
        {
            try
            { 
                string padrao = @"^\+?\d{1,3}?[-. ]?\(?\d{1,4}?\)?[-. ]?\d{1,4}[-. ]?\d{1,9}$";
                 return Regex.IsMatch(telefone, padrao);
               
            }
            catch 
            {
                MessageBox.Show("Erro ao colocar telefone invalido", "Telefone Invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
                
            }
        }
    }
}
