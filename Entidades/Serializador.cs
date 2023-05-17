using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializador
    {

        public Serializador()
        {
           
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

        public static void SerializarAeronaves(List<Aeronave> listaAeronaves)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("simulacionAeronaves.json"))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;
                string objJson = System.Text.Json.JsonSerializer.Serialize(listaAeronaves, opciones);
                sw.WriteLine(objJson);
                Console.WriteLine(objJson);
            }
        }

        public static void SerializarRegistros(List<Usuarios> registros)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("usuarios.log"))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;
                string objJson = System.Text.Json.JsonSerializer.Serialize(registros, opciones);
                sw.WriteLine(objJson);
                Console.WriteLine(objJson);
            }
        }
    }
}
