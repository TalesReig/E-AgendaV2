namespace E_AgendaV2.WinFormsApp
{
    partial class TelaPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnContatos = new System.Windows.Forms.Button();
            this.BtnCompromissos = new System.Windows.Forms.Button();
            this.BtnTarefas = new System.Windows.Forms.Button();
            this.Painel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnContatos
            // 
            this.BtnContatos.Location = new System.Drawing.Point(29, 23);
            this.BtnContatos.Name = "BtnContatos";
            this.BtnContatos.Size = new System.Drawing.Size(104, 36);
            this.BtnContatos.TabIndex = 0;
            this.BtnContatos.Text = "Contatos";
            this.BtnContatos.UseVisualStyleBackColor = true;
            this.BtnContatos.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCompromissos
            // 
            this.BtnCompromissos.Location = new System.Drawing.Point(139, 23);
            this.BtnCompromissos.Name = "BtnCompromissos";
            this.BtnCompromissos.Size = new System.Drawing.Size(104, 36);
            this.BtnCompromissos.TabIndex = 1;
            this.BtnCompromissos.Text = "Compromissos";
            this.BtnCompromissos.UseVisualStyleBackColor = true;
            this.BtnCompromissos.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnTarefas
            // 
            this.BtnTarefas.Location = new System.Drawing.Point(249, 23);
            this.BtnTarefas.Name = "BtnTarefas";
            this.BtnTarefas.Size = new System.Drawing.Size(104, 36);
            this.BtnTarefas.TabIndex = 2;
            this.BtnTarefas.Text = "Tarefas";
            this.BtnTarefas.UseVisualStyleBackColor = true;
            this.BtnTarefas.Click += new System.EventHandler(this.button3_Click);
            // 
            // Painel
            // 
            this.Painel.Location = new System.Drawing.Point(29, 80);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(800, 340);
            this.Painel.TabIndex = 3;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 461);
            this.Controls.Add(this.Painel);
            this.Controls.Add(this.BtnTarefas);
            this.Controls.Add(this.BtnCompromissos);
            this.Controls.Add(this.BtnContatos);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnContatos;
        private System.Windows.Forms.Button BtnCompromissos;
        private System.Windows.Forms.Button BtnTarefas;
        private System.Windows.Forms.Panel Painel;
    }
}