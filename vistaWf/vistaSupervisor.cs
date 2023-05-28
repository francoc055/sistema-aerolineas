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

namespace Vista
{
    public partial class vistaSupervisor : VistaUsuario
    {
        public vistaSupervisor()
        {
            InitializeComponent();
        }
        private void vistaSupervisor_Load(object sender, EventArgs e)
        {
            CargarRegistro();
            CargarNombreOperador();
            tabControl1.SelectedTab = tabPage2;

            CargarDataEstadisticasDestino();
            CargarEstadisticasOrdenFact();
            cargarDataHorasGcias();
            CargarDataPasajerosFrecuentes();

            this.cbEquipaje.DataSource = Enum.GetValues(typeof(EquipoDeViaje));
            this.cbClase.DataSource = Enum.GetValues(typeof(Clase));
            this.cbEquipaje.SelectedIndex = -1;
            this.cbClase.SelectedIndex = -1;

            ActualizarListPasajeros(dataGridViewCrudPasajero);

            btnModificarPasajero.Enabled = false;
            btnEliminarPasajero.Enabled = false;
        }

        private void CargarRegistro()
        {
            foreach (Usuarios item in Login.ListaUser)
            {
                if (item.correo == Login.CorreoUser)
                {
                    item.Acceso = DateTime.Now;
                    Login.RegistroUsuarios.Add(item);
                    Serializador.SerializarRegistros(Login.RegistroUsuarios);
                }
            }
        }

        private void CargarNombreOperador()
        {
            foreach (Usuarios item in Login.ListaUser)
            {
                if (item.correo == Login.CorreoUser)
                {
                    labelCambiar.Text = $"{item.perfil} {item.nombre} {item.apellido} - {DateTime.Now.Date}";
                    break;
                }
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage1 || e.TabPage == tabPage3)
            {
                MessageBox.Show("No puedes ingresar ni realizar acciones ya que no eres Vendedor");
                e.Cancel = true;
            }
            else if(e.TabPage == tabPage5 || e.TabPage == tabPage6)
            {
                MessageBox.Show("No puedes ingresar ni realizar acciones ya que no eres Administrador");
                e.Cancel = true;
            }

        }

        //----------Estadisticas historicas------------//
        private void CargarDataEstadisticasDestino()
        {
            dataGridViewEstadisticas.Rows.Clear();
            bool flag = false;
            foreach (Vuelo item in Sistema.ListaDeVuelos)
            {
                if (item.FechaDeVuelo.Year <= DateTime.Now.Year && item.FechaDeVuelo.Month < DateTime.Now.Month)
                {
                    DataGridViewRow filaVueloEstadisticas = new DataGridViewRow();
                    filaVueloEstadisticas.CreateCells(dataGridViewEstadisticas);
                    //filaVueloEstadisticas.Cells[0].Value = item.Avion.Matricula;
                    filaVueloEstadisticas.Cells[0].Value = item.TotalRecaudado;
                    //filaVueloEstadisticas.Cells[2].Value = item.ListaPasajeros.Count;
                    if (!flag)
                    {
                        filaVueloEstadisticas.Cells[1].Value = DestinoMasElegido();
                    }
                    dataGridViewEstadisticas.Rows.Add(filaVueloEstadisticas);
                    flag = true;
                    break;
                }
            }
        }


        private string DestinoMasElegido()
        {
            Dictionary<string, int> destinosContador = new Dictionary<string, int>();

            foreach (Vuelo vuelo in Sistema.ListaDeVuelos)
            {
                if (destinosContador.ContainsKey(vuelo.CiudadDestino))
                {
                    destinosContador[vuelo.CiudadDestino] += vuelo.ListaPasajeros.Count;
                }
                else
                {
                    destinosContador.Add(vuelo.CiudadDestino, vuelo.ListaPasajeros.Count);
                }
            }

            string destino = "";
            int mayor = 0;

            foreach (KeyValuePair<string, int> item in destinosContador)
            {
                if (item.Value > mayor)
                {
                    mayor = item.Value;
                    destino = item.Key;
                }
            }

            return destino;
        }

