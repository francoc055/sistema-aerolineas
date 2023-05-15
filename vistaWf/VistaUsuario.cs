using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vistaWf;

namespace Vista
{
    public partial class VistaUsuario : Form
    {

        public VistaUsuario()
        {
            InitializeComponent();
        }



        protected virtual void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }
    }
}
