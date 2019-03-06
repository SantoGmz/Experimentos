using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

            //Contraseña
            //c8d15eeba0a0

            //Almacenamiento de variables//

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

            /*
                Validaciones
             * Que no esten vacios textBoxnombre.Text  textBoxcorreo.Text
             *  textBoxapellido.Text
             * 
            */

/*
            //validacion de nombre
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Tienes que ingresar tu nombre.");
                return;
            };

            //validacion de apellido
            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Tienes que ingresar tu apellido.");
                return;
            };
            //validacion de correo
            if (string.IsNullOrWhiteSpace(Correo))
            {
                MessageBox.Show("Tienes que ingresar tu Correo.");
                return;
            };
            //validacion de fecha
            if (string.IsNullOrWhiteSpace(Fecha))
            {
                MessageBox.Show("Tienes que ingresar tu fecha de nacimiento.");
                return;
            };
            //validacion de usuario
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Tienes que ingresar tu nombre de usuario.");
                return;
                ////Confirmacion de contraseñas

            };
            ///Selecion de genero
            if(rbsexohombre.Checked ==false && rbsexomujer.Checked == false)
            {
                MessageBox.Show("Debes seleccionar un genero");
            };

            ///contraseña diferente
            if (passwd != passwd2)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            };

            //validacion de contraseña1
            if (string.IsNullOrWhiteSpace(passwd))
            {
                MessageBox.Show("Tienes que ingresar tu contraseña.");
                return;
            };


            //validacion de contraseña2
            if (string.IsNullOrWhiteSpace(passwd2))
            {
                MessageBox.Show("Tienes que ingresar tu contraseña.");
                return;
            };

             //seleccion del pais
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Debes seleccionar un pais");
                return;
            }

            //estado
                if (comboBoxestado.SelectedIndex < 0)
            {
                MessageBox.Show("Debes seleccionar un estado");
                return;
            }
            /*
              if(rbsexohombre.Checked ==false && rbsexomujer.Checked == false)
            {
                MessageBox.Show("Debes seleccionar un genero");
            };

          

               if (checkBoxterminos.Checked == false)
            {
                MessageBox.Show("Debes aceptar los terminos");
            };

    */

            
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

            //agregar la columna al ListView
            listView1.Items.Add(Columna);

            /*
            var string_conexion = "server=localhost; user id=s4n70; password=wJ3RR9noH6PHrexS; database=registeruser";
            var conexion = new MySqlConnection(string_conexion);

            conexion.Open();
            var sql = "INSERT INTO usuario(id, nombre, apellido, usuario) VALUES(1, '"+nombre+"', '"+apellido+"', '"+usuario+"' )";
            insertardatos(sql, conexion); 
            */


            //Guardar en la base de datos

           // var sql = "INSERT INTO formulario (ID, Nombre, Apellido, fechan, Correo, Usuario,passwd, Genero, Pais, Estado)VALUES(1, "Santo", "Gmz", "1999/9/11", "mr.sansan777@gmail.com", "S4N70", 123456, "M", "Republica Dominina", "Jaja");";
            //var sql = "INSERT INTO formulario (ID, Nombre, Apellido, fechan, Correo, Usuario,passwd, Genero, Pais, Estado)VALUES('"+nombre+"')";
            var sql = "INSERT INTO formulario (ID, Nombre, Apellido, fechan, Correo, Usuario,passwd, Genero, Pais, Estado)VALUES( \"nombre\", \"apellido\");";
            System.Diagnostics.Trace.WriteLine(sql);
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBoxnombre.Clear();
            textBoxapellido.Clear();
            textBoxcorreo.Clear();
            textBoxuser.Clear();
            textBoxpasswd.Clear();
            textBoxpasswd2.Clear();
            comboBox1.Text = "--Seleccione una opcion--";
            comboBoxestado.Text = "--Seleccione una opcion--";
            rbsexomujer.Checked=false;
            rbsexohombre.Checked = false;
            checkBoxterminos.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Conexion a base de datos
        }

        private void mostrarusuarios_Click(object sender, EventArgs e)
        {
            try
            {
                var string_conexion = "server=localhost; user id=s4n70; password=; database=registeruser";
                var conexion = new MySqlConnection(string_conexion);

                conexion.Open();


                // string nombre, apellido, usuario;

               

                var sql = "SELECT * FROM formulario";
                seleccionarDatos(sql, conexion);

            } catch(MySqlException error)
            {
                MessageBox.Show("No se ha podido establecer conexion \n \n" + error.Message);
            }
        }

        private void seleccionarDatos(string sql, MySqlConnection conexion)
        {
            try
            {
                var adaptador = new MySqlDataAdapter(sql, conexion);

                var datos = new DataSet();
                adaptador.Fill(datos);

                dataGridView1.DataSource = datos.Tables[0];
            } catch(MySqlException error)
            {
                MessageBox.Show("Ha ocurrido un error en el select: \n \n " + error.Message);
            }
        }
        
        private void insertardatos(String sql, MySqlConnection conexion)
        {
            try{
                var comando = new MySqlCommand(sql, conexion);
                var insertado = comando.ExecuteNonQuery();
                if(insertado > 0)
                {
                    MessageBox.Show("Datos insertados");
                }
            }catch(MySqlException error)
            {
                MessageBox.Show("Error en el insert: \n \n" + error.Message);
            }
        } 

        //borrar datos
        private void borrarDatos(String sql, MySqlConnection conexion)
        {

        }

        //Actualizar
        private void ActualizarDatos(string sql, MySqlConnection conexion)
        {

        }
    

    
    }

}
