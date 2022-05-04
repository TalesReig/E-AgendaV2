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
    public partial class TelaPrincipal : Form
    {
        private readonly JsonSerialization<Contato> _jsonContactsSerialization;
        private readonly RepositorioContato _repositorioContato;
        private readonly ListagemDeContatos pContato;

        private readonly JsonSerialization<Compromisso> _jsonCompromissosSerialization;
        private readonly RepositorioCompromisso _repositorioCompromisso;
        private readonly ListagemDeCompromissos pCompromisso;

        private readonly JsonSerialization<Tarefa> _jsonTarefasSerialization;
        private readonly RepositorioTarefa _repositorioTarefa;
        private readonly ListagemDeTarefas pTarefas;

        public TelaPrincipal()
        {
            InitializeComponent();
            _repositorioContato = new RepositorioContato();
            pContato = new ListagemDeContatos(_repositorioContato);
            Painel.Controls.Add(pContato);

            _repositorioCompromisso = new RepositorioCompromisso();
            pCompromisso = new ListagemDeCompromissos(_repositorioCompromisso, _repositorioContato, _repositorioContato.SelecionarTodos());

            _repositorioTarefa = new RepositorioTarefa();
            pTarefas = new ListagemDeTarefas(_repositorioTarefa, _jsonTarefasSerialization);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Painel.Controls.Clear();
            Painel.Controls.Add(pContato);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Painel.Controls.Clear();
            Painel.Controls.Add(pCompromisso);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Painel.Controls.Clear();
            Painel.Controls.Add(pTarefas);
        }

    }
}
