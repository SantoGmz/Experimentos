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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void registro_Load(object sender, EventArgs e)
        {
            ///Crear otro con usuario, Contraseña
            ///botones iniciar secion y crear cuenta
        }

        private void textBoxapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            //Almacenamiento de varibles//

            //Nombre
            string nombre = textBoxnombre.Text;
            //apellido
            string apellido = textBoxapellido.Text;
            //Correo
            string Correo = textBoxcorreo.Text;
            //fecha
            string Fecha = dateTimePicker1.Value.ToString();
            //Nombre de usuario
            string usuario = textBoxuser.Text;
            //Contraseña
            string passwd = textBoxpasswd.Text; 
            //Repeticion de contraseña
            string passwd2 = textBoxpasswd2.Text;
            //pais 
            int pais = comboBox1.SelectedIndex;
            //estado
            var estado = comboBoxestado.SelectedIndex;
            //terminos
            var terminos = Convert.ToBoolean(checkBoxterminos.Checked);
            //sexo M
            var genero = rbsexohombre.Checked;
            //sexo F
            var genero2 = rbsexomujer.Checked;


            //Agregar los datos al ListView
            ListViewItem Columna = new ListViewItem();

            Columna.Text = nombre;
            //Columna.SubItems.Add(nombre);
            Columna.SubItems.Add(apellido);
            Columna.SubItems.Add(Correo);
            Columna.SubItems.Add(Fecha.ToString());
            Columna.SubItems.Add(usuario);
            Columna.SubItems.Add(passwd);
            Columna.SubItems.Add(pais.ToString());
            Columna.SubItems.Add(estado.ToString());
            Columna.SubItems.Add(rbsexohombre.ToString());
            Columna.SubItems.Add(passwd);

            //agregar la colimna al ListView
            listView1.Items.Add(Columna);




        }
    }
}
