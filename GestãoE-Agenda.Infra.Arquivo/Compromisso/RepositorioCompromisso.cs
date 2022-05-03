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
    }
}
