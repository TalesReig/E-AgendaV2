using GestãoTarefas.Dominio;
//using GestãoTarefas.Dominio.Contato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoE_Agenda.Infra.Arquivo
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public RepositorioContato() : base(@"C:\Temp\Contatos")
        {

        }


        public void AgendarContato(int id)
        {
            registros[id].temCompromisso = false;
        }

        public void DesagendarContato(Contato contato)
        {
            contato.temCompromisso = false;
        }

        public List<Contato> OrdenadosPorCargo()
        {
            List<Contato> contatosOrdenadosPorCargo = registros;

            contatosOrdenadosPorCargo.Sort((x, y) => string.Compare(x.Cargo, y.Cargo));

            return contatosOrdenadosPorCargo;
        }
    }
}
