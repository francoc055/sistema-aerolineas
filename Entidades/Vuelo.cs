using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vuelo
    {
        public static int ultimoId = 1;

        private int idVuelo;
        private string ciudadDePartida;
        private string ciudadDestino;
        private DateTime fechaDeVuelo;
        private Aeronave avion;
        private int cantidadAsientoClasePremium;
        private int cantidadAsientoClaseTurista;
        //private Clase clase;
        private decimal costoTurista;
        private decimal costoPremium;
        private float duracionDelVuelo;
        //private float pesoValija;
        private List<PreferenciasPasajero> listaPasajeros;

        public int IdVuelo { get => idVuelo; set => idVuelo = value; }
        public string CiudadDePartida
        {
            get
            {
                string partida = "";
                if(EsDestinoInternacional())
                {
                    partida = "Buenos Aires";
                }
                else if(EsDestinoNacional())
                {
                    partida = ciudadDePartida;
                }
                return partida;
            }
            set => ciudadDePartida = value;
        }
        public string CiudadDestino { get => ciudadDestino; set => ciudadDestino = value; }
        public DateTime FechaDeVuelo { get => fechaDeVuelo; set => fechaDeVuelo = value; }
        public Aeronave Avion { get => avion; set => avion = value; }
       // public Clase Clase1 { get => clase; set => clase = value; }
        public List<PreferenciasPasajero> ListaPasajeros { get => listaPasajeros; }

        public int CantidadAsientoClasePremium
        {
            get
            {
                return (avion.CantidadDeAsientos * 20) / 100;
            }
            set
            {
                cantidadAsientoClasePremium = value;
            }
        }

        public int CantidadAsientoClaseTurista
        {
            get
            {
                return (avion.CantidadDeAsientos * 80) / 100;
            }
            set
            {
                cantidadAsientoClaseTurista = value;
            }
        }
   
       
        public bool EsDestinoNacional()
        {
            string[] nombresDestinoN = Enum.GetNames(typeof(DestinoNacional));
            foreach (string item in nombresDestinoN)
            {
                if(ciudadDestino == item)
                {
                    return true;
                }
            }
            return false;
        }

        public bool EsDestinoInternacional()
        {
            string[] nombresDestinoI = Enum.GetNames(typeof(DestinoInternacional));
            foreach (string item in nombresDestinoI)
            {
                if (ciudadDestino == item)
                {
                    return true;
                }
            }
            return false;
        }

        private float generarDuracionDelVuelo()
        {
            float ret = 0;
            if (EsDestinoNacional())
            {
                Random horasRndN = new Random();
                ret = (float)(horasRndN.NextDouble() * (4 - 2) + 2);
            }
            else if (EsDestinoInternacional())
            {
                Random horasRndI = new Random();
                ret = (float)(horasRndI.NextDouble() * (12 - 8) + 8);
            }

            return ret;
        }
           
        public float DuracionDelVuelo
        {

            get
            {
                return duracionDelVuelo;
            }
            set
            {
                duracionDelVuelo = value;
            }
        }

        public decimal CostoTurista
        {
            get
            {
                decimal costo = 0;
                if (EsDestinoNacional())
                {
                    costo = (decimal)DuracionDelVuelo * 50;
                }
                else if (EsDestinoInternacional())
                {
                    costo = (decimal)DuracionDelVuelo * 100;
                }
                return costo;
            }
        }

        public decimal CostoPremium
        {
            get
            {
                decimal aumento = 0.35M;
                decimal porcentajeAumento = 0;
                decimal costo = 0;
                if (EsDestinoNacional())
                {
                    porcentajeAumento = CostoTurista * aumento;
                    costo = CostoTurista + porcentajeAumento;
                }
                else if (EsDestinoInternacional())
                {
                    porcentajeAumento = CostoTurista * aumento;
                    costo = CostoTurista + porcentajeAumento;
                }
                return costo;
            }
        }

        public int AsientosDisponibles
        {
            get
            {
                return Avion.CantidadDeAsientos - listaPasajeros.Count;
            }
        }

        public decimal TotalRecaudado
        {
            get
            {
                decimal total = 0;
                foreach (PreferenciasPasajero item in listaPasajeros)
                {
                    if(item.TipoClase == Clase.Turista)
                    {
                        total += CostoTurista;
                    }
                    else if(item.TipoClase == Clase.Premium)
                    {
                        total += CostoPremium;
                    }
                }
                return total;
            }
        }

        public decimal CostoNeto(decimal costo)
        {
           
            decimal impuesto = (costo * 21) / 100;
            return costo + impuesto;
            
        }

        //public static decimal GananciasCabotaje(List<Vuelo> vuelo)
        //{
        //    decimal gananciaTotal = 0;
        //    foreach (Vuelo item in vuelo)
        //    {
        //        if(item.CiudadDePartida == "Buenos Aires")
        //        {
                    
        //        }
        //    }            
        //    return gananciaTotal;
        //}

        //public static decimal GananciasInternacional(Vuelo vuelo)
        //{
        //    decimal gananciaTotal = 0;
        //    foreach (PreferenciasPasajero pasajero in vuelo.listaPasajeros)
        //    {
        //        if (pasajero.TipoClase == Clase.Premium)
        //        {
        //            gananciaTotal += vuelo.costoPremium;
        //        }
        //    }
        //    return gananciaTotal;
        //}



        private Vuelo()
        {
            listaPasajeros = new List<PreferenciasPasajero>();
        }

        public Vuelo(DateTime fechaDeVuelo, Aeronave avion, string ciudadDePartida, string ciudadDestino)
        : this()
        {
            this.idVuelo = ultimoId;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            this.cantidadAsientoClasePremium = CantidadAsientoClasePremium;
            this.cantidadAsientoClaseTurista = CantidadAsientoClaseTurista;
            this.ciudadDePartida = ciudadDePartida;
            this.ciudadDestino = ciudadDestino;
            this.duracionDelVuelo = generarDuracionDelVuelo();
            this.costoTurista = CostoTurista;
            this.costoPremium = CostoPremium;
                
            ultimoId++;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id vuelo: {IdVuelo}");
            sb.AppendLine($"Fecha de vuelo: {FechaDeVuelo}");
            sb.AppendLine($"Ciudad de partida: {CiudadDePartida}");
            sb.AppendLine($"Ciudad de destino: {CiudadDestino}");
            sb.AppendLine($"Cantidad asientos clase premium: {CantidadAsientoClasePremium}");
            sb.AppendLine($"Cantidad asientos clase turista: {CantidadAsientoClaseTurista}");
            sb.AppendLine($"Costo de la clase premium: {CostoPremium}");
            sb.AppendLine($"Costo de la clase turista: {CostoTurista}");

            return sb.ToString();
        }



        public static bool operator ==(Vuelo vuelo, PreferenciasPasajero pasajero)
        {
            if (vuelo is not null || pasajero is not null)
            {
                foreach (PreferenciasPasajero item in vuelo.ListaPasajeros)
                {
                    if (pasajero == item)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Vuelo vuelo, PreferenciasPasajero pasajero)
        {
            return !(vuelo == pasajero);
        }

        public static Vuelo operator +(Vuelo vuelo, PreferenciasPasajero pasajero)
        {
            if (vuelo is not null || pasajero is not null)
            {
                if (vuelo != pasajero)
                {
                    vuelo.listaPasajeros.Add(pasajero);
                    return vuelo;
                }
            }
            return null;
        }

        public static Vuelo operator -(Vuelo vuelo, PreferenciasPasajero pasajero)
        {
            if (vuelo is not null || pasajero is not null)
            {
                foreach (PreferenciasPasajero item in vuelo.listaPasajeros)
                {
                    if (item == pasajero)
                    {
                        vuelo.listaPasajeros.Remove(item);
                        return vuelo;
                    }
                }
            }
            return null;
        }


    }
}
