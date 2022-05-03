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
    public partial class CadastroDeTarefa : Form
    {
        public Tarefa tarefa;
        public CadastroDeTarefa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            tarefa.prioridade = ConverterPrioridade(cbxPrioridade);
            tarefa.Titulo = txtTitulo.Text;
        }

        private int ConverterPrioridade(ComboBox cbxPrioridade)
        {
            if (cbxPrioridade.Text == "Baixa")
                return 1;

            if (cbxPrioridade.Text == "Média")
                return 2;

            if (cbxPrioridade.Text == "Alta")
                return 3;

            else return 1;
        }
    }
}
