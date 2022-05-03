using GestãoTarefas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoE_Agenda.Infra.Arquivo
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public void AdcionarItens(Tarefa tarefaSelecionado, List<ItemTarefa> itens)
        {
            foreach(ItemTarefa i in itens)
            {
                tarefaSelecionado.AdicionarItem(i);
            }
        }
    }
}
