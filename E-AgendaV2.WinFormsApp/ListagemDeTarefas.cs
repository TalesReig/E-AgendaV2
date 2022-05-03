using GestãoE_Agenda.Infra.Arquivo;
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
    public partial class ListagemDeTarefas : UserControl
    {
        public RepositorioTarefa repositorio;
        public ListagemDeTarefas(RepositorioTarefa repositorio)
        {
            this.repositorio = repositorio;
            InitializeComponent();
            CarregarTarefas();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           CadastroDeTarefa tela = new CadastroDeTarefa();
           tela.tarefa = new Tarefa();
        
           DialogResult resultado = tela.ShowDialog();
        
           if (resultado == DialogResult.OK)
           {
               if (tela.tarefa.Validar() == "REGISTRO_VALIDO")
               {
                   repositorio.Inserir(tela.tarefa);
                   CarregarTarefas();
               }
               else
               {
                   MessageBox.Show("Prencha os campos brigatorios Nome/E-mail/Telefone e nos padroes corretos Telefone (xx)xxxxx-xxxx",
                   "Inserção de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
           }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           Tarefa tarefaSelecionado = (Tarefa)listTarefas.SelectedItem;
        
           if (tarefaSelecionado == null)
           {
               MessageBox.Show("Selecione uma tarefa primeiro",
               "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               return;
           }
        
           CadastroDeTarefa tela = new CadastroDeTarefa();
        
           tela.tarefa = tarefaSelecionado;
        
           DialogResult resultado = tela.ShowDialog();
        
           if (resultado == DialogResult.OK)
           {
               if (tela.tarefa.Validar() == "REGISTRO_VALIDO")
               {
                   repositorio.Inserir(tela.tarefa);
                   CarregarTarefas();
               }
               else
               {
                   MessageBox.Show("Prencha os campos brigatorios Nome/E-mail/Telefone e nos padroes corretos Telefone (xx)xxxxx-xxxx",
                   "Inserção de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
           }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           Tarefa tarefaSelecionado = (Tarefa)listTarefas.SelectedItem;
        
           if (tarefaSelecionado == null)
           {
               MessageBox.Show("Selecione uma tarefa primeiro",
               "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               return;
           }
        
           DialogResult resultado = MessageBox.Show("Deseja realmente excluir o Contato?",
               "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        
           if (resultado == DialogResult.OK)
           {
               repositorio.Excluir(tarefaSelecionado);
               CarregarTarefas();
           }
        }

        private void btnCadastrarIten_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionado = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionado == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroDeItensDaTarefa tela = new CadastroDeItensDaTarefa(tarefaSelecionado);

            if(tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdcionados;

                repositorio.AdcionarItens(tarefaSelecionado, itens);

                CarregarTarefas();
            }
        }

        private void btnAtualizarIten_Click(object sender, EventArgs e)
        {

        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorio.SelecionarTodos();

            listTarefas.Items.Clear();

            foreach (Tarefa t in tarefas)
            {
                listTarefas.Items.Add(t);
            }
        }

        private void CarregarTarefasPendentes()
        {
            List<Tarefa> tarefas = repositorio.SelecionarTodos();

            listTarefas.Items.Clear();

            foreach (Tarefa t in tarefas)
            {
                //if(t.estado == pendente)
                listTarefasPendentes.Items.Add(t);
            }
        }
    }
}
