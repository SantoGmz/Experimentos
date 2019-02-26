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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
              lugar donde se almacena informacin que cambia
              var edad = 23;
              MessageBox.Show("Su edad es: " + edad);
              edad = 15;
              MessageBox.Show("Su edad es: " + edad);
   
              const int impuesto = 18;
              MessageBox.Show("Su impuesto es: " + impuesto);
              impuesto = 21;
              MessageBox.Show("Su impuesto es: " + impuesto);
           

              tipos de datos numericos
                  int dia = 7;
               float porciento = 0.54;
                double herencia = 54545454545454;
                byte numerobyte = 1 ;
                short numeroshort2 = 255; //Convert.Toin16

                int numeroInt= 1; //Conver.Toint32
              
                long numerolong = 9223372036854775807  ;//Convert.ToInt64
                long numerolong2 = 9223372036854775804;
              
              Tipos de datos String
              char caracter = '@'; 
              string nacionalidad = "Cristian Nunez";

              char simbolo '@'; //Incorrecto
              string nacionalidad = 'Dominicano'; //Incorrecto
        
              Tipos de datos booleanos
              bool estaCasado = false;
              bool poseetarjetacredito;
              ////////////////////////////////////////////////////////////////////////////////

              */




        }

        //Funcion para agregar texto en textbox
        private void agregartxt(string texto)
        {
            Trace.WriteLine("Este codigo es de la funcion");
            //string texto = "1";
            //textBoxPantalla.Text = textBoxPantalla.Text
            textBoxPantalla.Text += texto;
           // textBoxPantalla.Text = textBoxPantalla.Text + texto;


            
        }


        private void textBoxPantalla_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //textBoxPantalla.Text = textBoxPantalla.Text + "7";
            agregartxt("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //textBoxPantalla.Text = textBoxPantalla.Text + "8";
            agregartxt("8");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
          //  textBoxPantalla.Text = textBoxPantalla.Text + "4";
            agregartxt("4");
        }


        private void btn6_Click(object sender, EventArgs e)
        {
            agregartxt("6");
            //textBoxPantalla.Text = textBoxPantalla.Text + "6";
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            //textBoxPantalla.Text = textBoxPantalla.Text + "0";
            agregartxt("0");
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            //textBoxPantalla.Text = textBoxPantalla.Text + ".";
            agregartxt(".");
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            
        }

        private void btnresta_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            agregartxt("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //textBoxPantalla.Text = textBoxPantalla.Text + "2"; 
            agregartxt("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            agregartxt("3");
            //textBoxPantalla.Text = textBoxPantalla.Text + "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //textBoxPantalla.Text = textBoxPantalla.Text + "5";
            agregartxt("5");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
           // textBoxPantalla.Text = textBoxPantalla.Text + "9";
            agregartxt("9");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //OBTENER EL VALOR DE LA TECLA PRESIONADA
              /*  MessageBox.Show("El codigo interno es: " + e.KeyChar); */

            //Mostrar por consola de programador el valor de la tecla presionada
           

            }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            //Mostrar por consola de programador el valor de la tecla presionada
            Trace.WriteLine("la tecla presionada es: " + e.KeyValue);

            /*
            if(e.KeyValue == 96 ) //0
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "0";
            }
            else if (e.KeyValue == 97 || e.KeyValue == 49)//1
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "1";
            }
            else if (e.KeyValue == 98 || e.KeyValue == 50)//2
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "2";
            }
            else if (e.KeyValue == 99 || e.KeyValue == 51)//3
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "3";
            }
            else if (e.KeyValue == 100 || e.KeyValue == 52)//4
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "4";
            }
            else if (e.KeyValue == 101 || e.KeyValue == 53) //5
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "5";
            }
            else if (e.KeyValue == 102 || e.KeyValue == 54) //6
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "6";
            }
            else if (e.KeyValue == 103 || e.KeyValue == 55)//7
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "7";
            }
            else if (e.KeyValue == 104 || e.KeyValue == 56)//8
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "8";
            }
            else if (e.KeyValue == 105 || e.KeyValue == 56)//9
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "9";
            }
            else if (e.KeyValue == 105 || e.KeyValue == 57)//9
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "9";
            }
            else if (e.KeyValue == 107)//+
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "+";
            }
            else if (e.KeyValue == 109)//-
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "-";
            }
            else if (e.KeyValue == 106)//*
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "*";
            }
            else if (e.KeyValue == 111)// /
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "/";
            } if (e.KeyValue == 8)// BORRAR
            {
                textBoxPantalla.Text = "";
            }
            */

            switch (e.KeyValue)
            { //NumPad
                case 96: //num 0
                textBoxPantalla.Text = textBoxPantalla.Text + "0";
                break;
                case 97: //num 1
                textBoxPantalla.Text = textBoxPantalla.Text + "1";
                break;
                case 98: //num 2
                textBoxPantalla.Text = textBoxPantalla.Text + "2";
                break;
                case 99: //num 3
                textBoxPantalla.Text = textBoxPantalla.Text + "3";
                break;
                case 100: //num 4
                textBoxPantalla.Text = textBoxPantalla.Text + "4";
                break;
                case 101: //num 5
                textBoxPantalla.Text = textBoxPantalla.Text + "5";
                break;
                case 102: //num 6
                textBoxPantalla.Text = textBoxPantalla.Text + "6";
                break;
                case 103: //num 7
                textBoxPantalla.Text = textBoxPantalla.Text + "7";
                break;
                case 104: //num 8
                textBoxPantalla.Text = textBoxPantalla.Text + "8";
                break;
                case 105: //num 9
                textBoxPantalla.Text = textBoxPantalla.Text + "9";
                break;
                case 107: //operacion +
                textBoxPantalla.Text = textBoxPantalla.Text + "+";
                break;
                case 109: //operacion -
                textBoxPantalla.Text = textBoxPantalla.Text + "-";
                break;
                case 106: //operacion *
                textBoxPantalla.Text = textBoxPantalla.Text + "*";
                break;
                case 111: //operacion /
                textBoxPantalla.Text = textBoxPantalla.Text + "/";
                break;
                case 67: //operacion clear
                textBoxPantalla.Text = "";
                break;
                ////////////---Other_teclado---////////////
                case 48: //num 0
                textBoxPantalla.Text = textBoxPantalla.Text + "0";
                break;
                case 49: //num 1
                textBoxPantalla.Text = textBoxPantalla.Text + "1";
                break;
                case 50: //num 2
                textBoxPantalla.Text = textBoxPantalla.Text + "2";
                break;
                case 51: //num 3
                textBoxPantalla.Text = textBoxPantalla.Text + "3";
                break;
                case 52: //num 4
                textBoxPantalla.Text = textBoxPantalla.Text + "4";
                break;
                case 53: //num 5
                textBoxPantalla.Text = textBoxPantalla.Text + "5";
                break;
                case 54: //num 6
                textBoxPantalla.Text = textBoxPantalla.Text + "6";
                break;
                case 55: //num 7
                textBoxPantalla.Text = textBoxPantalla.Text + "7";
                break;
                case 56: //num 8
                textBoxPantalla.Text = textBoxPantalla.Text + "8";
                break;
                case 57: //num 9
                textBoxPantalla.Text = textBoxPantalla.Text + "9";
                break;
                default:// Por defecto se ejecuta esto
                    //codigo
                break;





            }




        }

        private void buttonclear_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = "";
            

        }

        }
        
    }

