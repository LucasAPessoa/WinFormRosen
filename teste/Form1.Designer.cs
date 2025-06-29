﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        public void btnTeste_Click(object sender, EventArgs e)
        {
            // Implementar a lógica do botão aqui
            MessageBox.Show("Botão Teste Clicado!");
        }
        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CadCursos = new System.Windows.Forms.Button();
            this.CHTextBox = new System.Windows.Forms.TextBox();
            this.NomeCursoTxtBox = new System.Windows.Forms.TextBox();
            this.CHCurso = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listViewCursos = new System.Windows.Forms.ListView();
            this.DropCursosProf = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DtNascProf = new System.Windows.Forms.TextBox();
            this.cpfProf = new System.Windows.Forms.TextBox();
            this.TelProf = new System.Windows.Forms.TextBox();
            this.EmailProf = new System.Windows.Forms.TextBox();
            this.NomeProf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewProfessores = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CursosAluno = new System.Windows.Forms.Label();
            this.CheckListCursosAlunos = new System.Windows.Forms.CheckedListBox();
            this.DatNascTextBox = new System.Windows.Forms.TextBox();
            this.CpfTextBox = new System.Windows.Forms.TextBox();
            this.CelTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DtNascLabel = new System.Windows.Forms.Label();
            this.CpfLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.CadAluno = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.listViewAlunos = new System.Windows.Forms.ListView();
            this.CadAlunos = new System.Windows.Forms.TabControl();
            this.CursosProf = new System.Windows.Forms.CheckedListBox();
            this.tabPage3.SuspendLayout();
            this.DropCursosProf.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CadAlunos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CadCursos);
            this.tabPage3.Controls.Add(this.CHTextBox);
            this.tabPage3.Controls.Add(this.NomeCursoTxtBox);
            this.tabPage3.Controls.Add(this.CHCurso);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.listViewCursos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cursos";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // CadCursos
            // 
            this.CadCursos.Location = new System.Drawing.Point(251, 85);
            this.CadCursos.Name = "CadCursos";
            this.CadCursos.Size = new System.Drawing.Size(99, 23);
            this.CadCursos.TabIndex = 16;
            this.CadCursos.Text = "Cadastrar Curso";
            this.CadCursos.UseVisualStyleBackColor = true;
            this.CadCursos.Click += new System.EventHandler(this.CadastrarCurso);
            // 
            // CHTextBox
            // 
            this.CHTextBox.Location = new System.Drawing.Point(94, 35);
            this.CHTextBox.Name = "CHTextBox";
            this.CHTextBox.Size = new System.Drawing.Size(256, 20);
            this.CHTextBox.TabIndex = 15;
            // 
            // NomeCursoTxtBox
            // 
            this.NomeCursoTxtBox.Location = new System.Drawing.Point(57, 8);
            this.NomeCursoTxtBox.Name = "NomeCursoTxtBox";
            this.NomeCursoTxtBox.Size = new System.Drawing.Size(293, 20);
            this.NomeCursoTxtBox.TabIndex = 12;
            // 
            // CHCurso
            // 
            this.CHCurso.AutoSize = true;
            this.CHCurso.Location = new System.Drawing.Point(13, 38);
            this.CHCurso.Name = "CHCurso";
            this.CHCurso.Size = new System.Drawing.Size(75, 13);
            this.CHCurso.TabIndex = 14;
            this.CHCurso.Text = "Carga Horaria:";
            this.CHCurso.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nome:";
            // 
            // listViewCursos
            // 
            this.listViewCursos.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewCursos.FullRowSelect = true;
            this.listViewCursos.GridLines = true;
            this.listViewCursos.HideSelection = false;
            this.listViewCursos.Location = new System.Drawing.Point(375, 0);
            this.listViewCursos.Name = "listViewCursos";
            this.listViewCursos.Size = new System.Drawing.Size(393, 412);
            this.listViewCursos.TabIndex = 29;
            this.listViewCursos.UseCompatibleStateImageBehavior = false;
            this.listViewCursos.View = System.Windows.Forms.View.Details;
            this.listViewCursos.SelectedIndexChanged += new System.EventHandler(this.listViewCursos_SelectedIndexChanged);
            // 
            // DropCursosProf
            // 
            this.DropCursosProf.Controls.Add(this.CursosProf);
            this.DropCursosProf.Controls.Add(this.button1);
            this.DropCursosProf.Controls.Add(this.label6);
            this.DropCursosProf.Controls.Add(this.DtNascProf);
            this.DropCursosProf.Controls.Add(this.cpfProf);
            this.DropCursosProf.Controls.Add(this.TelProf);
            this.DropCursosProf.Controls.Add(this.EmailProf);
            this.DropCursosProf.Controls.Add(this.NomeProf);
            this.DropCursosProf.Controls.Add(this.label1);
            this.DropCursosProf.Controls.Add(this.label2);
            this.DropCursosProf.Controls.Add(this.label3);
            this.DropCursosProf.Controls.Add(this.label4);
            this.DropCursosProf.Controls.Add(this.label5);
            this.DropCursosProf.Controls.Add(this.listViewProfessores);
            this.DropCursosProf.Location = new System.Drawing.Point(4, 22);
            this.DropCursosProf.Name = "DropCursosProf";
            this.DropCursosProf.Padding = new System.Windows.Forms.Padding(3);
            this.DropCursosProf.Size = new System.Drawing.Size(768, 412);
            this.DropCursosProf.TabIndex = 1;
            this.DropCursosProf.Text = "Professores";
            this.DropCursosProf.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Curso:";
            // 
            // DtNascProf
            // 
            this.DtNascProf.Location = new System.Drawing.Point(130, 180);
            this.DtNascProf.Name = "DtNascProf";
            this.DtNascProf.Size = new System.Drawing.Size(219, 20);
            this.DtNascProf.TabIndex = 20;
            // 
            // cpfProf
            // 
            this.cpfProf.Location = new System.Drawing.Point(56, 136);
            this.cpfProf.Name = "cpfProf";
            this.cpfProf.Size = new System.Drawing.Size(293, 20);
            this.cpfProf.TabIndex = 18;
            // 
            // TelProf
            // 
            this.TelProf.Location = new System.Drawing.Point(75, 96);
            this.TelProf.Name = "TelProf";
            this.TelProf.Size = new System.Drawing.Size(274, 20);
            this.TelProf.TabIndex = 16;
            // 
            // EmailProf
            // 
            this.EmailProf.Location = new System.Drawing.Point(56, 58);
            this.EmailProf.Name = "EmailProf";
            this.EmailProf.Size = new System.Drawing.Size(293, 20);
            this.EmailProf.TabIndex = 14;
            // 
            // NomeProf
            // 
            this.NomeProf.Location = new System.Drawing.Point(56, 17);
            this.NomeProf.Name = "NomeProf";
            this.NomeProf.Size = new System.Drawing.Size(293, 20);
            this.NomeProf.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome:";
            // 
            // listViewProfessores
            // 
            this.listViewProfessores.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewProfessores.FullRowSelect = true;
            this.listViewProfessores.GridLines = true;
            this.listViewProfessores.HideSelection = false;
            this.listViewProfessores.Location = new System.Drawing.Point(369, 3);
            this.listViewProfessores.Name = "listViewProfessores";
            this.listViewProfessores.Size = new System.Drawing.Size(396, 406);
            this.listViewProfessores.TabIndex = 28;
            this.listViewProfessores.UseCompatibleStateImageBehavior = false;
            this.listViewProfessores.View = System.Windows.Forms.View.Details;
            this.listViewProfessores.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CursosAluno);
            this.tabPage1.Controls.Add(this.CheckListCursosAlunos);
            this.tabPage1.Controls.Add(this.DatNascTextBox);
            this.tabPage1.Controls.Add(this.CpfTextBox);
            this.tabPage1.Controls.Add(this.CelTextBox);
            this.tabPage1.Controls.Add(this.EmailTextBox);
            this.tabPage1.Controls.Add(this.NameTextBox);
            this.tabPage1.Controls.Add(this.DtNascLabel);
            this.tabPage1.Controls.Add(this.CpfLabel);
            this.tabPage1.Controls.Add(this.PhoneLabel);
            this.tabPage1.Controls.Add(this.CadAluno);
            this.tabPage1.Controls.Add(this.EmailLabel);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.listViewAlunos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alunos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // CursosAluno
            // 
            this.CursosAluno.AutoSize = true;
            this.CursosAluno.Location = new System.Drawing.Point(24, 233);
            this.CursosAluno.Name = "CursosAluno";
            this.CursosAluno.Size = new System.Drawing.Size(101, 13);
            this.CursosAluno.TabIndex = 13;
            this.CursosAluno.Text = "Cursos Disponíveis:";
            this.CursosAluno.Click += new System.EventHandler(this.label6_Click);
            // 
            // CheckListCursosAlunos
            // 
            this.CheckListCursosAlunos.CheckOnClick = true;
            this.CheckListCursosAlunos.FormattingEnabled = true;
            this.CheckListCursosAlunos.Location = new System.Drawing.Point(27, 249);
            this.CheckListCursosAlunos.Name = "CheckListCursosAlunos";
            this.CheckListCursosAlunos.Size = new System.Drawing.Size(329, 94);
            this.CheckListCursosAlunos.TabIndex = 12;
            this.CheckListCursosAlunos.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // DatNascTextBox
            // 
            this.DatNascTextBox.Location = new System.Drawing.Point(137, 189);
            this.DatNascTextBox.Name = "DatNascTextBox";
            this.DatNascTextBox.Size = new System.Drawing.Size(219, 20);
            this.DatNascTextBox.TabIndex = 10;
            this.DatNascTextBox.TextChanged += new System.EventHandler(this.DatNascTextBox_TextChanged);
            // 
            // CpfTextBox
            // 
            this.CpfTextBox.Location = new System.Drawing.Point(63, 145);
            this.CpfTextBox.Name = "CpfTextBox";
            this.CpfTextBox.Size = new System.Drawing.Size(293, 20);
            this.CpfTextBox.TabIndex = 8;
            // 
            // CelTextBox
            // 
            this.CelTextBox.Location = new System.Drawing.Point(82, 105);
            this.CelTextBox.Name = "CelTextBox";
            this.CelTextBox.Size = new System.Drawing.Size(274, 20);
            this.CelTextBox.TabIndex = 6;
            this.CelTextBox.TextChanged += new System.EventHandler(this.CelTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(63, 67);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(293, 20);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(63, 26);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(293, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // DtNascLabel
            // 
            this.DtNascLabel.AutoSize = true;
            this.DtNascLabel.Location = new System.Drawing.Point(24, 192);
            this.DtNascLabel.Name = "DtNascLabel";
            this.DtNascLabel.Size = new System.Drawing.Size(107, 13);
            this.DtNascLabel.TabIndex = 9;
            this.DtNascLabel.Text = "Data de Nascimento:";
            this.DtNascLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // CpfLabel
            // 
            this.CpfLabel.AutoSize = true;
            this.CpfLabel.Location = new System.Drawing.Point(24, 148);
            this.CpfLabel.Name = "CpfLabel";
            this.CpfLabel.Size = new System.Drawing.Size(30, 13);
            this.CpfLabel.TabIndex = 7;
            this.CpfLabel.Text = "CPF:";
            this.CpfLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(24, 108);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "Telefone:";
            // 
            // CadAluno
            // 
            this.CadAluno.Location = new System.Drawing.Point(281, 371);
            this.CadAluno.Name = "CadAluno";
            this.CadAluno.Size = new System.Drawing.Size(75, 23);
            this.CadAluno.TabIndex = 4;
            this.CadAluno.Text = "Cadastrar";
            this.CadAluno.UseVisualStyleBackColor = true;
            this.CadAluno.Click += new System.EventHandler(this.SendFormButton_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(24, 71);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email:";
            this.EmailLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(24, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Nome:";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // listViewAlunos
            // 
            this.listViewAlunos.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewAlunos.FullRowSelect = true;
            this.listViewAlunos.GridLines = true;
            this.listViewAlunos.HideSelection = false;
            this.listViewAlunos.Location = new System.Drawing.Point(385, 3);
            this.listViewAlunos.Name = "listViewAlunos";
            this.listViewAlunos.Size = new System.Drawing.Size(380, 406);
            this.listViewAlunos.TabIndex = 29;
            this.listViewAlunos.UseCompatibleStateImageBehavior = false;
            this.listViewAlunos.View = System.Windows.Forms.View.Details;
            // 
            // CadAlunos
            // 
            this.CadAlunos.Controls.Add(this.tabPage1);
            this.CadAlunos.Controls.Add(this.DropCursosProf);
            this.CadAlunos.Controls.Add(this.tabPage3);
            this.CadAlunos.Location = new System.Drawing.Point(12, 12);
            this.CadAlunos.Name = "CadAlunos";
            this.CadAlunos.SelectedIndex = 0;
            this.CadAlunos.Size = new System.Drawing.Size(776, 438);
            this.CadAlunos.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.CadAlunos.TabIndex = 6;
            // 
            // CursosProf
            // 
            this.CursosProf.CheckOnClick = true;
            this.CursosProf.FormattingEnabled = true;
            this.CursosProf.Location = new System.Drawing.Point(56, 227);
            this.CursosProf.Name = "CursosProf";
            this.CursosProf.Size = new System.Drawing.Size(293, 94);
            this.CursosProf.TabIndex = 29;
            this.CursosProf.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CadAlunos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.DropCursosProf.ResumeLayout(false);
            this.DropCursosProf.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.CadAlunos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage3;
        private Button CadCursos;
        private TextBox CHTextBox;
        private TextBox NomeCursoTxtBox;
        private Label CHCurso;
        private Label label9;
        private Label label10;
        private ListView listViewCursos;
        private TabPage DropCursosProf;
        private Button button1;
        private Label label6;
        private TextBox DtNascProf;
        private TextBox cpfProf;
        private TextBox TelProf;
        private TextBox EmailProf;
        private TextBox NomeProf;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView listViewProfessores;
        private TabPage tabPage1;
        private Label CursosAluno;
        private CheckedListBox CheckListCursosAlunos;
        private TextBox DatNascTextBox;
        private TextBox CpfTextBox;
        private TextBox CelTextBox;
        private TextBox EmailTextBox;
        private TextBox NameTextBox;
        private Label DtNascLabel;
        private Label CpfLabel;
        private Label PhoneLabel;
        private Button CadAluno;
        private Label EmailLabel;
        private Label NameLabel;
        private ListView listViewAlunos;
        private TabControl CadAlunos;
        private CheckedListBox CursosProf;
    }
}

