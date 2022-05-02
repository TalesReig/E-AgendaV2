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
    public partial class ListagemDeContatos : UserControl
    {
        public readonly RepositorioContato repositorio;
        public ListagemDeContatos(RepositorioContato repositorio)
        {
            this.repositorio = repositorio;
            InitializeComponent();
            CarregarContatos();
        }

        private void InserirContatos_Click(object sender, EventArgs e)
        {
            CadastroDeContato tela = new CadastroDeContato();
            tela.contato = new Contato();

            DialogResult resultado = tela.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                if(tela.contato.Validar() == "REGISTRO_VALIDO")
                {
                    repositorio.Inserir(tela.contato);
                    CarregarContatos();
                }
                else
                {
                    MessageBox.Show("Prencha os campos brigatorios Nome/E-mail/Telefone e nos padroes corretos Telefone (xx)xxxxx-xxxx",
                    "Inserção de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void EditarContatos_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if(contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroDeContato tela = new CadastroDeContato();

            tela.contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (tela.contato.Validar() == "REGISTRO_VALIDO")
                {
                    repositorio.Inserir(tela.contato);
                    CarregarContatos();
                }
                else
                {
                    MessageBox.Show("Prencha os campos brigatorios Nome/E-mail/Telefone e nos padroes corretos Telefone (xx)xxxxx-xxxx",
                    "Inserção de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ExcluirContatos_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o Contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorio.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }

        #region métodos privados
        private void CarregarContatos()
        {
            List<Contato> contatos = repositorio.SelecionarTodos();

            listContatos.Items.Clear();

            foreach (Contato c in contatos)
            {
                listContatos.Items.Add(c);
            }
        }

        #endregion
    }
}
