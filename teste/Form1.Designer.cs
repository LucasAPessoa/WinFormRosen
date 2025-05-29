using System;
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
            this.CadAlunos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CadAluno = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CelTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.CpfTextBox = new System.Windows.Forms.TextBox();
            this.CpfLabel = new System.Windows.Forms.Label();
            this.DatNascTextBox = new System.Windows.Forms.TextBox();
            this.DtNascLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CadAlunos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CadAlunos
            // 
            this.CadAlunos.Controls.Add(this.tabPage1);
            this.CadAlunos.Controls.Add(this.tabPage2);
            this.CadAlunos.Controls.Add(this.tabPage3);
            this.CadAlunos.Location = new System.Drawing.Point(12, 12);
            this.CadAlunos.Name = "CadAlunos";
            this.CadAlunos.SelectedIndex = 0;
            this.CadAlunos.Size = new System.Drawing.Size(776, 438);
            this.CadAlunos.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.CadAlunos.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DatNascTextBox);
            this.tabPage1.Controls.Add(this.DtNascLabel);
            this.tabPage1.Controls.Add(this.CpfTextBox);
            this.tabPage1.Controls.Add(this.CpfLabel);
            this.tabPage1.Controls.Add(this.CelTextBox);
            this.tabPage1.Controls.Add(this.PhoneLabel);
            this.tabPage1.Controls.Add(this.CadAluno);
            this.tabPage1.Controls.Add(this.EmailTextBox);
            this.tabPage1.Controls.Add(this.EmailLabel);
            this.tabPage1.Controls.Add(this.NameTextBox);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alunos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(63, 67);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(293, 20);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(63, 26);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(293, 20);
            this.NameTextBox.TabIndex = 1;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Professores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CadAluno
            // 
            this.CadAluno.Location = new System.Drawing.Point(668, 371);
            this.CadAluno.Name = "CadAluno";
            this.CadAluno.Size = new System.Drawing.Size(75, 23);
            this.CadAluno.TabIndex = 4;
            this.CadAluno.Text = "Cadastrar";
            this.CadAluno.UseVisualStyleBackColor = true;
            this.CadAluno.Click += new System.EventHandler(this.SendFormButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cursos";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // CelTextBox
            // 
            this.CelTextBox.Location = new System.Drawing.Point(82, 105);
            this.CelTextBox.Name = "CelTextBox";
            this.CelTextBox.Size = new System.Drawing.Size(274, 20);
            this.CelTextBox.TabIndex = 6;
            this.CelTextBox.TextChanged += new System.EventHandler(this.CelTextBox_TextChanged);
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
            // CpfTextBox
            // 
            this.CpfTextBox.Location = new System.Drawing.Point(63, 145);
            this.CpfTextBox.Name = "CpfTextBox";
            this.CpfTextBox.Size = new System.Drawing.Size(293, 20);
            this.CpfTextBox.TabIndex = 8;
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
            // DatNascTextBox
            // 
            this.DatNascTextBox.Location = new System.Drawing.Point(137, 189);
            this.DatNascTextBox.Name = "DatNascTextBox";
            this.DatNascTextBox.Size = new System.Drawing.Size(219, 20);
            this.DatNascTextBox.TabIndex = 10;
            this.DatNascTextBox.TextChanged += new System.EventHandler(this.DatNascTextBox_TextChanged);
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 20);
            this.textBox4.TabIndex = 20;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(56, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(293, 20);
            this.textBox5.TabIndex = 18;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(75, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(274, 20);
            this.textBox6.TabIndex = 16;
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
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(56, 58);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(293, 20);
            this.textBox7.TabIndex = 14;
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
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(56, 17);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(293, 20);
            this.textBox8.TabIndex = 12;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 13;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(57, 8);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(293, 20);
            this.textBox13.TabIndex = 12;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CadAlunos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CadAlunos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl CadAlunos;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label NameLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox NameTextBox;
        private Button CadAluno;
        private TabPage tabPage3;
        private TextBox DatNascTextBox;
        private Label DtNascLabel;
        private TextBox CpfTextBox;
        private Label CpfLabel;
        private TextBox CelTextBox;
        private Label PhoneLabel;
        private TextBox textBox4;
        private Label label1;
        private TextBox textBox5;
        private Label label2;
        private TextBox textBox6;
        private Label label3;
        private TextBox textBox7;
        private Label label4;
        private TextBox textBox8;
        private Label label5;
        private Label label9;
        private TextBox textBox13;
        private Label label10;
    }
}

