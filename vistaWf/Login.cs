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
            if(!File.Exists("simulacionPasajeros.json"))
            {
                Serializador.SerializarPasajeros(Sistema.ListaDePasajeros);
            }
            else
            {
                Deserializador.DeserializarPasajeros();
            }
            Serializador.SerializarVuelos();
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (listaUser != null)
            {
                foreach (Usuarios item in listaUser)
                {
                    if (txtUser.Text == item.nombre && txtContra.Text == item.clave)
                    {
                        if (item.perfil == "vendedor")
                        {

                            //VistaUsuario vendedor = new VistaUsuario();
                            //vendedor.Show();
                            vistaVendedor vendedor = new vistaVendedor();
                            vendedor.ShowDialog();
                            //vendedor.Hide();
                            this.Close();
                            //break;
                        }

                    }
                }
            }

        }
    }
}