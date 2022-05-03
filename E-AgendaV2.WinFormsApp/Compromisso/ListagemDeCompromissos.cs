using GestãoE_Agenda.Infra.Arquivo;
using System;
using GestãoTarefas.Dominio;
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
    public partial class ListagemDeCompromissos : UserControl
    {
        RepositorioCompromisso repositorio;
        RepositorioContato repositorioContato;
        List<Contato> contatos2;
        public ListagemDeCompromissos(RepositorioCompromisso repositorio, List<Contato> contatos)
        {
            this.repositorio = repositorio;
            contatos2 = contatos;

            CadastroDeCompromisso tela = new CadastroDeCompromisso(contatos2);

            InitializeComponent();
            CarregarCompromissos();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroDeCompromisso tela = new CadastroDeCompromisso(contatos2);
            tela.compromisso = new Compromisso();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (tela.compromisso.Validar() == "REGISTRO_VALIDO")
                {
                    repositorio.Inserir(tela.compromisso);
                    CarregarCompromissos();
                }
                else
                {
                    MessageBox.Show("Prencha os campos brigatorios Assunto, Local e Data do compromisso (OBS: a hora final deve ser maior que a hora inicial)",
                    "Inserção de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compromisso contatoSelecionado = (Compromisso)listCompromissos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Edição de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroDeCompromisso tela = new CadastroDeCompromisso(contatos2);

            tela.compromisso = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (tela.compromisso.Validar() == "REGISTRO_VALIDO")
                {
                    repositorio.Editar(tela.compromisso);
                    CarregarCompromissos();
                }
                else
                {
                    MessageBox.Show("Prencha os campos brigatorios Assunto, Local e Data do compromisso",
                    "Inserção de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso contatoSelecionado = (Compromisso)listCompromissos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Exclusão de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o Compromisso?",
                "Exclusão de Compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorio.Excluir(contatoSelecionado);
                CarregarCompromissos();
            }
        }

        #region métodos privados
        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorio.SelecionarTodos();

            listCompromissos.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                listCompromissos.Items.Add(c);
            }
        }

        #endregion
    }
}
