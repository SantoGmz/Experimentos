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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            
            new Form1().Show();
        }

        private void btnseman_Click(object sender, EventArgs e)
        {
            new diasemana().Show();
        }

        private void inicio_Deactivate(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Expresionesoperadores().Show();
        }

        private void inicio_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void buttonCiclos_Click(object sender, EventArgs e)
        {
            new Ciclos2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new InicioS().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new NuevosControles().Show();
        }
    }
}
