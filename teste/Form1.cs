using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.model.classes;

namespace teste
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendFormButton_Click(object sender, EventArgs e)
        {
           Alunos alunoteste = new Alunos(NameTextBox.Text, EmailTextBox.Text, CelTextBox.Text, CpfTextBox.Text, DatNascTextBox.Text);
            alunoteste.ExibirDados();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void DatNascTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CelTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
