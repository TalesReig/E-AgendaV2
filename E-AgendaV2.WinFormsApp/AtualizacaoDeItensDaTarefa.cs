using GestãoTarefas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_AgendaV2.WinFormsApp
{
    public partial class AtualizacaoDeItensDaTarefa : Form
    {
        private readonly Tarefa tarefa;

        public AtualizacaoDeItensDaTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;

            labelTituloTarefa.Text = tarefa.Titulo;
            ApresentarItens(tarefa);
        }

        public List<ItemTarefa> itensConcluidos
        {
            get
            {
                return listItensTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
            }
        }
        public List<ItemTarefa> itensPendentes
        {
            get
            {
                return listItensTarefa.Items.Cast<ItemTarefa>().Except(itensConcluidos).ToList();
            }
        }
        private void ApresentarItens(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.Concluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }

            // testar isso aqui dps int selecionados = listItensTarefa.CheckedItems.Count;
        }

    }
}
