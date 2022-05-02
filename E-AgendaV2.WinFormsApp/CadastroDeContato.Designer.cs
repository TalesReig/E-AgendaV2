namespace E_AgendaV2.WinFormsApp
{
    partial class CadastroDeContato
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.maskFone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cargo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 23);
            this.txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(91, 136);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(118, 23);
            this.txtEmpresa.TabIndex = 8;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(246, 135);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(119, 23);
            this.txtCargo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fone:";
            // 
            // Cadastrar
            // 
            this.Cadastrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cadastrar.Location = new System.Drawing.Point(24, 215);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(179, 32);
            this.Cadastrar.TabIndex = 13;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(199, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(61, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cadastro De Contato:";
            // 
            // maskFone
            // 
            this.maskFone.Location = new System.Drawing.Point(91, 170);
            this.maskFone.Mask = "(00) 00000-0000";
            this.maskFone.Name = "maskFone";
            this.maskFone.Size = new System.Drawing.Size(81, 23);
            this.maskFone.TabIndex = 16;
            // 
            // CadastroDeContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 259);
            this.Controls.Add(this.maskFone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroDeContato";
            this.ShowIcon = false;
            this.Text = "Cadastro De Contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskFone;
    }
}