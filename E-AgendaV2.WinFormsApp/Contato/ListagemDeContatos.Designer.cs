namespace E_AgendaV2.WinFormsApp
{
    partial class ListagemDeContatos
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InserirContatos = new System.Windows.Forms.Button();
            this.ExcluirContatos = new System.Windows.Forms.Button();
            this.EditarContatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Contatos = new System.Windows.Forms.TabPage();
            this.ContatosCargo = new System.Windows.Forms.TabPage();
            this.listContatosAgrupados = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Contatos.SuspendLayout();
            this.ContatosCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // InserirContatos
            // 
            this.InserirContatos.Location = new System.Drawing.Point(18, 116);
            this.InserirContatos.Name = "InserirContatos";
            this.InserirContatos.Size = new System.Drawing.Size(151, 37);
            this.InserirContatos.TabIndex = 0;
            this.InserirContatos.Text = "Inserir";
            this.InserirContatos.UseVisualStyleBackColor = true;
            this.InserirContatos.Click += new System.EventHandler(this.InserirContatos_Click);
            // 
            // ExcluirContatos
            // 
            this.ExcluirContatos.Location = new System.Drawing.Point(18, 218);
            this.ExcluirContatos.Name = "ExcluirContatos";
            this.ExcluirContatos.Size = new System.Drawing.Size(151, 37);
            this.ExcluirContatos.TabIndex = 2;
            this.ExcluirContatos.Text = "Excluir";
            this.ExcluirContatos.UseVisualStyleBackColor = true;
            this.ExcluirContatos.Click += new System.EventHandler(this.ExcluirContatos_Click);
            // 
            // EditarContatos
            // 
            this.EditarContatos.Location = new System.Drawing.Point(18, 167);
            this.EditarContatos.Name = "EditarContatos";
            this.EditarContatos.Size = new System.Drawing.Size(151, 37);
            this.EditarContatos.TabIndex = 1;
            this.EditarContatos.Text = "Editar";
            this.EditarContatos.UseVisualStyleBackColor = true;
            this.EditarContatos.Click += new System.EventHandler(this.EditarContatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contatos";
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 15;
            this.listContatos.Location = new System.Drawing.Point(0, 2);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(578, 244);
            this.listContatos.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Contatos);
            this.tabControl1.Controls.Add(this.ContatosCargo);
            this.tabControl1.Location = new System.Drawing.Point(181, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 276);
            this.tabControl1.TabIndex = 5;
            // 
            // Contatos
            // 
            this.Contatos.Controls.Add(this.listContatos);
            this.Contatos.Location = new System.Drawing.Point(4, 24);
            this.Contatos.Name = "Contatos";
            this.Contatos.Padding = new System.Windows.Forms.Padding(3);
            this.Contatos.Size = new System.Drawing.Size(581, 248);
            this.Contatos.TabIndex = 0;
            this.Contatos.Text = "Contatos Ordenados Por Nome";
            this.Contatos.UseVisualStyleBackColor = true;
            // 
            // ContatosCargo
            // 
            this.ContatosCargo.Controls.Add(this.listContatosAgrupados);
            this.ContatosCargo.Location = new System.Drawing.Point(4, 24);
            this.ContatosCargo.Name = "ContatosCargo";
            this.ContatosCargo.Padding = new System.Windows.Forms.Padding(3);
            this.ContatosCargo.Size = new System.Drawing.Size(581, 248);
            this.ContatosCargo.TabIndex = 1;
            this.ContatosCargo.Text = "Contatos Agrupados Por Cargo";
            this.ContatosCargo.UseVisualStyleBackColor = true;
            // 
            // listContatosAgrupados
            // 
            this.listContatosAgrupados.FormattingEnabled = true;
            this.listContatosAgrupados.ItemHeight = 15;
            this.listContatosAgrupados.Location = new System.Drawing.Point(1, 3);
            this.listContatosAgrupados.Name = "listContatosAgrupados";
            this.listContatosAgrupados.Size = new System.Drawing.Size(577, 244);
            this.listContatosAgrupados.TabIndex = 0;
            // 
            // ListagemDeContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExcluirContatos);
            this.Controls.Add(this.EditarContatos);
            this.Controls.Add(this.InserirContatos);
            this.Name = "ListagemDeContatos";
            this.Size = new System.Drawing.Size(800, 340);
            this.tabControl1.ResumeLayout(false);
            this.Contatos.ResumeLayout(false);
            this.ContatosCargo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InserirContatos;
        private System.Windows.Forms.Button ExcluirContatos;
        private System.Windows.Forms.Button EditarContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Contatos;
        private System.Windows.Forms.TabPage ContatosCargo;
        private System.Windows.Forms.ListBox listContatosAgrupados;
    }
}
