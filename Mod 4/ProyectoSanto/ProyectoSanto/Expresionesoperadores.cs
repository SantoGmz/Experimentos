using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSanto
{
    public partial class Expresionesoperadores : Form
    {
        public Expresionesoperadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtener
            string nombre = textBox1.Text;

            lblsaludo.Text += nombre;
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(textBoxv1.Text);
            int valor2 = Convert.ToInt32(textBoxv2.Text);
            MessageBox.Show("Su resultado es: " + (valor1 + valor2));

            textBoxv1.Clear();
            textBoxv2.Clear();

        }
    }
}
