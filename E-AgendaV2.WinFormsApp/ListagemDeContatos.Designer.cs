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
            this.listContatos.Location = new System.Drawing.Point(190, 48);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(477, 259);
            this.listContatos.TabIndex = 4;
            // 
            // ListagemDeContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExcluirContatos);
            this.Controls.Add(this.EditarContatos);
            this.Controls.Add(this.InserirContatos);
            this.Name = "ListagemDeContatos";
            this.Size = new System.Drawing.Size(688, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InserirContatos;
        private System.Windows.Forms.Button ExcluirContatos;
        private System.Windows.Forms.Button EditarContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listContatos;
    }
}
