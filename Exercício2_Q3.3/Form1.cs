using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício2_Q3._3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPesoIdeal(object sender, EventArgs e)
        {
            double h;
            h = double.Parse(textAltura.Text);
            
            if (radioBtnFeminino.Checked == true)
                MessageBox.Show($"{(62.1 * (h / 100)) - 44.7} kg");

            if (radioBtnMasculino.Checked == true)
                MessageBox.Show($"{(72.7 * (h / 100)) - 58} kg");
        }

        private void textAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
