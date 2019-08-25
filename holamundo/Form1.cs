using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holamundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpresioname_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola" + txtnombre.Text);
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            string valor1 = txtnumero1.Text; 
            string valor2 = txtnumero2.Text;
            int numero1 = int.Parse(valor1);
            int numero2 = int.Parse(valor2);
            int total = numero1 + numero2;
            lbltotal.Text = total.ToString();

        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            string valor1 = txtnumero1.Text;
            string valor2 = txtnumero2.Text;
            int numero1 = int.Parse(valor1);
            int numero2 = int.Parse(valor2);
            int total = numero1 - numero2;
            lbltotal.Text = total.ToString();

        }

        private void btnmultipliacar_Click(object sender, EventArgs e)
        {
            string valor1 = txtnumero1.Text;
            string valor2 = txtnumero2.Text;
            int numero1 = int.Parse(valor1);
            int numero2 = int.Parse(valor2);
            int total = numero1 * numero2;
            lbltotal.Text = total.ToString();

        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            string valor1 = txtnumero1.Text;
            string valor2 = txtnumero2.Text;
            int numero1 = int.Parse(valor1);
            int numero2 = int.Parse(valor2);
            int total = numero1 / numero2;
            lbltotal.Text = total.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
