using Entidades;
using Vista;

namespace vistaWf
{
    public partial class Login : Form
    {
        List<Usuarios> listaUser;

        public Login()
        {
            InitializeComponent();
            listaUser = new List<Usuarios>();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.listaUser = Deserializador.DeserializarUsuarios();
            if (!File.Exists("simulacionPasajeros.json"))
            {
                Serializador.SerializarPasajeros(Sistema.PasajerosHardcodeados());
            }
            else
            {
                Sistema.ListaDePasajeros = Deserializador.DeserializarPasajeros();
            }
            if (!File.Exists("simulacionVuelos.json"))
            {
                Serializador.SerializarVuelos(Sistema.VuelosHardcodeados());
            }
            else
            {
                Sistema.ListaDeVuelos = Deserializador.DeserializarVuelos();
            }
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (listaUser != null)
            {
                foreach (Usuarios item in listaUser)
                {
                    if (txtUser.Text == item.correo && txtContra.Text == item.clave)
                    {
                        if (item.perfil == "vendedor")
                        {
                            vistaVendedor vendedor = new vistaVendedor();
                            vendedor.ShowDialog();
                            this.Hide();
                            //this.Close();
                        }
                        if (item.perfil == "supervisor")
                        {
                            vistaSupervisor supervisor = new vistaSupervisor();
                            supervisor.ShowDialog();
                            this.Hide();
                            //this.Close();
                        }
                    }
                }
            }

        }

        private void btnRellenarVendedor_Click(object sender, EventArgs e)
        {
            txtUser.Text = "cgorgen@vendedor.com";
            txtContra.Text = "123abc45";
        }

        private void btnRellenarSupervisor_Click(object sender, EventArgs e)
        {
            txtUser.Text = "trobinson@super.com";
            txtContra.Text = "12345678";
        }

        private void btnRellenarAdmin_Click(object sender, EventArgs e)
        {
            txtUser.Text = "admin@admin.com";
            txtContra.Text = "12345678";
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}