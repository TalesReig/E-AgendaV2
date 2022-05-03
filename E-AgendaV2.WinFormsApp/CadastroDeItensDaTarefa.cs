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
    public partial class CadastroDeItensDaTarefa : Form
    {
        private readonly Tarefa tarefa;

        public CadastroDeItensDaTarefa(Tarefa tarefa)
        {
            InitializeComponent();

            this.tarefa = tarefa;

            labelTituloTarefa.Text = tarefa.Titulo;

            foreach(ItemTarefa item in tarefa.Itens)
            {
                listItensTarefas.Items.Add(item);
            }
        }

        public List<ItemTarefa> ItensAdcionados 
        {
            get
            {
                return listItensTarefas.Items.Cast<ItemTarefa>().ToList();
            }
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdcionados.Select(x => x.Titulo).ToList();

            if (titulos.Count == 0 || titulos.Contains(txtTitulo.Text) == false)
            {
                ItemTarefa itemTarefa = new ItemTarefa();

                itemTarefa.Titulo = txtTitulo.Text;

                listItensTarefas.Items.Add(itemTarefa);
            }

        }
    }
}
