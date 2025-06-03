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
            // List<Cursos> cursosSelecionados = CheckListCursosAlunos.CheckedItems
            // .Cast<Cursos>()
            // .ToList();

            //Alunos alunoteste = new Alunos(NameTextBox.Text, EmailTextBox.Text, CelTextBox.Text, CpfTextBox.Text, DatNascTextBox.Text, cursosSelecionados);
            //Alunos.ListaAlunos.Add(new Alunos(NameTextBox.Text, EmailTextBox.Text, CelTextBox.Text, CpfTextBox.Text, DatNascTextBox.Text, cursosSelecionados));
            //MessageBox.Show("Aluno cadastrado com sucesso!");
            try
            {
                List<Cursos> cursosSelecionados = CheckListCursosAlunos.CheckedItems
                    .Cast<Cursos>()
                    .ToList();

                Alunos novoAluno = new Alunos(
                    NameTextBox.Text,
                    EmailTextBox.Text,
                    CelTextBox.Text,
                    CpfTextBox.Text,
                    DatNascTextBox.Text,
                    cursosSelecionados
                );

                Alunos.ListaAlunos.Add(novoAluno);
                MessageBox.Show("Aluno cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar aluno: " + ex.Message);
            }

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

        private void ListarAlunos(object sender, EventArgs e)
        {

            MessageBox.Show("Lista de Alunos:\n" + string.Join("\n", Alunos.ListaAlunos.Select(a => $"{a.Matricula} - {a.Name} - {a.Email} - {a.CPF} - {a.Phone} - {a.DataNascimento:dd/MM/yyyy} - Cursos: {string.Join(", ", a.CursosMatriculados.Select(c => c.Nome))}"
  )));
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarCurso(object sender, EventArgs e)
        {
            try
            {
                int cargaHoraria = int.Parse(CHTextBox.Text);
                Cursos curso = new Cursos(NomeCursoTxtBox.Text, cargaHoraria);

                Cursos.ListaCursos.Add(curso);
                MessageBox.Show("Curso cadastrado com sucesso!");

                CursosProf.Items.Clear();
                CheckListCursosAlunos.Items.Clear();

                foreach (Cursos c in Cursos.ListaCursos)
                {
                    CursosProf.Items.Add(c);
                    CheckListCursosAlunos.Items.Add(c);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("A carga horária deve ser um número inteiro válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar curso:\n" + ex.Message);
            }
        }

        private void ListarCursos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de Cursos:\n" + string.Join("\n", Cursos.ListaCursos.Select(a => $"{a.Nome} - {a.CargaHoraria}")));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursos cursoProfessor = (Cursos)CursosProf.SelectedItem;

                Professores professor = new Professores(
                    NomeProf.Text,
                    EmailProf.Text,
                    TelProf.Text,
                    cpfProf.Text,
                    DtNascProf.Text,
                    cursoProfessor
                );

                MessageBox.Show("Professor cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar professor:\n" + ex.Message);
            }
        }


        private void CursosProf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListarProfessores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de Professores:\n" + string.Join("\n", Professores.ListaProfessores.Select(a => $"{a.Name} - {a.Email} - {a.CPF} - {a.Phone} - {a.DataNascimento} - {Cursos.ListaCursos.Where(curso => curso.Professor.Matricula == a.Matricula).Select(curso => curso.Nome).FirstOrDefault()}")));
        }
    }
}
