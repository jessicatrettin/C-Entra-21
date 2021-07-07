using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovaConta(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.numero = 9079637;
            conta.titular = "Jéssica";
            conta.saldo = 50.0;

            MessageBox.Show($"Número = {conta.numero} | Titular = {conta.titular} | Saldo = {conta.saldo}");

            conta.Saca();

            MessageBox.Show($"Número = {conta.numero} | Titular = {conta.titular} | Saldo = {conta.saldo}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
