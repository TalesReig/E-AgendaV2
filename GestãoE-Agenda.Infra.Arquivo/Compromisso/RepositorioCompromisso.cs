using GestãoTarefas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoE_Agenda.Infra.Arquivo
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso() : base(@"C:\Temp\Compromisso")
        {

        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            return registros.Where(x => x.DataCompromisso < DateTime.Today).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            return registros.Where(x => x.DataCompromisso > DateTime.Today).ToList();
        }

        public List<Compromisso> SelecionarCompromissosEntre(DateTime inicio, DateTime termino)
        {
            return registros.Where(x => x.DataCompromisso > inicio && x.DataCompromisso < termino).ToList();
        }
    }
}
