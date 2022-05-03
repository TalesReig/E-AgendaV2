using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTarefas.Dominio
{
    public class Contato : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public Contato()
        {
        }

        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        #region Validações
        public override string Validar()
        {
            string mensagem = "";

            if (ValidarNome(Nome) == false)
                mensagem += "NOME_INVALIDO";

            if (ValidarEmail(Email) == false)
                mensagem += "EMAIL_INVALIDO";

            if (ValidaTelefone(Telefone) == false)
                mensagem += "TELEFONE_INVALIDO";

            if (mensagem != "")
                return mensagem;

            return "REGISTRO_VALIDO";
        }

        private bool ValidarEmail(string email)
        {
            int indexArr = email.IndexOf("@");
            bool EmailValido = false;

            if (indexArr > 0)
                EmailValido = true;

            return EmailValido;
        }

        private bool ValidaTelefone(string Telefone)
        {
            if (Telefone.Length < 14)
                return false;

            return true;
        }

        private bool ValidarNome(string Nome)
        {
            if (String.IsNullOrEmpty(Nome))
                return false;

            return true;
        }

        #endregion

        public override string ToString()
        {
            return $"|Nome: {Nome}|Email: {Email}|Telefone: {Telefone}|Empresa: {Empresa}|Cargo: {Cargo}|";
        }
    }
}
