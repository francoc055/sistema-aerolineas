using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sistema
    {
        static List<PreferenciasPasajero> listaDePasajeros;
        static List<Aeronave> listaDeAeronaves;
        static List<Vuelo> listaDeVuelos;

        public static List<PreferenciasPasajero> ListaDePasajeros { get => listaDePasajeros; set => listaDePasajeros = value; }
        public static List<Vuelo> ListaDeVuelos { get => listaDeVuelos; set => listaDeVuelos = value; }
        public static List<Aeronave> ListaDeAeronaves { get => listaDeAeronaves; set => listaDeAeronaves = value; }

        static Sistema()
        {
            ListaDePasajeros = new List<PreferenciasPasajero>();
            ListaDeAeronaves = new List<Aeronave>();
            ListaDeVuelos = new List<Vuelo>();
        }

        public static List<PreferenciasPasajero> PasajerosHardcodeados()
        {
            ListaDePasajeros.Clear();

            ListaDePasajeros.Add(new PreferenciasPasajero("pepe", "peres", 40256873, 24, EquipoDeViaje.DeBodega, 15,  true, false, Clase.Turista, 1));
            ListaDePasajeros.Add(new PreferenciasPasajero("lolo", "gonzales", 43425098, 23, EquipoDeViaje.DeMano, 12, false, true, Clase.Turista, 1));
            ListaDePasajeros.Add(new PreferenciasPasajero("juan", "rodriguez", 42250432, 22, EquipoDeViaje.DeMano, 10, true, true, Clase.Premium, 1));
            ListaDePasajeros.Add(new PreferenciasPasajero("thomas", "alvares", 44324393, 26, EquipoDeViaje.DeBodega, 9, false, false, Clase.Premium, 1));
            ListaDePasajeros.Add(new PreferenciasPasajero("franco", "sanchez", 38870983, 30, EquipoDeViaje.DeBodega, 11, true, false, Clase.Turista, 1));
            ListaDePasajeros.Add(new PreferenciasPasajero("lucia", "melgar", 18870983, 33, EquipoDeViaje.DeBodega, 19, false, false, Clase.Turista, 0));
            ListaDePasajeros.Add(new PreferenciasPasajero("rocio", "pardi", 48870983, 33, EquipoDeViaje.DeMano, 10, true, false, Clase.Turista, 0));
            ListaDePasajeros.Add(new PreferenciasPasajero("camila", "sarvi", 18870983, 50, EquipoDeViaje.DeBodega, 8, false, true, Clase.Turista, 0));
            ListaDePasajeros.Add(new PreferenciasPasajero("marco", "miller", 31870983, 35, EquipoDeViaje.DeMano, 23, true, true, Clase.Turista, 0));
            ListaDePasajeros.Add(new PreferenciasPasajero("nicolas", "hardy", 33870903, 47, EquipoDeViaje.DeMano, 11, true, false, Clase.Turista, 0));

            return ListaDePasajeros;
        }

        public static List<Aeronave> AeronavesHardcodeados()
        {
            //ListaDeAeronaves.Clear();

            ListaDeAeronaves.Add(new Aeronave(400, 2, false, true, 2000));
            ListaDeAeronaves.Add(new Aeronave(350, 1, true, false, 3500));
            ListaDeAeronaves.Add(new Aeronave(600, 1, true, false, 5000));

            return ListaDeAeronaves;
        }

        public static List<Vuelo> VuelosHardcodeados()
        {


            ListaDeVuelos.Add(new Vuelo(new DateTime(2023, 4, 30, 14, 5, 24), ListaDeAeronaves[0], DestinoNacional.Iguazu.ToString(), DestinoNacional.Salta.ToString(), 123));
            ListaDeVuelos.Add(new Vuelo(new DateTime(2023, 5, 30, 8, 30, 45), ListaDeAeronaves[0], DestinoNacional.Tucuman.ToString(), DestinoNacional.Neuquen.ToString(), 234));
            ListaDeVuelos.Add(new Vuelo(new DateTime(2023, 6, 30, 6, 37, 23), ListaDeAeronaves[1],  DestinoNacional.Neuquen.ToString(), DestinoNacional.Cordoba.ToString(), 345));
            ListaDeVuelos.Add(new Vuelo(new DateTime(2023, 7, 30, 21, 40, 21), ListaDeAeronaves[1], "sarasa", DestinoInternacional.Acapulco.ToString(), 456));
            ListaDeVuelos.Add(new Vuelo(new DateTime(2023, 8, 30, 15, 30, 56), ListaDeAeronaves[2], "buenos aires", DestinoInternacional.Miami.ToString(), 567));
            ListaDeVuelos.Add(new Vuelo(new DateTime(2023, 4, 12, 12, 20, 26), ListaDeAeronaves[2], "dasd", DestinoInternacional.Roma.ToString(), 678));

            ListaDeVuelos[0] += listaDePasajeros[0];
            ListaDeVuelos[0] += listaDePasajeros[1];
            ListaDeVuelos[0] += listaDePasajeros[2];
            ListaDeVuelos[0] += listaDePasajeros[3];
            ListaDeVuelos[0] += listaDePasajeros[4];

            

            return ListaDeVuelos;
        }



    }
}
