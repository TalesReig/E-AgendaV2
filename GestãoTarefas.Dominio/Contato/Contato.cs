using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTarefas.Dominio.Contato
{
    public class Contato : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DDD { get; set; }
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
        //   public override string ToString()
        //   {
        //       return "\tId: " + id + Environment.NewLine +
        //           "\tNome: " + Nome + Environment.NewLine +
        //           "\tTelefone: " + Telefone + Environment.NewLine +
        //           "\tEmpresa: " + Empresa + Environment.NewLine;
        //   }
        //
        //   public override string Validar()
        //   {
        //       StringBuilder sb = new StringBuilder();
        //
        //       if (string.IsNullOrEmpty(Nome))
        //           sb.AppendLine("O nome do contato é obrigatório!");
        //
        //       if (EmailEstaValido(ValidarEmail) == false)
        //           sb.AppendLine("Insira um endereço de email válido! (Ex: contato@gmail.com)");
        //
        //       if (TelefoneEstaValido() == false)
        //           sb.AppendLine("O número precisa seguir um dos seguintes formatos: 99999-0000 ou 99999 0000 ou 999990000");
        //
        //       if (string.IsNullOrEmpty(Empresa))
        //           sb.AppendLine("O nome da empresa é obrigatório!");
        //
        //       if (string.IsNullOrEmpty(Cargo))
        //           sb.AppendLine("O nome do cargo é obrigatório!");
        //
        //       if (sb.Length == 0)
        //           sb.Append("REGISTRO_VALIDO");
        //
        //       return sb.ToString();
        //   }
        //
        //   private bool EmailEstaValido(Func<bool> validacaoSelecionada)
        //   {
        //       bool emailEstaValido = validacaoSelecionada();
        //
        //       return emailEstaValido;
        //   }
        //
        //   // Validação utilizando uma biblioteca nativa do C#
        //   private bool ValidarEmail()
        //   {
        //       // podemos utilizar o valor discard (representado pelo _ (underscore))
        //       // para descartar argumento out do método
        //       bool emailEstaValido = System.Net.Mail.MailAddress.TryCreate(Email, out _);
        //
        //       return emailEstaValido;
        //   }
        //
        //   // Validação utilizando regular expressions (regEx)
        //   // instruções sobre a regex utilizada:
        //   // > https://docs.microsoft.com/pt-br/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
        //   private bool ValidarEmailRegex()
        //   {
        //       bool emailEstaValido = System.Text.RegularExpressions.Regex.IsMatch(Email, @"^[^@\s] +@[^@\s] +\.[^@\s]+$", RegexOptions.IgnoreCase);
        //
        //       return emailEstaValido;
        //   }
        //
        //   // Validação de telefone utilizando um formato simples de regex
        //   // instruções sobre a regex utilizada:
        //   // > https://stackoverflow.com/questions/19715303/regex-that-accepts-only-numbers-0-9-and-no-characters
        //   private bool TelefoneEstaValido()
        //   {
        //       bool telefoneEstaValido = false;
        //
        //       // utilizando o método Replace() para remover caracteres especiais da string
        //       string telefoneProcessado = Telefone.Replace("-", string.Empty)
        //                                           .Replace(" ", string.Empty);
        //
        //       if (telefoneProcessado.Length < 9)
        //           return telefoneEstaValido;
        //
        //       telefoneEstaValido = System.Text.RegularExpressions.Regex.IsMatch(telefoneProcessado, @"^[0-9]*$");
        //
        //       return telefoneEstaValido;
        //   }
        #endregion

        public override string ToString()
        {
            return $"|Nome: {Nome}|Email: {Email}|Telefone: {DDD}{Telefone}|Empresa: {Empresa}|Cargo: {Cargo}|";
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
