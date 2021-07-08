using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Form1 : Form
    {
        Academia academia;
        Pessoa pessoa;
        Aluno aluno;
        public Form1()
        {
            InitializeComponent();
            academia = new Academia();
        }

        private void txtNome(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo(object sender, EventArgs e)
        {
            academia.adicionarAluno(textBox1.Text, maskedTextBox2.Text, maskedTextBox3.Text, maskedTextBox6.Text, textBox2.Text,
                int.Parse(maskedTextBox5.Text), textBox3.Text, textBox4.Text, comboBox1.Text, maskedTextBox4.Text);
            AtualizaListBox();
        }

        private void AtualizaListBox()
        {
            listBox1.Items.Clear();
            foreach (var aluno in academia.Alunos)
            {
                listBox1.Items.Add(aluno);
            }
        }

        private void btnPagar(object sender, EventArgs e)
        {
            
        }
    }
}
