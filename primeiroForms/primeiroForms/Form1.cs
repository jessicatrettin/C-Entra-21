using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
               
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{n1 + n2}");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{n1 - n2}");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{n1 * n2}");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{n1 / n2}");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
