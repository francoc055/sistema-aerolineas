using Entidades;
using Newtonsoft.Json;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        //Aeronave avion = new Aeronave(30, 2, false, true, 100);
        //Aeronave avion2 = new Aeronave(30, 2, false, true, 100);
        //Aeronave avion3 = new Aeronave(30, 2, false, true, 100);
        //Console.WriteLine(avion.Mostrar());
        //Console.WriteLine(avion2.Mostrar());
        //Console.WriteLine(avion3.Mostrar());
        //Vuelo vuelo1 = new Vuelo(new DateTime(2023, 4, 30), avion, Clase.Turista, 18, DestinoNacional.Iguazu.ToString(), DestinoNacional.Salta.ToString());

        //Destino destino2 = new Destino(new DateTime(2023, 5, 30), avion, Clase.Premium, 18, DestinoNacional.Cordoba);
        //Destino destino3 = new Destino(new DateTime(2023, 6, 30), avion, Clase.Turista, 18, DestinoNacional.Bariloche);


        //Console.WriteLine(avion.Mostrar());
        //Console.WriteLine(destino1.MostrarVuelo());
        //Console.WriteLine(destino2.MostrarVuelo());
        //Console.WriteLine(destino3.MostrarVuelo());

        //Serializador ser = new Serializador();

        //ser.CrearVuelos();
        //ser.Serializar();
        //List<Vuelo> lista = Deserializador.DeserializarVuelos();
        //string json = @"[
        //                  {
        //                    ""IdVuelo"": 1,
        //                    ""CiudadDePartida"": ""Buenos Aires"",
        //                    ""CiudadDestino"": ""salta"",
        //                    ""FechaDeVuelo"": ""2023-04-30T00:00:00"",
        //                    ""Avion"": {
        //                      ""Matricula"": 88505175,
        //                      ""CantidadDeAsientos"": 30,
        //                      ""CantidadDeBanios"": 2,
        //                      ""ServicioDeInternet"": false,
        //                      ""OfreceComida"": true,
        //                      ""CapacidadBodega"": 100
        //                    },
        //                    ""Clase1"": 1,
        //                    ""CantidadAsientoClasePremium"": 6,
        //                    ""CantidadAsientoClaseTurista"": 24,
        //                    ""PesoValija"": 18,
        //                    ""DuracionDelVuelo"": 0,
        //                    ""CostoTurista"": 0,
        //                    ""CostoPremium"": 0,
        //                    ""CostoClase"": 0
        //                  }
        //                ]";

        //List<Vuelo> vuelos = JsonConvert.DeserializeObject<List<Vuelo>>(json);

        //foreach (Vuelo item in lista)
        //{
        //    Console.WriteLine(item.ToString());
        //}


        //DestinoNacional[] destinoN = (DestinoNacional[])Enum.GetValues(typeof(DestinoNacional));
        //string[] nombres = Enum.GetNames(typeof(DestinoNacional));

        //foreach (DestinoNacional c in destinoN)
        //{
        //    Console.WriteLine(c);
        //}

        //foreach (string n in nombres)
        //{
        //    Console.WriteLine(n);
        //}

        //Pasajero pasajero1 = new Pasajero("pepe", "peres", 40256873, 24, EquipoDeViaje.DeBodega);
        //Pasajero pasajero2 = new Pasajero("lolo", "gonzales", 40250983, 24, EquipoDeViaje.DeMano);

        //vuelo1 += pasajero1;
        //vuelo1 += pasajero2;

        //foreach (Pasajero item in vuelo1.ListaPasajeros)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        ////-------------------------------------------------------------------------------------------////

        //------------PASAJEROS SISTEMA PRUEBA------------------//
        //Serializador.SerializarPasajeros();
        //List<PreferenciasPasajero> pasajeros = Deserializador.DeserializarPasajeros();
        //foreach (Pasajero item in pasajeros)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        //------------VUELOS SISTEMA PRUEBA--------------------//
        //Serializador.SerializarVuelos();
        //List<Vuelo> vuelos = Deserializador.DeserializarVuelos();
        //foreach (Vuelo item in vuelos)
        //{
        //    Console.WriteLine(item.ToString());
        //}
    }
}