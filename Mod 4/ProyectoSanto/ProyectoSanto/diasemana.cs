using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoSanto
{
    public partial class diasemana : Form
    {
        public diasemana()
        {
            InitializeComponent();
        }

        //Eficientizar cosas
        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show("el dia de la semana es: " + mensaje);
        }

        // Otra funcion de verificar genero
        private void VerificarGenero(string sexo2)
        {
            switch (sexo2)
            {
                case "m":
                    MessageBox.Show("Masculino");
                    break;
                case "f":
                    MessageBox.Show("Femenino");
                    break;
                case "M":
                    MessageBox.Show("Masculino");
                    break;
                case "F":
                    MessageBox.Show("Femenino");
                    break;
                default:
                      MessageBox.Show("Sexo no reconocido");
                    break;


            }
        }
        
        private void Saludar(string nombre)
        {
            MessageBox.Show("Hola, " + nombre);
        }

        private void sumar(double numero1, double numero2)
        {
           // MessageBox.Show("El numero1 es: " + numero1);
          //  MessageBox.Show("El numero2 es: " + numero2);
        }

        private void bntver_Click(object sender, EventArgs e)
        {
            //var resultado = String.IsNullOrWhiteSpace("sdsadffsda");

            if(String.IsNullOrWhiteSpace(textBoxdia.Text))
            {
                MessageBox.Show("Digite un numero");
                return;
            }

            byte dia = Convert.ToByte(textBoxdia.Text);
            

            if (dia <=0 || dia >8 )
            {
                MessageBox.Show("Dia no valido.");
                return;
            };

            string[] dias = {"Domingo","Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Dominles"}; 
            
            for (int i = 0; i < 7; i++)
            {
                MessageBox.Show(dias[dia]);
            }
                return; 

            

            /*
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

            

            switch(dia){
                case 1:
                 mostrarMensaje("Domingo");
                 break;
                case 2:
                 mostrarMensaje("Lunes");
                 break;
                case 3:
                 mostrarMensaje("Martes");
                 break;
                case 4:
                 mostrarMensaje("Miercoles");
                 break;
                case 5:
                 mostrarMensaje("Jueves");
                 break;
                case 6:
                 mostrarMensaje("Viernes");
                 break;
                case 7:
                 mostrarMensaje("Sabado");
                 break;
                default:
                 mostrarMensaje("Dia Invalido");
                    break;
            */
            
               
            
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
            /*
            if(sexo=="m" || sexo =="M")
            {
                MessageBox.Show("Masculino");
            }
            else if(sexo== "f" || sexo=="F"){
                MessageBox.Show("Femenino");
            }*/

            VerificarGenero(sexo);
           
        }

        private void diasemana_Load(object sender, EventArgs e)
        {
        //          Sumar dos numeros
            sumar(10, 3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sexo2 = textBox1.Text;

            VerificarGenero(sexo2);

            /*
            if (Sexo == "M" || Sexo == "m")
            {
                mostrarMensaje("Masculino");
            }else if(Sexo == "F" || Sexo =="f"){
                MessageBox.Show("Femenino");
            }
            else{
                MessageBox.Show("Sexo desconocido");
            }*/

        }

        private void buttonform_Click(object sender, EventArgs e)
        {
            
            string[] dia = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };

            for (int i = 0; i < 7; i++ )
            {
                label4.Text += "\n"+ dia[i];
            };
            


            /*
            for (int i = 0; i < 7; i++)
            {
                string[] dia = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };

                label4.Text += "\n" + dia[i];
            };
            */
        }
        
        }
    }

