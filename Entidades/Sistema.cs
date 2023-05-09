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

        
        static Sistema()
        {
            listaDePasajeros = new List<PreferenciasPasajero>();
            listaDeAeronaves = new List<Aeronave>();
            listaDeVuelos = new List<Vuelo>();
        }

        public static List<PreferenciasPasajero> PasajerosHardcodeados()
        {
            listaDePasajeros.Clear();

            listaDePasajeros.Add(new PreferenciasPasajero("pepe", "peres", 40256873, 24, EquipoDeViaje.DeBodega, 15,  true, false, Clase.Turista, true));
            listaDePasajeros.Add(new PreferenciasPasajero("lolo", "gonzales", 434250983, 23, EquipoDeViaje.DeMano, 12, false, true, Clase.Turista, true));
            listaDePasajeros.Add(new PreferenciasPasajero("juan", "rodriguez", 42250432, 22, EquipoDeViaje.DeMano, 10, true, true, Clase.Premium, true));
            listaDePasajeros.Add(new PreferenciasPasajero("thomas", "alvares", 443243983, 26, EquipoDeViaje.DeBodega, 9, false, false, Clase.Premium, true));
            listaDePasajeros.Add(new PreferenciasPasajero("franco", "sanchez", 38870983, 30, EquipoDeViaje.DeBodega, 11, true, false, Clase.Turista, true));
            listaDePasajeros.Add(new PreferenciasPasajero("lucia", "melgar", 18870983, 33, EquipoDeViaje.DeBodega, 19, false, false, Clase.Turista, false));
            listaDePasajeros.Add(new PreferenciasPasajero("rocio", "pardi", 48870983, 33, EquipoDeViaje.DeMano, 10, true, false, Clase.Turista, false));
            listaDePasajeros.Add(new PreferenciasPasajero("camila", "sarvi", 18870983, 50, EquipoDeViaje.DeBodega, 8, false, true, Clase.Turista, false));
            listaDePasajeros.Add(new PreferenciasPasajero("marco", "miller", 31870983, 35, EquipoDeViaje.DeMano, 23, true, true, Clase.Turista, false));
            listaDePasajeros.Add(new PreferenciasPasajero("nicolas", "hardy", 33870983, 47, EquipoDeViaje.DeMano, 11, true, false, Clase.Turista, false));

            return listaDePasajeros;
        }

        public static List<Aeronave> AeronavesHardcodeados()
        {
            listaDeAeronaves.Add(new Aeronave(30, 2, false, true, 100));
            listaDeAeronaves.Add(new Aeronave(45, 1, true, false, 200));
            listaDeAeronaves.Add(new Aeronave(40, 1, true, false, 175));

            return listaDeAeronaves;
        }

        public static List<Vuelo> VuelosHardcodeados()
        {
            List<Aeronave> aviones = AeronavesHardcodeados();
            List<PreferenciasPasajero> pasajeros = PasajerosHardcodeados();

            listaDeVuelos.Add(new Vuelo(new DateTime(2023, 4, 30), aviones[0], Clase.Turista, DestinoNacional.Iguazu.ToString(), DestinoNacional.Salta.ToString()));
            listaDeVuelos.Add(new Vuelo(new DateTime(2023, 5, 30), aviones[0], Clase.Premium, DestinoNacional.Tucuman.ToString(), DestinoNacional.Neuquen.ToString()));
            listaDeVuelos.Add(new Vuelo(new DateTime(2023, 6, 30), aviones[1], Clase.Turista, DestinoNacional.Neuquen.ToString(), DestinoNacional.Cordoba.ToString()));
            listaDeVuelos.Add(new Vuelo(new DateTime(2023, 7, 30), aviones[1], Clase.Premium,  "sarasa", DestinoInternacional.Acapulco.ToString()));
            listaDeVuelos.Add(new Vuelo(new DateTime(2023, 8, 30), aviones[2], Clase.Turista, "buenos aires", DestinoInternacional.Miami.ToString()));
            listaDeVuelos.Add(new Vuelo(new DateTime(2023, 4, 12), aviones[2], Clase.Turista, "dasd", DestinoInternacional.Roma.ToString()));

            listaDeVuelos[0] += pasajeros[0];
            listaDeVuelos[0] += pasajeros[1];
            listaDeVuelos[0] += pasajeros[2];
            listaDeVuelos[0] += pasajeros[3];
            listaDeVuelos[0] += pasajeros[4];

            return listaDeVuelos;
        }



    }
}
