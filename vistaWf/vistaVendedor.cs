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
using System.Windows.Forms.VisualStyles;
using vistaWf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class vistaVendedor : VistaUsuario
    {
        //List<PreferenciasPasajero> listaPasajeros;
        //List<Vuelo> listaVuelos;
        //Login frmLogin;

        public vistaVendedor()
        {
            InitializeComponent();
            //listaVuelos = new List<Vuelo>();
            //listaPasajeros = new List<PreferenciasPasajero>();
            //frmLogin = new Login();
        }


        private void vistaVendedor_Load_1(object sender, EventArgs e)
        {
            labelCambiar.Text = "Vendedor";
            //listaVuelos = Deserializador.DeserializarVuelos();
            //Sistema.ListaDeVuelos = Deserializador.DeserializarVuelos();
            //listaPasajeros = Deserializador.DeserializarPasajeros();
            //Sistema.ListaDePasajeros = Deserializador.DeserializarPasajeros();

            CargarDataGridVuelo();
            CargarDataEstadisticas();
            CargarDataVenderViaje();


            //crud
            this.cbEquipaje.DataSource = Enum.GetValues(typeof(EquipoDeViaje));
            this.cbClase.DataSource = Enum.GetValues(typeof(Clase));
            this.cbEquipaje.SelectedIndex = -1;
            this.cbClase.SelectedIndex = -1;

            ActualizarListPasajeros(dataGridViewCrudPasajero);

            btnModificarPasajero.Enabled = false;
            btnEliminarPasajero.Enabled = false;



        }
        protected virtual void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage5 || e.TabPage == tabPage6)
            {
                MessageBox.Show("No puedes ingresar ni realizar acciones ya que no eres Administrador");
                e.Cancel = true;
            }
        }

        //----------Listar viajes------------//
        private void CargarDataGridVuelo()
        {
            foreach (Vuelo v in Sistema.ListaDeVuelos)
            {
                DataGridViewRow filaVuelo = new DataGridViewRow();
                filaVuelo.CreateCells(dataGridViewInfoVuelos);
                filaVuelo.Cells[0].Value = v.Avion.Matricula;
                filaVuelo.Cells[1].Value = v.CiudadDePartida;
                filaVuelo.Cells[2].Value = v.CiudadDestino;
                filaVuelo.Cells[3].Value = v.FechaDeVuelo;
                filaVuelo.Cells[4].Value = v.CostoTurista;
                filaVuelo.Cells[5].Value = v.CostoPremium;
                filaVuelo.Cells[6].Value = v.IdVuelo;
                dataGridViewInfoVuelos.Rows.Add(filaVuelo);
            }
        }

        private void dataGridViewInfoVuelos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewInfoVuelos.SelectedRows.Count > 0)
            {
                dataGridViewInfoPasajero.Rows.Clear();

                DataGridViewRow row = dataGridViewInfoVuelos.SelectedRows[0];
                int valorCeldaIdVuelo = (int)row.Cells[6].Value;

                foreach (Vuelo item in Sistema.ListaDeVuelos)
                {
                    if (item.IdVuelo == valorCeldaIdVuelo)
                    {
                        foreach (Pasajero pasajero in item.ListaPasajeros)
                        {

                            DataGridViewRow filaPasajero = new DataGridViewRow();
                            filaPasajero.CreateCells(dataGridViewInfoPasajero);
                            filaPasajero.Cells[0].Value = pasajero.Nombre;
                            filaPasajero.Cells[1].Value = pasajero.Apellido;
                            filaPasajero.Cells[2].Value = pasajero.Edad;
                            filaPasajero.Cells[3].Value = pasajero.Dni;
                            dataGridViewInfoPasajero.Rows.Add(filaPasajero);
                        }
                    }
                }
            }
        }
        //----------Listar viajes------------//



        //----------Estadisticas historicas------------//
        private void CargarDataEstadisticas()
        {
            dataGridViewEstadisticas.Rows.Clear();
            bool flag = false;
            foreach (Vuelo item in Sistema.ListaDeVuelos)
            {
                if (item.FechaDeVuelo.Year <= DateTime.Now.Year && item.FechaDeVuelo.Month < DateTime.Now.Month)
                {
                    DataGridViewRow filaVueloEstadisticas = new DataGridViewRow();
                    filaVueloEstadisticas.CreateCells(dataGridViewEstadisticas);
                    filaVueloEstadisticas.Cells[0].Value = item.Avion.Matricula;
                    filaVueloEstadisticas.Cells[1].Value = item.TotalRecaudado;
                    filaVueloEstadisticas.Cells[2].Value = item.ListaPasajeros.Count;
                    if (!flag)
                    {
                        filaVueloEstadisticas.Cells[3].Value = DestinoMasElegido();
                    }
                    dataGridViewEstadisticas.Rows.Add(filaVueloEstadisticas);
                    flag = true;
                }
            }
        }

        private string DestinoMasElegido()
        {
            Dictionary<string, int> destinosContador = new Dictionary<string, int>();

            bool flag = false;
            foreach (Vuelo vuelo in Sistema.ListaDeVuelos)
            {
                if (!flag)
                {
                    destinosContador.Add(vuelo.CiudadDestino, vuelo.ListaPasajeros.Count);
                }
                else
                {
                    foreach (KeyValuePair<string, int> item in destinosContador)
                    {
                        if (vuelo.CiudadDestino != item.Key)
                        {
                            destinosContador.Add(vuelo.CiudadDestino, vuelo.ListaPasajeros.Count);
                            break;
                        }
                    }
                }

                flag = true;
            }

            bool flag2 = false;
            string destino = "";
            int mayor = 0;
            foreach (KeyValuePair<string, int> item in destinosContador)
            {
                if (!flag2)
                {
                    mayor = item.Value;
                    destino = item.Key;
                }
                else
                {
                    if (item.Value > mayor)
                    {
                        destino = item.Key;
                    }
                }
                flag2 = true;
            }

            return destino;
        }
        //----------Estadisticas historicas------------//


        //----------Vender viaje------------//
        private void CargarDataVenderViaje()
        {
            foreach (PreferenciasPasajero item in Sistema.ListaDePasajeros)
            {
                if (item.EnVuelo == false)
                {
                    DataGridViewRow filaPasajero = new DataGridViewRow();
                    filaPasajero.CreateCells(dataGridViewPasajerosSinVuelo);
                    filaPasajero.Cells[0].Value = item.Dni;
                    filaPasajero.Cells[1].Value = item.Nombre;
                    filaPasajero.Cells[2].Value = item.EligeInternet;
                    filaPasajero.Cells[3].Value = item.EligeComida;
                    filaPasajero.Cells[4].Value = item.Equipo;
                    filaPasajero.Cells[5].Value = item.PesoValija;
                    filaPasajero.Cells[6].Value = item.TipoClase;
                    dataGridViewPasajerosSinVuelo.Rows.Add(filaPasajero);
                }

            }
        }

        private void dataGridViewPasajerosSinVuelo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPasajerosSinVuelo.SelectedRows.Count > 0)
            {
                dataGridViewVuelosVender.Rows.Clear();
                DataGridViewRow row = dataGridViewPasajerosSinVuelo.SelectedRows[0];

                bool valorCeldaInternet = (bool)row.Cells[2].Value;
                bool valorCeldaComida = (bool)row.Cells[3].Value;
                float valorCeldaPesoEquipaje = (float)row.Cells[5].Value;
                Clase valorCeldaClase = (Clase)row.Cells[6].Value;

                bool flag = false;
                foreach (Vuelo v in Sistema.ListaDeVuelos)
                {
                    float diferenciaPeso = v.Avion.CapacidadBodega - valorCeldaPesoEquipaje;
                    if (Clase.Turista.ToString() == valorCeldaClase.ToString())
                    {
                        v.CantidadAsientoClaseTurista -= 1;
                        if (v.CantidadAsientoClaseTurista >= 0)
                        {
                            v.Avion.CantidadDeAsientos -= 1;
                        }
                    }
                    else if (Clase.Premium.ToString() == valorCeldaClase.ToString())
                    {
                        v.CantidadAsientoClasePremium -= 1;
                        if (v.CantidadAsientoClasePremium >= 0)
                        {
                            v.Avion.CantidadDeAsientos -= 1;
                        }
                    }

                    if (v.Avion.CapacidadBodega > valorCeldaPesoEquipaje && diferenciaPeso >= 0)
                    {
                        if (valorCeldaInternet == v.Avion.ServicioDeInternet && valorCeldaComida == v.Avion.OfreceComida && v.CantidadAsientoClaseTurista >= 0 && v.CantidadAsientoClasePremium >= 0)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataGridViewVuelosVender);
                            newRow.Cells[0].Value = v.Avion.Matricula;
                            newRow.Cells[1].Value = v.CiudadDePartida;
                            newRow.Cells[2].Value = v.CiudadDestino;
                            newRow.Cells[3].Value = v.FechaDeVuelo;
                            newRow.Cells[4].Value = v.CostoTurista;
                            newRow.Cells[5].Value = v.CostoPremium;
                            newRow.Cells[6].Value = v.IdVuelo;
                            newRow.Cells[7].Value = v.Avion.CapacidadBodega;
                            newRow.Cells[8].Value = v.AsientosDisponibles;


                            dataGridViewVuelosVender.Rows.Add(newRow);
                        }
                    }


                }

            }

        }


        //----------------------REFACTORIZAR--------------------------//
        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowPasajero = dataGridViewPasajerosSinVuelo.SelectedRows[0];
            DataGridViewRow rowVuelo = dataGridViewVuelosVender.SelectedRows[0];
            double numeroDni = (double)rowPasajero.Cells[0].Value;
            int idDelVuelo = (int)rowVuelo.Cells[6].Value;

            Vuelo vuelo = GetVuelo(idDelVuelo);
            PreferenciasPasajero pasajero = GetPasajero(numeroDni);

            if (dataGridViewPasajerosSinVuelo.SelectedRows.Count > 0 && dataGridViewVuelosVender.SelectedRows.Count > 0)
            {
                if (vuelo is not null && pasajero is not null)
                {
                    vuelo += pasajero;
                    pasajero.EnVuelo = true;
                    MessageBox.Show($"Pasajero agregado al vuelo " +
                        $"{vuelo.ToString()}");
                    dataGridViewPasajerosSinVuelo.Rows.Clear();
                    CargarDataVenderViaje();
                    CargarDataEstadisticas();
                    Serializador.SerializarPasajeros(Sistema.ListaDePasajeros);
                    Serializador.SerializarVuelos(Sistema.ListaDeVuelos);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar pasajero y vuelo");
            }

        }

        private PreferenciasPasajero GetPasajero(double dni)
        {
            foreach (PreferenciasPasajero item in Sistema.ListaDePasajeros)
            {
                if (item.Dni == dni)
                {
                    return item;
                }
            }
            return null;
        }

        private Vuelo GetVuelo(int id)
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
        //----------Vender viaje------------//


        //----------CRUD Pasajeros------------//
        protected virtual void btnCrearPasajero_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            Double.TryParse(txtDni.Text, out double dni);
            int.TryParse(txtEdad.Text, out int edad);
            EquipoDeViaje equipaje = (EquipoDeViaje)this.cbEquipaje.SelectedItem;
            float.TryParse(txtPesoValija.Text, out float pesoValija);
            bool.TryParse(this.cbComida.SelectedItem.ToString(), out bool eligeComida);
            bool.TryParse(this.cbInternet.SelectedItem.ToString(), out bool eligeInternet);
            Clase tipoClase = (Clase)this.cbClase.SelectedItem;

            PreferenciasPasajero pasajeroNuevo = new PreferenciasPasajero(nombre, apellido, dni, edad, equipaje, pesoValija, eligeComida, eligeInternet, tipoClase, false);
            Sistema.ListaDePasajeros.Add(pasajeroNuevo);
            ActualizarListPasajeros(dataGridViewCrudPasajero);
            ClearTxtCb();
            Serializador.SerializarPasajeros(Sistema.ListaDePasajeros);
            //cargo datasGridViews
            CargarDataVenderViaje();
        }

        protected virtual void ClearTxtCb()
        {
            foreach (Control control in tabPage4.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.Text = " ";
                }
                if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }
        }


        protected virtual void ActualizarListPasajeros(DataGridView data)
        {
            data.Rows.Clear();

            foreach (PreferenciasPasajero pasajero in Sistema.ListaDePasajeros)
            {
                DataGridViewRow filaPasajero = new DataGridViewRow();
                filaPasajero.CreateCells(data);
                filaPasajero.Cells[0].Value = pasajero.Nombre;
                filaPasajero.Cells[1].Value = pasajero.Apellido;
                filaPasajero.Cells[2].Value = pasajero.Dni;
                filaPasajero.Cells[3].Value = pasajero.Edad;
                filaPasajero.Cells[4].Value = pasajero.Equipo;
                filaPasajero.Cells[5].Value = pasajero.TipoClase;
                data.Rows.Add(filaPasajero);
            }
        }

        protected virtual void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(txtFiltrar.Text.Trim(), out double filtro))
            {
                foreach (DataGridViewRow fila in dataGridViewCrudPasajero.Rows)
                {
                    fila.Selected = false;
                    if (Double.TryParse(fila.Cells[2].Value.ToString(), out double valor))
                    {
                        if (valor == filtro)
                        {
                            fila.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        protected virtual void dataGridViewCrudPasajero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dataGridViewCrudPasajero.CurrentRow.Index;
            txtNombre.Text = Sistema.ListaDePasajeros[posicion].Nombre;
            txtApellido.Text = Sistema.ListaDePasajeros[posicion].Apellido;
            txtDni.Text = Sistema.ListaDePasajeros[posicion].Dni.ToString();
            txtEdad.Text = Sistema.ListaDePasajeros[posicion].Edad.ToString();
            txtPesoValija.Text = Sistema.ListaDePasajeros[posicion].PesoValija.ToString();
            cbEquipaje.SelectedIndex = DevolverPosicionEnumerado(Sistema.ListaDePasajeros[posicion].Equipo);
            int indiceComida = cbComida.Items.IndexOf(Sistema.ListaDePasajeros[posicion].EligeComida.ToString());
            int indiceInternet = cbComida.Items.IndexOf(Sistema.ListaDePasajeros[posicion].EligeInternet.ToString());
            cbComida.SelectedIndex = indiceComida;
            cbInternet.SelectedIndex = indiceInternet;
            cbClase.SelectedIndex = DevolverPosicionEnumerado(Sistema.ListaDePasajeros[posicion].TipoClase);

            btnCrearPasajero.Enabled = false;
            btnModificarPasajero.Enabled = true;
            btnEliminarPasajero.Enabled = true;
        }
        protected virtual int DevolverPosicionEnumerado(Enum valor)
        {
            int posicion = -1;
            Type tipo = valor.GetType();

            if (tipo.ToString() == "EquipoDeViaje")
            {
                EquipoDeViaje[] valoresEquipo = (EquipoDeViaje[])Enum.GetValues(typeof(EquipoDeViaje));
                posicion = Array.IndexOf(valoresEquipo, valor);
            }
            else if (tipo.ToString() == "Clase")
            {
                Clase[] valoresClase = (Clase[])Enum.GetValues(typeof(Clase));
                posicion = Array.IndexOf(valoresClase, valor);
            }

            return posicion;

        }

        protected virtual void btnModificarPasajero_Click(object sender, EventArgs e)
        {
            int.TryParse(txtDni.Text, out int doc);
            PreferenciasPasajero pasajeroModificado = GetPasajero(doc);

            Double.TryParse(txtDni.Text, out double dni);
            int.TryParse(txtEdad.Text, out int edad);
            float.TryParse(txtPesoValija.Text, out float pesoValija);
            bool.TryParse(this.cbComida.SelectedItem.ToString(), out bool eligeComida);
            bool.TryParse(this.cbInternet.SelectedItem.ToString(), out bool eligeInternet);

            foreach (PreferenciasPasajero item in Sistema.ListaDePasajeros)
            {
                if (item == pasajeroModificado)
                {
                    item.Nombre = txtNombre.Text;
                    item.Apellido = txtApellido.Text;
                    item.Dni = dni;
                    item.Edad = edad;
                    item.Equipo = (EquipoDeViaje)this.cbEquipaje.SelectedItem;
                    item.PesoValija = pesoValija;
                    item.EligeComida = eligeComida;
                    item.EligeInternet = eligeInternet;
                    item.TipoClase = (Clase)this.cbClase.SelectedItem;
                }
            }

            ActualizarListPasajeros(dataGridViewCrudPasajero);
            ClearTxtCb();
            Serializador.SerializarPasajeros(Sistema.ListaDePasajeros);
            //cargo datasGridViews
            CargarDataVenderViaje();
        }

        protected virtual void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            int.TryParse(txtDni.Text, out int doc);
            PreferenciasPasajero pasajeroEliminar = GetPasajero(doc);

            foreach (PreferenciasPasajero item in Sistema.ListaDePasajeros)
            {
                if (item == pasajeroEliminar)
                {
                    Sistema.ListaDePasajeros.Remove(item);
                    break;
                }
            }

            ActualizarListPasajeros(dataGridViewCrudPasajero);
            ClearTxtCb();
            Serializador.SerializarPasajeros(Sistema.ListaDePasajeros);
            //cargo datasGridViews
            CargarDataVenderViaje();
        }

        protected virtual void btnNuevo_Click(object sender, EventArgs e)
        {
            btnCrearPasajero.Enabled = true;
            btnModificarPasajero.Enabled = false;
            btnEliminarPasajero.Enabled = false;
        }
        //----------CRUD Pasajeros------------//

        protected virtual void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }
    }




}
