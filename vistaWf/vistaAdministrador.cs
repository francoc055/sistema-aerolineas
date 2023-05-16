using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
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

            //---vuelos---//
            CargarDataVuelos();
            btnModificarVuelo.Enabled = false;
            btnEliminarVuelo.Enabled = false;

            //combobox
            cbOrigenNacional.Enabled = false;
            cbOrigenInternacional.Enabled = false;
            cbOrigenNacional.DataSource = Enum.GetValues(typeof(DestinoNacional));
            cbOrigenInternacional.SelectedIndex = -1;
            cbOrigenNacional.SelectedIndex = -1;

            cbDestino.SelectedIndex = -1;

            cbAvion.DataSource = Sistema.ListaDeAeronaves;
            cbAvion.DisplayMember = "Matricula";
            cbAvion.SelectedIndex = -1;

            //dateTimePickerFecha.MinDate = DateTime.Now;

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
                    float horaSalida = vuelo.FechaDeVuelo.Hour;
                    if (fechaActual.Year == vuelo.FechaDeVuelo.Year && fechaActual.Month == vuelo.FechaDeVuelo.Month && fechaActual.Day == vuelo.FechaDeVuelo.Day)
                    {
                        if (fechaActual.Hour < horaLlegada && fechaActual.Hour > horaSalida)
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


        //---------------CRUD vuelos---------------//
        private void CargarDataVuelos()
        {
            foreach (Vuelo item in Sistema.ListaDeVuelos)
            {
                DataGridViewRow filaVuelos = new DataGridViewRow();
                filaVuelos.CreateCells(dataGridViewVuelos);
                filaVuelos.Cells[0].Value = item.IdVuelo;
                filaVuelos.Cells[1].Value = item.CiudadDePartida;
                filaVuelos.Cells[2].Value = item.CiudadDestino;
                filaVuelos.Cells[3].Value = item.FechaDeVuelo;
                filaVuelos.Cells[4].Value = item.Avion.Matricula;
                filaVuelos.Cells[5].Value = item.AsientosDisponibles;
                filaVuelos.Cells[6].Value = item.CostoTurista;
                filaVuelos.Cells[7].Value = item.CostoPremium;
                filaVuelos.Cells[8].Value = item.DuracionDelVuelo;
                filaVuelos.Cells[9].Value = item.ListaPasajeros.Count;
                filaVuelos.Cells[10].Value = item.CostoNeto(item.CostoPremium);
                filaVuelos.Cells[11].Value = item.CostoNeto(item.CostoTurista);
                dataGridViewVuelos.Rows.Add(filaVuelos);
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cbOrigenNacional.Enabled = true;

            cbOrigenInternacional.Enabled = false;
            cbOrigenInternacional.SelectedIndex = -1;

            cbDestino.Enabled = true;
            cbDestino.DataSource = Enum.GetValues(typeof(DestinoNacional));
            cbDestino.SelectedIndex = -1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cbOrigenInternacional.Enabled = true;

            cbOrigenNacional.Enabled = false;
            cbOrigenNacional.SelectedIndex = -1;

            cbDestino.Enabled = true;
            cbDestino.DataSource = Enum.GetValues(typeof(DestinoInternacional));
            cbDestino.SelectedIndex = -1;
        }


        private void btnCrearVuelo_Click(object sender, EventArgs e)
        {
            string ciudadPartida = "";
            if (cbOrigenInternacional.Enabled)
            {
                ciudadPartida = cbOrigenInternacional.Text;
            }
            else if (cbOrigenNacional.Enabled)
            {
                ciudadPartida = cbOrigenNacional.Text;
            }
            string ciudadDestino = cbDestino.Text;

            Aeronave avion = (Aeronave)cbAvion.SelectedItem;

            DateTime fechaVuelo = dateTimePickerFecha.Value;

            Vuelo vueloNuevo = new Vuelo(fechaVuelo, avion, ciudadDestino, ciudadPartida);

            if (!string.IsNullOrEmpty(ciudadPartida) && !string.IsNullOrEmpty(ciudadDestino) && avion is not null)
            {
                if (DateTime.Now < vueloNuevo.FechaDeVuelo)
                {
                    Sistema.ListaDeVuelos.Add(vueloNuevo);
                    dataGridViewVuelos.Rows.Clear();
                    CargarDataVuelos();
                    ClearVuelos();
                }
                else
                {
                    MessageBox.Show("Error. la fecha no es valida");
                }
            }
            else
            {
                MessageBox.Show("Error. Error verificar los datos");
            }
        }

        private void ClearVuelos()
        {
            foreach (Control control in tabPage5.Controls)
            {
                if (control is DateTimePicker dtp)
                {
                    dtp.Value = dtp.MinDate;
                }
                if (control is RadioButton rb)
                {
                    rb.Checked = false;
                }
                if (control is System.Windows.Forms.ComboBox cbAvion)
                {
                    cbAvion.SelectedIndex = -1;
                }
                foreach (Control itemO in groupBox3.Controls)
                {
                    if (itemO is System.Windows.Forms.ComboBox cb)
                    {
                        cb.SelectedIndex = -1;
                    }
                }
                foreach (Control itemD in groupBox4.Controls)
                {
                    if (itemD is System.Windows.Forms.ComboBox cb)
                    {
                        cb.SelectedIndex = -1;
                    }
                }

            }
        }

        private void dataGridViewVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dataGridViewVuelos.CurrentRow.Index;
            if (Sistema.ListaDeVuelos[posicion].CiudadDePartida.ToString() == "Buenos Aires")
            {
                cbOrigenInternacional.Enabled = true;
                radioButton2.Checked = true;
                cbOrigenInternacional.SelectedIndex = 0;
            }
            else
            {
                cbOrigenNacional.Text = Sistema.ListaDeVuelos[posicion].CiudadDePartida;
                radioButton1.Checked = true;
                cbOrigenNacional.Enabled = true;
            }

            cbDestino.Text = Sistema.ListaDeVuelos[posicion].CiudadDestino;

            cbAvion.Text = Sistema.ListaDeVuelos[posicion].Avion.Matricula;

            dateTimePickerFecha.Value = Sistema.ListaDeVuelos[posicion].FechaDeVuelo;

            btnCrearVuelo.Enabled = false;
            btnModificarVuelo.Enabled = true;
            btnEliminarVuelo.Enabled = true;
        }

        private void btnModificarVuelo_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            int posicion;
            posicion = dataGridViewVuelos.CurrentRow.Index;
            int id = Sistema.ListaDeVuelos[posicion].IdVuelo;
            Vuelo vueloModificar = GetVuelo(id);


            float horaLlegada = vueloModificar.FechaDeVuelo.Hour + vueloModificar.DuracionDelVuelo;
            float horaSalida = vueloModificar.FechaDeVuelo.Hour;
            if (fechaActual.Year == vueloModificar.FechaDeVuelo.Year && fechaActual.Month == vueloModificar.FechaDeVuelo.Month && fechaActual.Day == vueloModificar.FechaDeVuelo.Day)
            {
                if (fechaActual.Hour < horaLlegada && fechaActual.Hour > horaSalida)
                {
                    MessageBox.Show("Error. el vuelo esta en curso");
                }
            }
            else
            {
                if ((!string.IsNullOrEmpty(cbOrigenInternacional.Text) || !string.IsNullOrEmpty(cbOrigenNacional.Text)) && !string.IsNullOrEmpty(cbDestino.Text) && Sistema.ListaDeVuelos[posicion].Avion is not null)
                {
                    if (cbOrigenInternacional.Enabled)
                    {
                        Sistema.ListaDeVuelos[posicion].CiudadDePartida = cbOrigenInternacional.Text;
                    }
                    else if (cbOrigenNacional.Enabled)
                    {
                        Sistema.ListaDeVuelos[posicion].CiudadDePartida = cbOrigenNacional.Text;
                    }
                    Sistema.ListaDeVuelos[posicion].CiudadDestino = cbDestino.Text;

                    Sistema.ListaDeVuelos[posicion].Avion = (Aeronave)cbAvion.SelectedItem;

                    Sistema.ListaDeVuelos[posicion].FechaDeVuelo = dateTimePickerFecha.Value;

                    dataGridViewVuelos.Rows.Clear();
                    CargarDataVuelos();
                    ClearVuelos();
                }
            }

        }

        private Vuelo? GetVuelo(int id)
        {
            foreach (Vuelo item in Sistema.ListaDeVuelos)
            {
                if (item.IdVuelo == id)
                {
                    return item;
                }
            }
            return null;
        }

        private void btnEliminarVuelo_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            int posicion;
            posicion = dataGridViewVuelos.CurrentRow.Index;
            int id = Sistema.ListaDeVuelos[posicion].IdVuelo;
            Vuelo vueloEliminar = GetVuelo(id);
            bool flag = true;


            float horaLlegada = vueloEliminar.FechaDeVuelo.Hour + vueloEliminar.DuracionDelVuelo;
            float horaSalida = vueloEliminar.FechaDeVuelo.Hour;
            if (fechaActual.Year == vueloEliminar.FechaDeVuelo.Year && fechaActual.Month == vueloEliminar.FechaDeVuelo.Month && fechaActual.Day == vueloEliminar.FechaDeVuelo.Day)
            {
                if (fechaActual.Hour < horaLlegada && fechaActual.Hour > horaSalida)
                {
                    MessageBox.Show("Error. el vuelo ya existia");
                    flag = false;
                }
            }
            else if (fechaActual.Year > vueloEliminar.FechaDeVuelo.Year || fechaActual.Month > vueloEliminar.FechaDeVuelo.Month || fechaActual.Day > vueloEliminar.FechaDeVuelo.Day)
            {
                MessageBox.Show("Error. el vuelo ya existia");
                flag = false;
            }

            if (flag)
            {
                Sistema.ListaDeVuelos.Remove(vueloEliminar);
                dataGridViewVuelos.Rows.Clear();
                CargarDataVuelos();
                ClearVuelos();
            }
        }

        private void btnNuevoVuelo_Click(object sender, EventArgs e)
        {
            btnCrearVuelo.Enabled = true;
            ClearVuelos();
        }

        private void txtFiltrarMatricula_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltrarMatricula.Text.Trim();
            if (filtro.ToString().Length == 8)
            {
                foreach (DataGridViewRow fila in dataGridViewAeronave.Rows)
                {
                    fila.Selected = false;

                    string valor = (string)fila.Cells[0].Value;
                    if (valor == filtro.ToUpper())
                    {
                        dataGridViewAeronave.Rows.Clear();
                        foreach (Aeronave avion in Sistema.ListaDeAeronaves)
                        {
                            if (avion.Matricula == valor)
                            {
                                fila.CreateCells(dataGridViewAeronave);
                                fila.Cells[0].Value = avion.Matricula;
                                fila.Cells[1].Value = avion.CantidadDeAsientos;
                                fila.Cells[2].Value = avion.CantidadDeBanios;
                                fila.Cells[3].Value = avion.ServicioDeInternet;
                                fila.Cells[4].Value = avion.OfreceComida;
                                fila.Cells[5].Value = avion.CapacidadBodega;
                                dataGridViewAeronave.Rows.Add(fila);

                                fila.Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
            if (filtro.Length != 8)
            {
                dataGridViewAeronave.Rows.Clear();
                cargarDataAeronave();
            }
        }

        private void txtFiltrarVuelos_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtFiltrarVuelos.Text.Trim(), out int filtroID))
            {
                if (filtroID.ToString().Length == 1)
                {
                    foreach (DataGridViewRow fila in dataGridViewVuelos.Rows)
                    {
                        fila.Selected = false;
                        if(fila.Cells[0].Value != null)
                        {
                            if (int.TryParse(fila.Cells[0].Value.ToString(), out int valor))
                            {
                                if (valor == filtroID)
                                {
                                    dataGridViewVuelos.Rows.Clear();
                                    foreach (Vuelo vuelo in Sistema.ListaDeVuelos)
                                    {
                                        if (vuelo.IdVuelo == valor)
                                        {
                                            fila.CreateCells(dataGridViewVuelos);
                                            fila.Cells[0].Value = vuelo.IdVuelo;
                                            fila.Cells[1].Value = vuelo.CiudadDePartida;
                                            fila.Cells[2].Value = vuelo.CiudadDestino;
                                            fila.Cells[3].Value = vuelo.FechaDeVuelo;
                                            fila.Cells[4].Value = vuelo.Avion.Matricula;
                                            fila.Cells[5].Value = vuelo.AsientosDisponibles;
                                            fila.Cells[6].Value = vuelo.CostoTurista;
                                            fila.Cells[7].Value = vuelo.CostoPremium;
                                            fila.Cells[8].Value = vuelo.DuracionDelVuelo;
                                            fila.Cells[9].Value = vuelo.ListaPasajeros.Count;
                                            fila.Cells[10].Value = vuelo.CostoNeto(vuelo.CostoPremium);
                                            fila.Cells[11].Value = vuelo.CostoNeto(vuelo.CostoTurista);
                                            dataGridViewVuelos.Rows.Add(fila);

                                            fila.Selected = true;
                                            break;
                                        }
                                    }
                                    break;

                                }
                            }
                        }
                        
                    }
                }
            }
            else if(filtroID == 0)
            {
                dataGridViewVuelos.Rows.Clear();
                CargarDataVuelos();
            }
        }
    }
}
