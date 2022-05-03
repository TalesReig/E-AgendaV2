namespace E_AgendaV2.WinFormsApp
{
    partial class ListagemDeTarefas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCadastrarIten = new System.Windows.Forms.Button();
            this.btnAtualizarIten = new System.Windows.Forms.Button();
            this.tabControlTarefas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listTarefasP = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTarefasC = new System.Windows.Forms.ListBox();
            this.tabControlTarefas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tarefas";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(26, 168);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(151, 37);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(26, 125);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(151, 37);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(26, 81);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(151, 37);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Inserir";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCadastrarIten
            // 
            this.btnCadastrarIten.Location = new System.Drawing.Point(26, 211);
            this.btnCadastrarIten.Name = "btnCadastrarIten";
            this.btnCadastrarIten.Size = new System.Drawing.Size(151, 37);
            this.btnCadastrarIten.TabIndex = 10;
            this.btnCadastrarIten.Text = "Cadastrar Iten";
            this.btnCadastrarIten.UseVisualStyleBackColor = true;
            this.btnCadastrarIten.Click += new System.EventHandler(this.btnCadastrarIten_Click);
            // 
            // btnAtualizarIten
            // 
            this.btnAtualizarIten.Location = new System.Drawing.Point(26, 254);
            this.btnAtualizarIten.Name = "btnAtualizarIten";
            this.btnAtualizarIten.Size = new System.Drawing.Size(151, 37);
            this.btnAtualizarIten.TabIndex = 11;
            this.btnAtualizarIten.Text = "Atualizar Itens";
            this.btnAtualizarIten.UseVisualStyleBackColor = true;
            this.btnAtualizarIten.Click += new System.EventHandler(this.btnAtualizarIten_Click);
            // 
            // tabControlTarefas
            // 
            this.tabControlTarefas.Controls.Add(this.tabPage1);
            this.tabControlTarefas.Controls.Add(this.tabPage2);
            this.tabControlTarefas.Location = new System.Drawing.Point(194, 41);
            this.tabControlTarefas.Name = "tabControlTarefas";
            this.tabControlTarefas.SelectedIndex = 0;
            this.tabControlTarefas.Size = new System.Drawing.Size(587, 259);
            this.tabControlTarefas.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listTarefasP);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(579, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listTarefasP
            // 
            this.listTarefasP.FormattingEnabled = true;
            this.listTarefasP.ItemHeight = 15;
            this.listTarefasP.Location = new System.Drawing.Point(0, 2);
            this.listTarefasP.Name = "listTarefasP";
            this.listTarefasP.Size = new System.Drawing.Size(576, 229);
            this.listTarefasP.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTarefasC);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(579, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Concluidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTarefasC
            // 
            this.listTarefasC.FormattingEnabled = true;
            this.listTarefasC.ItemHeight = 15;
            this.listTarefasC.Location = new System.Drawing.Point(0, 2);
            this.listTarefasC.Name = "listTarefasC";
            this.listTarefasC.Size = new System.Drawing.Size(576, 229);
            this.listTarefasC.TabIndex = 0;
            // 
            // ListagemDeTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControlTarefas);
            this.Controls.Add(this.btnAtualizarIten);
            this.Controls.Add(this.btnCadastrarIten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "ListagemDeTarefas";
            this.Size = new System.Drawing.Size(800, 340);
            this.tabControlTarefas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCadastrarIten;
        private System.Windows.Forms.Button btnAtualizarIten;
        private System.Windows.Forms.TabControl tabControlTarefas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listTarefasP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listTarefasC;
    }
}
