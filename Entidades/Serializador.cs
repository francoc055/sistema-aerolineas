using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializador
    {
        List<Vuelo> listaDestinos;

        public Serializador()
        {
            listaDestinos = new List<Vuelo>();
        }
        

        //public void CrearVuelos()
        //{
        //    Pasajero pasajero1 = new Pasajero("pepe", "peres", 40256873, 24, EquipoDeViaje.DeBodega, 11);
        //    Pasajero pasajero2 = new Pasajero("lolo", "gonzales", 434250983, 23, EquipoDeViaje.DeMano, 12);
        //    Pasajero pasajero3 = new Pasajero("juan", "rodriguez", 42250432, 22, EquipoDeViaje.DeMano, 12);
        //    Pasajero pasajero4 = new Pasajero("thomas", "alvares", 443243983, 26, EquipoDeViaje.DeBodega, 10);
        //    Pasajero pasajero5 = new Pasajero("franco", "sanchez", 38870983, 30, EquipoDeViaje.DeBodega, 12);
        //    Pasajero pasajero6 = new Pasajero("lucia", "suarez", 1243250983, 70, EquipoDeViaje.DeMano, 9);
        //    Pasajero pasajero7 = new Pasajero("martin", "boullon", 32250983, 44, EquipoDeViaje.DeMano, 23);
        //    Pasajero pasajero8 = new Pasajero("agustina", "avallone", 33670983, 54, EquipoDeViaje.DeBodega, 7);
        //    Pasajero pasajero9 = new Pasajero("nicolas", "gomez", 41092509, 29, EquipoDeViaje.DeMano, 9);
        //    Pasajero pasajero10 = new Pasajero("ailen", "lopez", 35060983, 34, EquipoDeViaje.DeMano, 22);

        //    Pasajero pasajero01 = new Pasajero("rocio", "peres", 40256828, 24, EquipoDeViaje.DeBodega, 15);
        //    Pasajero pasajero02 = new Pasajero("santino", "gonzales", 434250900, 23, EquipoDeViaje.DeMano, 32);
        //    Pasajero pasajero03 = new Pasajero("nicolas", "rodriguez", 42250488, 22, EquipoDeViaje.DeMano, 12);
        //    Pasajero pasajero04 = new Pasajero("ivan", "alvares", 443243911, 26, EquipoDeViaje.DeBodega,18);
        //    Pasajero pasajero05 = new Pasajero("ezequiel", "sanchez", 38870956, 30, EquipoDeViaje.DeBodega, 17);
        //    Pasajero pasajero06 = new Pasajero("martina", "suarez", 1243250967, 70, EquipoDeViaje.DeMano, 16);
        //    Pasajero pasajero07 = new Pasajero("clara", "boullon", 32250935, 44, EquipoDeViaje.DeMano, 14);
        //    Pasajero pasajero08 = new Pasajero("wanda", "lopez", 33670908, 54, EquipoDeViaje.DeBodega, 10);



        //    Aeronave avion = new Aeronave(30, 2, false, true, 100);
        //    Vuelo vuelo1 = new Vuelo(new DateTime(2023, 4, 30, 15, 30, 44), avion, Clase.Turista, DestinoNacional.Iguazu.ToString(), DestinoNacional.Salta.ToString());
        //    Vuelo vuelo2 = new Vuelo(new DateTime(2023, 5, 30), avion, Clase.Premium, DestinoNacional.Tucuman.ToString(), DestinoNacional.Neuquen.ToString());
        //    Vuelo vuelo3 = new Vuelo(new DateTime(2023, 6, 30), avion, Clase.Turista, DestinoNacional.Neuquen.ToString(), DestinoNacional.Cordoba.ToString());
        //    Vuelo vuelo4 = new Vuelo(new DateTime(2023, 7, 30), avion, Clase.Premium, "sarasa", DestinoInternacional.Acapulco.ToString());
        //    Vuelo vuelo5 = new Vuelo(new DateTime(2023, 8, 30), avion, Clase.Turista, "buenos aires", DestinoInternacional.Miami.ToString());
           
        //    Aeronave avion2 = new Aeronave(30, 1, true, false, 200);
        //    Vuelo vuelo6 = new Vuelo(new DateTime(2023, 4, 12), avion2, Clase.Turista, DestinoNacional.Iguazu.ToString(), DestinoNacional.Salta.ToString());
        //    Vuelo vuelo7 = new Vuelo(new DateTime(2023, 5, 3), avion2, Clase.Premium, DestinoNacional.Tucuman.ToString(), DestinoNacional.Neuquen.ToString());
        //    Vuelo vuelo8 = new Vuelo(new DateTime(2023, 6, 5), avion2, Clase.Turista, DestinoNacional.Neuquen.ToString(), DestinoNacional.Cordoba.ToString());
        //    Vuelo vuelo9 = new Vuelo(new DateTime(2023, 9, 19), avion2, Clase.Premium, "buenos aires", DestinoInternacional.Roma.ToString());

        //    vuelo1 += pasajero1;
        //    vuelo1 += pasajero2;
        //    vuelo2 += pasajero3;
        //    vuelo2 += pasajero4;
        //    vuelo3 += pasajero5;
        //    vuelo3 += pasajero6;
        //    vuelo4 += pasajero7;
        //    vuelo4 += pasajero8;
        //    vuelo5 += pasajero9;
        //    vuelo5 += pasajero10;

        //    vuelo6 += pasajero01;
        //    vuelo6 += pasajero02;
        //    vuelo7 += pasajero03;
        //    vuelo7 += pasajero04;
        //    vuelo8 += pasajero05;
        //    vuelo8 += pasajero06;
        //    vuelo9 += pasajero07;
        //    vuelo9 += pasajero08;

        //    listaDestinos.Add(vuelo1);
        //    listaDestinos.Add(vuelo2);
        //    listaDestinos.Add(vuelo3);
        //    listaDestinos.Add(vuelo4);
        //    listaDestinos.Add(vuelo5);
        //    listaDestinos.Add(vuelo6);
        //    listaDestinos.Add(vuelo7);
        //    listaDestinos.Add(vuelo8);
        //    listaDestinos.Add(vuelo9);
            

        //}



        public void Serializar()
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("simulacionVuelos.json"))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;
                string objJson = System.Text.Json.JsonSerializer.Serialize(listaDestinos, opciones);
                sw.WriteLine(objJson);
                Console.WriteLine(objJson);
            }
            
        }


        ////-----------------------------------------------------------------------------------/////
        public static void SerializarPasajeros(List<PreferenciasPasajero> listaPasajeros)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("simulacionPasajeros.json"))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;
                string objJson = System.Text.Json.JsonSerializer.Serialize(listaPasajeros, opciones);
                sw.WriteLine(objJson);
                Console.WriteLine(objJson);
            }
        }

        public static void SerializarVuelos(List<Vuelo> listaVuelos)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("simulacionVuelos.json"))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;
                string objJson = System.Text.Json.JsonSerializer.Serialize(listaVuelos, opciones);
                sw.WriteLine(objJson);
                Console.WriteLine(objJson);
            }

        }
    }
}
