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
    public partial class InicioS : Form
    {
        public InicioS()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new registro().Show();
            this.Close();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
          //  this.Close();
        }
    }
}
