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
        public ListagemDeCompromissos(RepositorioCompromisso repositorio, RepositorioContato repoContato, List<Contato> contatos)
        {
            this.repositorio = repositorio;
            this.repositorioContato = repoContato;
            contatos2 = contatos;

            CadastroDeCompromisso tela = new CadastroDeCompromisso(contatos2);

            InitializeComponent();
            CarregarCompromissos();
            CarregarCompromissosFuturos();
            CarregarCompromissosPassados();
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
                    repositorioContato.AgendarContato(tela.compromisso.idContato);
                    CarregarCompromissos();
                    CarregarCompromissosFuturos();
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
            Compromisso contatoSelecionado = (Compromisso)listCompromissosFuturos.SelectedItem;

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
                    CarregarCompromissosFuturos();
                }
                else
                {
                    MessageBox.Show("Prencha os campos brigatorios Assunto, Local e Data do compromisso",
                    "Inserção de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso contatoSelecionado = (Compromisso)listCompromissosFuturos.SelectedItem;

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
                CarregarCompromissosFuturos();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dateTimeinicio.Value;
            DateTime dataFim = dateTimefim.Value;

            CarregarCompromissosEntre(dataInicio, dataFim);
        }

        #region métodos privados
        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorio.SelecionarTodos();
            listBox1.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                listBox1.Items.Add(c);
            }
        }

        private void CarregarCompromissosFuturos()
        {
            List<Compromisso> compromissos = repositorio.SelecionarCompromissosFuturos();
            listCompromissosFuturos.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                listCompromissosFuturos.Items.Add(c);
            }
        }

        private void CarregarCompromissosPassados()
        {
            List<Compromisso> compromissos = repositorio.SelecionarCompromissosPassados();
            listCompromissosPassados.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                listCompromissosPassados.Items.Add(c);
            }
        }

        private void CarregarCompromissosEntre(DateTime inicio, DateTime termino)
        {
            List<Compromisso> compromissos = repositorio.SelecionarCompromissosEntre(inicio, termino);
            listBoxPorPeriodo.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                listBoxPorPeriodo.Items.Add(c);
            }
        }

        #endregion
    }
}
