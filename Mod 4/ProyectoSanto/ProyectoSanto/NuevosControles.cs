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
    public partial class NuevosControles : Form
    {
        public NuevosControles()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ir a Gogole.com
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(numericUpDown1.Value);
            int blue = Convert.ToInt32(numericUpDown2.Value);
            int green = Convert.ToInt32(numericUpDown3.Value);
            //Colores al formulario
            this.BackColor = Color.FromArgb(100, 200, 0);

            //Cambiar fondo a la pestaña
            tabControl1.TabPages[3].BackColor = Color.FromArgb(red, green, blue);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            label4.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum) 
            {
                MessageBox.Show("Hola");
            }
        }
    }
}
