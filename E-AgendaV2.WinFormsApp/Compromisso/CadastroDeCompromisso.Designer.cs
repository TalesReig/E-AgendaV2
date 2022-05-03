namespace E_AgendaV2.WinFormsApp
{
    partial class CadastroDeCompromisso
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtHInicio = new System.Windows.Forms.TextBox();
            this.txtHfinal = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.cbxContatos = new System.Windows.Forms.ComboBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxHInicio = new System.Windows.Forms.ComboBox();
            this.cbxHFinal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "H. De Início";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "H. De Término";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contato";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(84, 57);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(215, 23);
            this.txtAssunto.TabIndex = 6;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(84, 88);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(215, 23);
            this.txtLocal.TabIndex = 7;
            // 
            // txtHInicio
            // 
            this.txtHInicio.Location = new System.Drawing.Point(286, 146);
            this.txtHInicio.Name = "txtHInicio";
            this.txtHInicio.Size = new System.Drawing.Size(13, 23);
            this.txtHInicio.TabIndex = 9;
            // 
            // txtHfinal
            // 
            this.txtHfinal.Location = new System.Drawing.Point(286, 175);
            this.txtHfinal.Name = "txtHfinal";
            this.txtHfinal.Size = new System.Drawing.Size(13, 23);
            this.txtHfinal.TabIndex = 10;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(84, 117);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(215, 23);
            this.dateTime.TabIndex = 12;
            // 
            // cbxContatos
            // 
            this.cbxContatos.FormattingEnabled = true;
            this.cbxContatos.Location = new System.Drawing.Point(84, 207);
            this.cbxContatos.Name = "cbxContatos";
            this.cbxContatos.Size = new System.Drawing.Size(215, 23);
            this.cbxContatos.TabIndex = 13;
            this.cbxContatos.SelectedIndexChanged += new System.EventHandler(this.cbxContatos_SelectedIndexChanged);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnCadastrar.Location = new System.Drawing.Point(32, 241);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(136, 23);
            this.BtnCadastrar.TabIndex = 14;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(164, 241);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(135, 23);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(25, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cadastro De Compromissos";
            // 
            // cbxHInicio
            // 
            this.cbxHInicio.FormattingEnabled = true;
            this.cbxHInicio.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbxHInicio.Location = new System.Drawing.Point(113, 146);
            this.cbxHInicio.Name = "cbxHInicio";
            this.cbxHInicio.Size = new System.Drawing.Size(127, 23);
            this.cbxHInicio.TabIndex = 17;
            // 
            // cbxHFinal
            // 
            this.cbxHFinal.FormattingEnabled = true;
            this.cbxHFinal.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbxHFinal.Location = new System.Drawing.Point(113, 175);
            this.cbxHFinal.Name = "cbxHFinal";
            this.cbxHFinal.Size = new System.Drawing.Size(127, 23);
            this.cbxHFinal.TabIndex = 18;
            // 
            // CadastroDeCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 276);
            this.Controls.Add(this.cbxHFinal);
            this.Controls.Add(this.cbxHInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.cbxContatos);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txtHfinal);
            this.Controls.Add(this.txtHInicio);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroDeCompromisso";
            this.Text = "CadastroDeCompromisso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtHInicio;
        private System.Windows.Forms.TextBox txtHfinal;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox cbxContatos;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxHInicio;
        private System.Windows.Forms.ComboBox cbxHFinal;
    }
}