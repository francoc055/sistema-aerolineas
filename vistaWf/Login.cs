using Entidades;
using Vista;

namespace vistaWf
{
    public partial class Login : Form
    {
        static List<Usuarios> listaUser;
        static string correoUser;
        static List<Usuarios> registroUsuarios;

        static public List<Usuarios> ListaUser { get => listaUser; }
        static public string CorreoUser { get => correoUser; }
        public static List<Usuarios> RegistroUsuarios { get => registroUsuarios; set => registroUsuarios = value; }

        public Login()
        {
            InitializeComponent();
            listaUser = new List<Usuarios>();
            registroUsuarios = new List<Usuarios>();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            listaUser = Deserializador.DeserializarUsuarios();
            if (!File.Exists("usuarios.log"))
            {
                Serializador.SerializarRegistros(registroUsuarios);
                registroUsuarios = Deserializador.DeserializarRegistros();
            }
            else
            {
                registroUsuarios = Deserializador.DeserializarRegistros();
            }

            if (!File.Exists("simulacionPasajeros.json"))
            {
                Serializador.SerializarPasajeros(Sistema.PasajerosHardcodeados());
                Sistema.ListaDePasajeros = Deserializador.DeserializarPasajeros();
            }
            else
            {
                Sistema.ListaDePasajeros = Deserializador.DeserializarPasajeros();
            }

            if (!File.Exists("simulacionAeronaves.json"))
            {
                Serializador.SerializarAeronaves(Sistema.AeronavesHardcodeados());
                Sistema.ListaDeAeronaves = Deserializador.DeserializarAeronaves();
            }
            else
            {
                Sistema.ListaDeAeronaves = Deserializador.DeserializarAeronaves();
            }

            if (!File.Exists("simulacionVuelos.json"))
            {
                Serializador.SerializarVuelos(Sistema.VuelosHardcodeados());
                Sistema.ListaDeVuelos = Deserializador.DeserializarVuelos();
            }
            else
            {
                Sistema.ListaDeVuelos = Deserializador.DeserializarVuelos();
            }


        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ListaUser != null)
            {
                foreach (Usuarios item in listaUser)
                {
                    if (txtUser.Text == item.correo && txtContra.Text == item.clave)
                    {
                        if (item.perfil == "vendedor")
                        {
                            correoUser = item.correo;
                            vistaVendedor vendedor = new vistaVendedor();
                            vendedor.ShowDialog();
                            this.Hide();
                            //this.Close();
                        }
                        else if (item.perfil == "supervisor")
                        {
                            correoUser = item.correo;
                            vistaSupervisor supervisor = new vistaSupervisor();
                            supervisor.ShowDialog();
                            this.Hide();
                            //this.Close();
                        }
                        else if (item.perfil == "administrador")
                        {
                            correoUser = item.correo;
                            vistaAdministrador administrador = new vistaAdministrador();
                            administrador.ShowDialog();
                            this.Hide();
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}