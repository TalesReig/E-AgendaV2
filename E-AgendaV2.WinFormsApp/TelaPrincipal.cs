using GestãoE_Agenda.Infra.Arquivo;
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
        private readonly RepositorioContato _repositorioContato;
        private readonly ListagemDeContatos pContato;

        ListagemDeCompromissos pCompromisso;
        ListagemDeTarefas pTarefas;
        public TelaPrincipal()
        {
            InitializeComponent();
            _repositorioContato = new RepositorioContato();
            pContato = new ListagemDeContatos(_repositorioContato);

            pCompromisso = new ListagemDeCompromissos();
            pTarefas = new ListagemDeTarefas();
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
