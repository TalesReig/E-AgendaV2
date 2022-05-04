namespace E_AgendaV2.WinFormsApp
{
    partial class ListagemDeCompromissos
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
            this.listCompromissosFuturos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Futuros = new System.Windows.Forms.TabPage();
            this.PassadosCompromissos = new System.Windows.Forms.TabPage();
            this.listCompromissosPassados = new System.Windows.Forms.ListBox();
            this.Entre = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimefim = new System.Windows.Forms.DateTimePicker();
            this.dateTimeinicio = new System.Windows.Forms.DateTimePicker();
            this.listBoxPorPeriodo = new System.Windows.Forms.ListBox();
            this.listtodos = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Futuros.SuspendLayout();
            this.PassadosCompromissos.SuspendLayout();
            this.Entre.SuspendLayout();
            this.listtodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCompromissosFuturos
            // 
            this.listCompromissosFuturos.FormattingEnabled = true;
            this.listCompromissosFuturos.ItemHeight = 15;
            this.listCompromissosFuturos.Location = new System.Drawing.Point(0, 0);
            this.listCompromissosFuturos.Name = "listCompromissosFuturos";
            this.listCompromissosFuturos.Size = new System.Drawing.Size(579, 244);
            this.listCompromissosFuturos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Compromissos";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(22, 226);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(151, 37);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(22, 175);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(151, 37);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(22, 124);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(151, 37);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.listtodos);
            this.tabControl1.Controls.Add(this.Futuros);
            this.tabControl1.Controls.Add(this.PassadosCompromissos);
            this.tabControl1.Controls.Add(this.Entre);
            this.tabControl1.Location = new System.Drawing.Point(188, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 270);
            this.tabControl1.TabIndex = 10;
            // 
            // Futuros
            // 
            this.Futuros.Controls.Add(this.listCompromissosFuturos);
            this.Futuros.Location = new System.Drawing.Point(4, 24);
            this.Futuros.Name = "Futuros";
            this.Futuros.Padding = new System.Windows.Forms.Padding(3);
            this.Futuros.Size = new System.Drawing.Size(579, 242);
            this.Futuros.TabIndex = 0;
            this.Futuros.Text = "Compromissos Futuros";
            this.Futuros.UseVisualStyleBackColor = true;
            // 
            // PassadosCompromissos
            // 
            this.PassadosCompromissos.Controls.Add(this.listCompromissosPassados);
            this.PassadosCompromissos.Location = new System.Drawing.Point(4, 24);
            this.PassadosCompromissos.Name = "PassadosCompromissos";
            this.PassadosCompromissos.Size = new System.Drawing.Size(579, 242);
            this.PassadosCompromissos.TabIndex = 4;
            this.PassadosCompromissos.Text = "Compromissos Passados";
            this.PassadosCompromissos.UseVisualStyleBackColor = true;
            // 
            // listCompromissosPassados
            // 
            this.listCompromissosPassados.FormattingEnabled = true;
            this.listCompromissosPassados.ItemHeight = 15;
            this.listCompromissosPassados.Location = new System.Drawing.Point(0, -1);
            this.listCompromissosPassados.Name = "listCompromissosPassados";
            this.listCompromissosPassados.Size = new System.Drawing.Size(579, 244);
            this.listCompromissosPassados.TabIndex = 10;
            // 
            // Entre
            // 
            this.Entre.Controls.Add(this.btnPesquisar);
            this.Entre.Controls.Add(this.label3);
            this.Entre.Controls.Add(this.label2);
            this.Entre.Controls.Add(this.dateTimefim);
            this.Entre.Controls.Add(this.dateTimeinicio);
            this.Entre.Controls.Add(this.listBoxPorPeriodo);
            this.Entre.Location = new System.Drawing.Point(4, 24);
            this.Entre.Name = "Entre";
            this.Entre.Padding = new System.Windows.Forms.Padding(3);
            this.Entre.Size = new System.Drawing.Size(579, 242);
            this.Entre.TabIndex = 1;
            this.Entre.Text = "Compromissos Por Periodo";
            this.Entre.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(526, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(47, 23);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Buscar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(268, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "De";
            // 
            // dateTimefim
            // 
            this.dateTimefim.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimefim.Location = new System.Drawing.Point(289, 3);
            this.dateTimefim.Name = "dateTimefim";
            this.dateTimefim.Size = new System.Drawing.Size(232, 23);
            this.dateTimefim.TabIndex = 12;
            // 
            // dateTimeinicio
            // 
            this.dateTimeinicio.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimeinicio.Location = new System.Drawing.Point(33, 3);
            this.dateTimeinicio.Name = "dateTimeinicio";
            this.dateTimeinicio.Size = new System.Drawing.Size(229, 23);
            this.dateTimeinicio.TabIndex = 11;
            // 
            // listBoxPorPeriodo
            // 
            this.listBoxPorPeriodo.FormattingEnabled = true;
            this.listBoxPorPeriodo.ItemHeight = 15;
            this.listBoxPorPeriodo.Location = new System.Drawing.Point(0, 28);
            this.listBoxPorPeriodo.Name = "listBoxPorPeriodo";
            this.listBoxPorPeriodo.Size = new System.Drawing.Size(579, 214);
            this.listBoxPorPeriodo.TabIndex = 10;
            // 
            // listtodos
            // 
            this.listtodos.Controls.Add(this.listBox1);
            this.listtodos.Location = new System.Drawing.Point(4, 24);
            this.listtodos.Name = "listtodos";
            this.listtodos.Size = new System.Drawing.Size(579, 242);
            this.listtodos.TabIndex = 3;
            this.listtodos.Text = "Todos os Compromissos";
            this.listtodos.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(579, 244);
            this.listBox1.TabIndex = 10;
            // 
            // ListagemDeCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Name = "ListagemDeCompromissos";
            this.Size = new System.Drawing.Size(800, 340);
            this.tabControl1.ResumeLayout(false);
            this.Futuros.ResumeLayout(false);
            this.PassadosCompromissos.ResumeLayout(false);
            this.Entre.ResumeLayout(false);
            this.Entre.PerformLayout();
            this.listtodos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCompromissosFuturos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Futuros;
        private System.Windows.Forms.TabPage Entre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimefim;
        private System.Windows.Forms.DateTimePicker dateTimeinicio;
        private System.Windows.Forms.ListBox listBoxPorPeriodo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TabPage PassadosCompromissos;
        private System.Windows.Forms.ListBox listCompromissosPassados;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage listtodos;
        private System.Windows.Forms.ListBox listBox1;
    }
}
