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

namespace Vista
{
    public partial class vistaVendedor : VistaUsuario
    {
        List<PreferenciasPasajero> listaPasajeros;
        List<Vuelo> listaVuelos;

        public vistaVendedor()
        {
            InitializeComponent();
            listaVuelos = new List<Vuelo>();
            listaPasajeros = new List<PreferenciasPasajero>();
        }


        private void vistaVendedor_Load_1(object sender, EventArgs e)
        {
            labelCambiar.Text = "Vendedor";
            listaVuelos = Deserializador.DeserializarVuelos();
            listaPasajeros = Deserializador.DeserializarPasajeros();

            CargarDataGridVuelo();
            CargarDataEstadisticas();
            CargarDataVenderViaje();
        }

        //----------Listar viajes------------//
        private void CargarDataGridVuelo()
        {
            foreach (Vuelo v in listaVuelos)
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

                foreach (Vuelo item in listaVuelos)
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
            //estadisticas historicas
            bool flag = false;
            foreach (Vuelo item in listaVuelos)
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
            foreach (Vuelo vuelo in listaVuelos)
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



        private void CargarDataVenderViaje()
        {
            foreach (PreferenciasPasajero item in listaPasajeros)
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
                foreach (Vuelo v in listaVuelos)
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
    }

}
