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
    public partial class Ciclos2 : Form
    {
        public Ciclos2()
        {
            InitializeComponent();
        }

        private void Ciclos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxFor.Text))
            {
                MessageBox.Show("Debes ingresar un valor Para este ciclo");
                return;

            }
            var num = Convert.ToInt32(textBoxFor.Text);

            for (int iteracion = 0; iteracion < num; iteracion++)
            {
                MessageBox.Show("(" + iteracion + ") Hola mundo");
            }

            /*
            for(int iterador =1; iterador <=5; iterador++)
                {
                    
                 }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Ciclos().Show();
        }
    }
}
