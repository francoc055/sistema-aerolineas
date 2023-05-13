using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class vistaSupervisor : vistaVendedor
    {
        public vistaSupervisor()
        {
            InitializeComponent();
        }

        private void vistaSupervisor_Load(object sender, EventArgs e)
        {
            labelCambiar.Text = "Supervisor";
            tabControl1.SelectedTab = tabPage2;
            //tabPage1.Enabled = false;
        }

        protected override void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage1 || e.TabPage == tabPage3)
            {
                MessageBox.Show("No puedes acceder ni realizar acciones ya que no eres Vendedor");
                e.Cancel = true;
            }
            else if (e.TabPage == tabPage5 || e.TabPage == tabPage6)
            {
                MessageBox.Show("No puedes acceder ni realizar acciones ya que no eres Administrador");
                e.Cancel = true;
            }
        }

        protected override void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            base.btnCerrarSesion_Click(sender,e);
        }
    }
}
