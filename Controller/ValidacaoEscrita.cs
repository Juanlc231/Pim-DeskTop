using Pim_de_Fato.Controller;
using Pim_de_Fato.Itens_Personalizados;
using Pim_de_Fato.View;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Pim_de_Fato.Model
{
    public class Validacao
    {
        public bool validatelefone(String tele)
        {
            string padraoTelefone = @"^\(\d{2}\)\s\d{5}-\d{4}$";

            Regex regex = new Regex(padraoTelefone);


            return regex.IsMatch(tele);

        }

        public bool validaEmail(String email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                try
                {
                    var enderecoEmail = new System.Net.Mail.MailAddress(email);
                    return enderecoEmail.Address == (email);

                }
                catch (FormatException)
                {

                    return false;
                }
            }
            else
            {
                MessageBox.Show("Email invalido", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public bool ValidaNome(String nome)
        {

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite um nome Valido.", "Nome Invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validaData(String data)
        {
            DateTime dataConvertida;

         
            bool isValida = DateTime.TryParse(data, out dataConvertida);

            if (!isValida)
            {
                MessageBox.Show("Digite uma data válida.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true; 
        }

        public bool validaEndereco(String endereco) 
        {
            if (string.IsNullOrWhiteSpace(endereco))
            {
                MessageBox.Show("Digite um Endereço Valido.", "Endereço Invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validaCnpj (String cnpj) 
        {
            if (string.IsNullOrWhiteSpace(cnpj))
            {
                MessageBox.Show("Digite um CNPJ Valido.", "CNPJ Invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validaSenha(String senha) 
        {
            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Digite uma Senha Valido.", "Senha Invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
           
        }

            // validacao dos produtos
        public bool validaProduto(String produto) 
        {
            if (string.IsNullOrEmpty(produto)) 
            {
                MessageBox.Show("Nome do Produto vazio", "Produto em branco", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return false;
            }
            else 
            {
                return true;
            }
        }

        public bool validaValor(double valor)
        {
            bool isInteger = valor == Math.Floor(valor);

            return isInteger;
        }

        public bool validaQuantidade(double quanti)
        { 
            bool isInteger = quanti == Math.Floor(quanti);

            return isInteger;
        }

        public bool validadeDescri(String descri) 
        {
            if (string.IsNullOrEmpty(descri))
            {
                MessageBox.Show("Descrição Invalida", "Erro Descrição", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validadeCate(String cate) 
        {
            if (string.IsNullOrEmpty(cate)) 
            {
                MessageBox.Show("Categoria invalida", "Erro Categoria", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
