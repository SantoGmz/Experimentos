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
    public partial class Ciclos : Form
    {
        public Ciclos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Ciclos2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(textBox1.Text);

            for(int i=1; i<=12; i++)
            {
                MessageBox.Show(edad+ "*" +i + "=" + (i*edad));
            }
        }

 
        }
    }

