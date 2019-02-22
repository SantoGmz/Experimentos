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
    public partial class diasemana : Form
    {
        public diasemana()
        {
            InitializeComponent();
        }

        private void bntver_Click(object sender, EventArgs e)
        {
            byte dia = Convert.ToByte(textBoxdia.Text);


            if (dia == 1)
            {MessageBox.Show("Domingo");}
            else if (dia == 2)
            { MessageBox.Show("Lunes");}
            else if (dia ==3)
            { MessageBox.Show("Martes");}
            else if (dia == 4)
            { MessageBox.Show("Miercoles"); }
            else
            {
                MessageBox.Show("Dia invalido");
            }












            
            /*
            ///////////////////////////
            if(dia == 1)
            {MessageBox.Show("Domingo");}
            else
            {MessageBox.Show("1");}
            ///////////////////////////
            if (dia == 2)
            {MessageBox.Show("Lunes");}
            else
            {MessageBox.Show("2");}
            ///////////////////////////
            if (dia == 3)
            {MessageBox.Show("Martes");}
            else
            {MessageBox.Show("3");}
            ///////////////////////////
            if (dia == 4)
            { MessageBox.Show("Miercoles"); }
            else
            { MessageBox.Show("4"); }
            ///////////////////////////
           */
        }

        private void buttonverificar_Click(object sender, EventArgs e)
        {
            string sexo = textBoxsexo.Text;
            if(sexo=="m" || sexo =="M")
            {
                MessageBox.Show("Masculino");
            }
            else if(sexo== "f" || sexo=="F"){
                MessageBox.Show("Femenino");
            }
        }
        
        }
    }