        //cargo datagrid ordenando descendiente los vuelos ya realizados
        private void CargarEstadisticasOrdenFact()
        {
            List<Vuelo> listaOrdenada = new List<Vuelo>();
            foreach (Vuelo item in Sistema.ListaDeVuelos)
            {
                if (item.FechaDeVuelo.Year <= DateTime.Now.Year && item.FechaDeVuelo.Month < DateTime.Now.Month)
                {
                    listaOrdenada.Add(item);
                }
            }

            if (listaOrdenada is not null)
            {
                listaOrdenada.Sort(Comparacion);
                foreach (Vuelo item in listaOrdenada)
                {
                    DataGridViewRow filaVueloEstadisticas = new DataGridViewRow();
                    filaVueloEstadisticas.CreateCells(dataGridViewOrdFacturacion);
                    filaVueloEstadisticas.Cells[0].Value = item.TotalRecaudado;
                    filaVueloEstadisticas.Cells[1].Value = item.CiudadDestino;
                    dataGridViewOrdFacturacion.Rows.Add(filaVueloEstadisticas);
                }
            }
        }

        private int Comparacion(Vuelo a, Vuelo b)
        {
            return (int)(a.TotalRecaudado - b.TotalRecaudado);
        }


        private void cargarDataHorasGcias()
        {
            foreach (Aeronave avion in Sistema.ListaDeAeronaves)
            {
                if (AvionConViajeRealizado(avion.Matricula))
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridViewHorasGciasTotales);
                    fila.Cells[0].Value = avion.Matricula;
                    fila.Cells[1].Value = horasRecaudadasTotales(avion.Matricula);
                    fila.Cells[2].Value = GananciasCabotaje(avion.Matricula);
                    fila.Cells[3].Value = GananciasInternacional(avion.Matricula);
                    dataGridViewHorasGciasTotales.Rows.Add(fila);
                }
            }
        }

        private decimal GananciasCabotaje(string matricula)
        {
            decimal ganancias = 0;
            foreach (Vuelo vuelo in Sistema.ListaDeVuelos)
            {
                if (EnVuelo(vuelo))
                {
                    if (vuelo.EsDestinoNacional())
                    {
                        if (matricula == vuelo.Avion.Matricula)
                        {
                            foreach (PreferenciasPasajero pasajero in vuelo.ListaPasajeros)
                            {
                                if (pasajero.TipoClase == Clase.Turista)
                                {
                                    ganancias += vuelo.CostoTurista;
                                }
                                else if (pasajero.TipoClase == Clase.Premium)
                                {
                                    ganancias += vuelo.CostoPremium;
                                }
                            }
                        }
                    }
                }
            }
            return ganancias;
        }

        private decimal GananciasInternacional(string matricula)
        {
            decimal ganancias = 0;
            foreach (Vuelo vuelo in Sistema.ListaDeVuelos)
            {
                if (EnVuelo(vuelo))
                {
                    if (vuelo.EsDestinoInternacional())
                    {
                        if (matricula == vuelo.Avion.Matricula)
                        {
                            foreach (PreferenciasPasajero pasajero in vuelo.ListaPasajeros)
                            {
                                if (pasajero.TipoClase == Clase.Turista)
                                {
                                    ganancias += vuelo.CostoTurista;
                                }
                                else if (pasajero.TipoClase == Clase.Premium)
                                {
                                    ganancias += vuelo.CostoPremium;
                                }
                            }
                        }
                    }
                }
            }
            return ganancias;
        }

        private float horasRecaudadasTotales(string matricula)
        {
            float horasTotales = 0;
            foreach (Vuelo vuelo in Sistema.ListaDeVuelos)
            {
                if (EnVuelo(vuelo))
                {
                    if (matricula == vuelo.Avion.Matricula)
                    {
                        horasTotales += vuelo.DuracionDelVuelo;
                    }
                }
            }

            return horasTotales;
        }

        private bool AvionConViajeRealizado(string matricula)
        {
            foreach (Vuelo vuelo in Sistema.ListaDeVuelos)
            {
                if (EnVuelo(vuelo))
                {
                    if (matricula == vuelo.Avion.Matricula)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool EnVuelo(Vuelo vuelo)
        {
            DateTime fechaActual = DateTime.Now;
            bool ret = false;

            float horaLlegada = vuelo.FechaDeVuelo.Hour + vuelo.DuracionDelVuelo;
            float horaSalida = vuelo.FechaDeVuelo.Hour;
            if (fechaActual.Year == vuelo.FechaDeVuelo.Year && fechaActual.Month == vuelo.FechaDeVuelo.Month && fechaActual.Day == vuelo.FechaDeVuelo.Day)
            {
                if (fechaActual.Hour < horaLlegada && fechaActual.Hour > horaSalida)
                {
                    ret = true;
                }
            }
            else
            {
                if (fechaActual.Year > vuelo.FechaDeVuelo.Year)
                {
                    ret = true;
                }
                else if (fechaActual.Year == vuelo.FechaDeVuelo.Year && fechaActual.Month > vuelo.FechaDeVuelo.Month)
                {
                    ret = true;
                }
                else
                {
                    ret = false;
                }
            }

            return ret;
        }

        private void CargarDataPasajerosFrecuentes()
        {
            List<PreferenciasPasajero> pasajerosF = new List<PreferenciasPasajero>();
            foreach (PreferenciasPasajero pasajero in Sistema.ListaDePasajeros)
            {
                if (pasajero.CantVuelo > 0)
                {
                    pasajerosF.Add(pasajero);
                }
            }

            if (pasajerosF is not null)
            {
                pasajerosF.Sort(ComparacionFrecuencia);
                foreach (PreferenciasPasajero item in pasajerosF)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridViewPasajerosFrecuentes);
                    fila.Cells[0].Value = item.Nombre;
                    fila.Cells[1].Value = item.CantVuelo;
                    dataGridViewPasajerosFrecuentes.Rows.Add(fila);
                }

            }
        }

        private int ComparacionFrecuencia(PreferenciasPasajero p1, PreferenciasPasajero p2)
        {
            return (int)(p2.CantVuelo - p1.CantVuelo);
        }





        //----------CRUD Pasajeros------------//
        private void btnCrearPasajero_Click_1(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                double dni = (double)numericUpDownDni.Value;
                int edad = (int)numericUpDownEdad.Value;
                EquipoDeViaje equipaje = (EquipoDeViaje)this.cbEquipaje.SelectedItem;
                float pesoValija = (float)numericUpDownValija.Value;
                bool.TryParse(this.cbComida.SelectedItem.ToString(), out bool eligeComida);
                bool.TryParse(this.cbInternet.SelectedItem.ToString(), out bool eligeInternet);
                Clase tipoClase = (Clase)this.cbClase.SelectedItem;

                PreferenciasPasajero pasajeroNuevo = new PreferenciasPasajero(nombre, apellido, dni, edad, equipaje, pesoValija, eligeComida, eligeInternet, tipoClase, 0);

                foreach (PreferenciasPasajero item in Sistema.ListaDePasajeros)
                {
                    if (item != pasajeroNuevo)
                    {
                        Sistema.ListaDePasajeros.Add(pasajeroNuevo);
                        ActualizarListPasajeros(dataGridViewCrudPasajero);
                        ClearTxtCb();
                        Serializador.SerializarPasajeros(Sistema.ListaDePasajeros);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("El pasajero ya existe");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error. verifique los datos");
            }
        }


        private bool Validaciones()
        {
            bool ret = false;
            if (cbClase.SelectedItem != null)
            {
                Clase tipoClase = (Clase)this.cbClase.SelectedItem;
                if (!string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtNombre.Text) && cbEquipaje.SelectedIndex != -1 && cbClase.SelectedIndex != -1
                && cbComida.SelectedIndex != -1 && cbInternet.SelectedIndex != -1 && numericUpDownDni.Value != 10000000)
                {
                    ret = true;
                    if (tipoClase == Clase.Turista)
                    {
                        if (numericUpDownValija.Value > 25)
                        {
                            ret = false;
                        }
                    }
                    else if (tipoClase == Clase.Premium)
                    {
                        if (numericUpDownValija.Value > 42)
                        {
                            ret = false;
                        }
                    }
                }
            }

            return ret;
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
                if (control is NumericUpDown numericUp)
                {
                    numericUp.Value = numericUp.Minimum;
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

        private void txtFiltrar_TextChanged_1(object sender, EventArgs e)
        {
            if (Double.TryParse(txtFiltrar.Text.Trim(), out double filtro))
            {
                if (filtro.ToString().Length == 8)
                {
                    foreach (DataGridViewRow fila in dataGridViewCrudPasajero.Rows)
                    {
                        fila.Selected = false;
                        if (Double.TryParse(fila.Cells[2].Value.ToString(), out double valor))
                        {
                            if (valor == filtro)
                            {
                                dataGridViewCrudPasajero.Rows.Clear();
                                //break;
                                foreach (PreferenciasPasajero pasajero in Sistema.ListaDePasajeros)
                                {
                                    if (pasajero.Dni == valor)
                                    {
                                        fila.CreateCells(dataGridViewCrudPasajero);
                                        fila.Cells[0].Value = pasajero.Nombre;
                                        fila.Cells[1].Value = pasajero.Apellido;
                                        fila.Cells[2].Value = pasajero.Dni;
                                        fila.Cells[3].Value = pasajero.Edad;
                                        fila.Cells[4].Value = pasajero.Equipo;
                                        fila.Cells[5].Value = pasajero.TipoClase;
                                        dataGridViewCrudPasajero.Rows.Add(fila);

                                        fila.Selected = true;
                                        break;
                                    }
                                }
                                break;

                            }

                        }

                    }
                }
                else if (txtFiltrar.Text.Trim().Length != 8)
                {
                    dataGridViewCrudPasajero.Rows.Clear();
                    ActualizarListPasajeros(dataGridViewCrudPasajero);
                }
            }
        }



        protected virtual void dataGridViewCrudPasajero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dataGridViewCrudPasajero.CurrentRow.Index;
            txtNombre.Text = Sistema.ListaDePasajeros[posicion].Nombre;
            txtApellido.Text = Sistema.ListaDePasajeros[posicion].Apellido;
            numericUpDownDni.Value = (decimal)Sistema.ListaDePasajeros[posicion].Dni;
            numericUpDownEdad.Value = (decimal)Sistema.ListaDePasajeros[posicion].Edad;
            numericUpDownValija.Value = (decimal)Sistema.ListaDePasajeros[posicion].PesoValija;
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
            if (Validaciones())
            {
                double doc = (double)numericUpDownDni.Value;
                PreferenciasPasajero pasajeroModificado = GetPasajero(doc);

                int edad = (int)numericUpDownEdad.Value;
                float pesoValija = (float)numericUpDownValija.Value;
                bool.TryParse(this.cbComida.SelectedItem.ToString(), out bool eligeComida);
                bool.TryParse(this.cbInternet.SelectedItem.ToString(), out bool eligeInternet);
                foreach (PreferenciasPasajero item in Sistema.ListaDePasajeros)
                {
                    if (item == pasajeroModificado)
                    {
                        item.Nombre = txtNombre.Text;
                        item.Apellido = txtApellido.Text;
                        item.Dni = doc;
                        item.Edad = edad;
                        item.Equipo = (EquipoDeViaje)this.cbEquipaje.SelectedItem;
                        item.PesoValija = pesoValija;
                        item.EligeComida = eligeComida;
                        item.EligeInternet = eligeInternet;
                        item.TipoClase = (Clase)this.cbClase.SelectedItem;
                        ActualizarListPasajeros(dataGridViewCrudPasajero);
                        ClearTxtCb();
                        Serializador.SerializarPasajeros(Sistema.ListaDePasajeros);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Error. verifique los datos");
            }
        }

        protected virtual void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            //int.TryParse(txtDni.Text, out int doc);
            double doc = (double)numericUpDownDni.Value;
            PreferenciasPasajero pasajeroEliminar = GetPasajero(doc);

            int indice = ValidarPasajeroViajeRealizado(pasajeroEliminar);
            if (indice == -1)
            {
                foreach (PreferenciasPasajero item in Sistema.ListaDePasajeros)
                {
                    if (item == pasajeroEliminar)
                    {
                        Sistema.ListaDePasajeros.Remove(item);
                        foreach (Vuelo itemV in Sistema.ListaDeVuelos)
                        {
                            if (itemV.IdVuelo == indice)
                            {
                                itemV.ListaPasajeros.Remove(item);
                            }
                        }
                        ActualizarListPasajeros(dataGridViewCrudPasajero);
                        ClearTxtCb();
                        Serializador.SerializarPasajeros(Sistema.ListaDePasajeros);
                        //cargo datasGridViews
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("El pasajero ya tuvo un viaje realizado");
            }
        }

        private int ValidarPasajeroViajeRealizado(PreferenciasPasajero pasajero)
        {
            //bool ret = false;
            int indice = -1;
            foreach (Vuelo item in Sistema.ListaDeVuelos)
            {
                if (item.FechaDeVuelo.Year <= DateTime.Now.Year && item.FechaDeVuelo.Month < DateTime.Now.Month)
                {
                    foreach (PreferenciasPasajero itemP in item.ListaPasajeros)
                    {
                        if (itemP == pasajero)
                        {
                            indice = item.IdVuelo;
                        }
                    }
                }
            }
            return indice;
        }

        protected virtual void btnNuevo_Click(object sender, EventArgs e)
        {
            btnCrearPasajero.Enabled = true;
            btnModificarPasajero.Enabled = false;
            btnEliminarPasajero.Enabled = false;
            ClearTxtCb();
        }
        //----------CRUD Pasajeros------------//

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

        
    }
}
