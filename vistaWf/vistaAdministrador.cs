using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vistaWf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class vistaAdministrador : VistaUsuario
    {
        public vistaAdministrador()
        {
            InitializeComponent();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage1 || e.TabPage == tabPage2 || e.TabPage == tabPage3 || e.TabPage == tabPage4)
            {
                MessageBox.Show("No puedes ingresar ni realizar acciones ya que no eres Vendedor/Supervisor");
                e.Cancel = true;
            }
        }

        private void vistaAdministrador_Load(object sender, EventArgs e)
        {
            //labelCambiar.Text = "Administrador";
            CargarNombreOperador();
            tabControl1.SelectedTab = tabPage5;

            //---aeronave---//
            cargarDataAeronave();
            btnModificarAvion.Enabled = false;
            btnEliminarAvion.Enabled = false;
            //---aeronave---//


        }
        //---------------CRUD aeronave---------------//
        //cargo nombre y apellido del operador
        private void CargarNombreOperador()
        {
            foreach (Usuarios item in Login.ListaUser)
            {
                if (item.correo == Login.CorreoUser)
                {
                    labelCambiar.Text = $"Administrador {item.nombre} {item.apellido}";
                    break;
                }
            }
        }

        //cargo datagrid
        private void cargarDataAeronave()
        {
            foreach (Aeronave item in Sistema.ListaDeAeronaves)
            {
                DataGridViewRow filaAeronave = new DataGridViewRow();
                filaAeronave.CreateCells(dataGridViewAeronave);
                filaAeronave.Cells[0].Value = item.Matricula;
                filaAeronave.Cells[1].Value = item.CantidadDeAsientos;
                filaAeronave.Cells[2].Value = item.CantidadDeBanios;
                filaAeronave.Cells[3].Value = item.ServicioDeInternet;
                filaAeronave.Cells[4].Value = item.OfreceComida;
                filaAeronave.Cells[5].Value = item.CapacidadBodega;
                dataGridViewAeronave.Rows.Add(filaAeronave);
            }
        }

        //creo aeronave
        private void btnCrearAvion_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                dataGridViewAeronave.Rows.Clear();
                int cantAsientos = (int)numericUpDownAsientos.Value;
                int cantBanios = (int)numericUpDownBaños.Value;
                bool.TryParse(this.cbInternet.SelectedItem.ToString(), out bool internet);
                bool.TryParse(this.cbComida.SelectedItem.ToString(), out bool comida);
                int capacidadBodega = (int)numericUpDownBodega.Value;

                Aeronave aeronaveNueva = new Aeronave(cantAsientos, cantBanios, internet, comida, capacidadBodega);
                foreach (Aeronave avion in Sistema.ListaDeAeronaves)
                {
                    if (aeronaveNueva != avion)
                    {
                        Sistema.ListaDeAeronaves.Add(aeronaveNueva);
                        cargarDataAeronave();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error. la aeronave ya existe");
                    }
                }
            }
        }

        private bool Validaciones()
        {
            if (cbInternet.SelectedIndex != -1 && cbComida.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        //limpio controles
        private void Clear()
        {
            foreach (Control control in tabPage6.Controls)
            {
                if (control is NumericUpDown numericUp)
                {
                    numericUp.Value = numericUp.Minimum;
                }
                if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }
        }

        //relleno controles segun el indice
        private void dataGridViewAeronave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dataGridViewAeronave.CurrentRow.Index;
            numericUpDownAsientos.Value = (decimal)Sistema.ListaDeAeronaves[posicion].CantidadDeAsientos;
            numericUpDownBaños.Value = (decimal)Sistema.ListaDeAeronaves[posicion].CantidadDeBanios;
            numericUpDownBodega.Value = (decimal)Sistema.ListaDeAeronaves[posicion].CapacidadBodega;
            int indiceInternet = cbInternet.Items.IndexOf(Sistema.ListaDeAeronaves[posicion].ServicioDeInternet.ToString());
            int indiceComida = cbComida.Items.IndexOf(Sistema.ListaDeAeronaves[posicion].OfreceComida.ToString());
            cbInternet.SelectedIndex = indiceInternet;
            cbComida.SelectedIndex = indiceComida;

            btnCrearAvion.Enabled = false;
            btnModificarAvion.Enabled = true;
            btnEliminarAvion.Enabled = true;
        }

        //habilito el boton crear aeronave
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnCrearAvion.Enabled = true;
            Clear();
        }

        private void btnModificarAvion_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            int posicion;
            posicion = dataGridViewAeronave.CurrentRow.Index;
            string matricula = Sistema.ListaDeAeronaves[posicion].Matricula;
            Aeronave aeronaveModificar = GetAeronave(matricula);
            bool flag = true;

            foreach (Vuelo vuelo in Sistema.ListaDeVuelos)
            {
                if (aeronaveModificar.Matricula == vuelo.Avion.Matricula)
                {
                    float horaLlegada = vuelo.FechaDeVuelo.Hour + vuelo.DuracionDelVuelo;
                    if (fechaActual.Year == vuelo.FechaDeVuelo.Year && fechaActual.Month == vuelo.FechaDeVuelo.Month && fechaActual.Day == vuelo.FechaDeVuelo.Day)
                    {
                        if (fechaActual.Hour < horaLlegada && fechaActual.Hour > vuelo.FechaDeVuelo.Hour)
                        {
                            MessageBox.Show("Error. el avion esta en vuelo");
                            flag = false;
                            break;
                        }
                    }
                }
            }
            if (flag)
            {
                if (Validaciones())
                {
                    Sistema.ListaDeAeronaves[posicion].CantidadDeAsientos = (int)numericUpDownAsientos.Value;
                    Sistema.ListaDeAeronaves[posicion].CantidadDeBanios = (int)numericUpDownBaños.Value;
                    Sistema.ListaDeAeronaves[posicion].CapacidadBodega = (int)numericUpDownBodega.Value;
                    Sistema.ListaDeAeronaves[posicion].OfreceComida = bool.TryParse(this.cbComida.SelectedItem.ToString(), out bool eligeComida); ;
                    Sistema.ListaDeAeronaves[posicion].ServicioDeInternet = bool.TryParse(this.cbInternet.SelectedItem.ToString(), out bool servicioIntenet);
                    dataGridViewAeronave.Rows.Clear();
                    cargarDataAeronave();
                    Clear();
                }
            }

        }

        private Aeronave GetAeronave(string matricula)
        {
            foreach (Aeronave item in Sistema.ListaDeAeronaves)
            {
                if (matricula == item.Matricula)
                {
                    return item;
                }
            }
            return null;
        }

        private void btnEliminarAvion_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            int posicion;
            posicion = dataGridViewAeronave.CurrentRow.Index;
            string matricula = Sistema.ListaDeAeronaves[posicion].Matricula;
            Aeronave aeronaveEliminar = GetAeronave(matricula);

            bool flag = true;

            foreach (Vuelo vuelo in Sistema.ListaDeVuelos)
            {
                if (aeronaveEliminar.Matricula == vuelo.Avion.Matricula)
                {
                    if (vuelo.FechaDeVuelo.Year == fechaActual.Year && vuelo.FechaDeVuelo.Month == fechaActual.Month && vuelo.FechaDeVuelo.Day == fechaActual.Day)
                    {
                        float horaLlegada = vuelo.FechaDeVuelo.Hour + vuelo.DuracionDelVuelo;
                        float horaSalida = vuelo.FechaDeVuelo.Hour;
                        if (fechaActual.Hour < horaLlegada && fechaActual.Hour > horaSalida)
                        {
                            MessageBox.Show("Error. el avion ya habia realizado viajes");
                            flag = false;
                            break;
                        }
                    }
                    else if (vuelo.FechaDeVuelo.Year < fechaActual.Year || vuelo.FechaDeVuelo.Month < fechaActual.Month || vuelo.FechaDeVuelo.Day < fechaActual.Day)
                    {
                        MessageBox.Show("Error. el avion ya habia realizado viajes");
                        flag = false;
                        break;
                    }
                }
            }
            if (flag)
            {
                Sistema.ListaDeAeronaves.Remove(aeronaveEliminar);
                dataGridViewAeronave.Rows.Clear();
                cargarDataAeronave();
                Clear();
            }
        }
        //---------------CRUD aeronave---------------//



    }
}
