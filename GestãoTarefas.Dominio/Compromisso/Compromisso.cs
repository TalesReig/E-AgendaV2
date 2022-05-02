using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTarefas.Dominio
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public string Local { get; set; }

        private DateTime _dataCompromisso;
        public DateTime DataCompromisso { get /*=> _dataCompromisso.Add(HoraInicio)*/; set /*=> _dataCompromisso = value*/; }
        public int? HoraInicio { get; set; }
        public int? HoraTermino { get; set; }
        public string NomeContato { get; set; }

        public Compromisso(string assunto, string local, DateTime dataCompromisso, int horaInicio, int horaTermino, string contato)
        {
            Assunto = assunto;
            Local = local;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            DataCompromisso = dataCompromisso;
            NomeContato = contato;
        }

        public Compromisso()
        {
        }

        public override string ToString()
        {
            //string contatoRelacionado = Contato is null ? "Não disponível" : Contato.Nome;

            return "|Assunto: " + Assunto +
                "|Local: " + Local +
                "|Data do compromisso: " + DataCompromisso.ToShortDateString() +
                "|Hora de ínicio: " + HoraInicio + Environment.NewLine +
                "|Hora de término: " + HoraTermino +
                /*"|Contato: " + contatoRelacionado+*/"|";
        }

        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Assunto))
                sb.AppendLine("O assunto do compromisso é obrigatório!");

            if (string.IsNullOrEmpty(Local))
                sb.AppendLine("O local do compromisso é obrigatório!");

            if (DataCompromisso == DateTime.MinValue)
                sb.AppendLine("A data do compromisso obrigatória!");

            if (sb.Length == 0)
                return "REGISTRO_VALIDO";

            return sb.ToString();
        }
    }
}
