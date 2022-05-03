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
    public partial class CadastroDeCompromisso : Form
    {
        public Compromisso compromisso;
        List<Contato> contatos2;

        public CadastroDeCompromisso()
        {

        }

        public CadastroDeCompromisso(List<Contato> contatos)
        {
            InitializeComponent();
            contatos2 = contatos;
            foreach (Contato c in contatos2)
            {
                cbxContatos.Items.Add(c.Nome);
            }
            
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            compromisso.Assunto = txtAssunto.Text;
            compromisso.Local = txtLocal.Text;
            DateTime dataC = dateTime.Value;
            compromisso.DataCompromisso = dataC;
            try
            {
                compromisso.HoraInicio = Convert.ToInt32(txtHInicio.Text);
                compromisso.HoraTermino = Convert.ToInt32(txtHfinal.Text);
            }
            catch
            {

            }
            compromisso.NomeContato = cbxContatos.Text;
        }

        private void cbxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
