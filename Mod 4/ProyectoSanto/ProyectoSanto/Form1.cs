﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lugar donde se almacena informacin que cambia
            /*var edad = 23;
            MessageBox.Show("Su edad es: " + edad);
            edad = 15;
            MessageBox.Show("Su edad es: " + edad);
             */
            //
            /*
            const int impuesto = 18;
            MessageBox.Show("Su impuesto es: " + impuesto);
            impuesto = 21;
            MessageBox.Show("Su impuesto es: " + impuesto);
            */

            //tipos de datos numericos
                int dia = 7;
             // float porciento = 0.54;
              double herencia = 54545454545454;
              byte numerobyte = 1 ;
              short numeroshort2 = 255; //Convert.Toin16

              int numeroInt= 1; //Conver.Toint32
              
              long numerolong = 9223372036854775807  ;//Convert.ToInt64
              long numerolong2 = 9223372036854775804;
              
            //Tipos de datos String
            char caracter = '@'; 
            string nacionalidad = "Cristian Nunez";

            //char simbolo '@'; //Incorrecto
            //string nacionalidad = 'Dominicano'; //Incorrecto
        
            //Tipos de datos booleanos
            bool estaCasado = false;
            bool poseetarjetacredito;
            ////////////////////////////////////////////////////////////////////////////////
             






        }


        private void textBoxPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + "8";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + "4";
        }



        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + "6";
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + ".";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            
        }

        private void btnresta_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + "1"; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + "5";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = textBoxPantalla.Text + "9";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //OBTENER EL VALOR DE LA TECLA PRESIONADA
                MessageBox.Show("El codigo interno es: " + e.KeyChar);

            }

        }
        
    }

