using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Exercício1_Q4
{
    public partial class Form1 : Form
    {
        int num1, num2, num3, num4;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }   

        private void txtNumero3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumero1_Leave(object sender, EventArgs e)
        {
            num1 = int.Parse(txtNumero1.Text);
        }

        private void txtNumero2_Leave(object sender, EventArgs e)
        {
            num2 = int.Parse(txtNumero2.Text);
        }

        private void txtNumero3_Leave(object sender, EventArgs e)
        {
            num3 = int.Parse(txtNumero3.Text);
        }

        private void txtNumero4_Leave(object sender, EventArgs e)
        {
            num4 = int.Parse(txtNumero4.Text);
        }

        private void btnAdicaoo(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 1)
            {
                listBox1.Items.Add("ADIÇÃO");
                listBox1.Items.Add($"{num1} + {num2} = {num1 + num2}");
                listBox1.Items.Add($"{num1} + {num3} = {num1 + num3}");
                listBox1.Items.Add($"{num1} + {num4} = {num1 + num4}");
                listBox1.Items.Add($"{num2} + {num3} = {num2 + num3}");
                listBox1.Items.Add($"{num2} + {num4} = {num2 + num4}");
                listBox1.Items.Add($"{num3} + {num4} = {num3 + num4}");
            }
            listBox1.Visible = true;
        }

        private void btnMultiplicacao(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 1)
            {
                listBox2.Items.Add("MULTIPLICAÇÃO");
                listBox2.Items.Add($"{num1} x {num2} = {num1 * num2}");
                listBox2.Items.Add($"{num1} x {num3} = {num1 * num3}");
                listBox2.Items.Add($"{num1} x {num4} = {num1 * num4}");
                listBox2.Items.Add($"{num2} x {num3} = {num2 * num3}");
                listBox2.Items.Add($"{num2} x {num4} = {num2 * num4}");
                listBox2.Items.Add($"{num3} x {num4} = {num3 * num4}");
            }
            listBox2.Visible = true;
        }

        private void btnZerar(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
            txtNumero4.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void txtNumero4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxAdicao(object sender, EventArgs e)
        {
         
        }

        private void ListBoxMultiplicacao(object sender, EventArgs e)
        {
 
        }
    }
}
