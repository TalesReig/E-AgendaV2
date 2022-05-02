using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestãoTarefas.Dominio;

namespace E_AgendaV2.WinFormsApp
{
    public partial class CadastroDeContato : Form
    {
        public Contato contato;

        public CadastroDeContato()
        {
            InitializeComponent();
        }

        public Contato contatoo
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtEmpresa.Text = contato.Telefone.ToString();
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;
            contato.Telefone = maskFone.Text.ToString();
            contato.Empresa = txtEmpresa.Text;
            contato.Cargo = txtCargo.Text;
        }
    }
}
