using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vuelo
    {
        protected string ciudadDePartida;
        protected DateTime fechaDeVuelo;
        protected Aeronave avion;
        protected int cantidadAsientoClasePremium;
        protected int cantidadAsientoClaseTurista;
        protected Clase clase;
        protected decimal costoClase;
        protected float duracionDelVuelo;
        protected float pesoValija;
        protected List<Pasajero> listaPasajeros;
       


        public string CiudadDePartida { get => ciudadDePartida; }
        public DateTime FechaDeVuelo { get => fechaDeVuelo; }
        public Aeronave Avion { get => avion; }
        public Clase Clase1 { get => clase; }

        public int CantidadAsientoClasePremium
        {
            get
            {
                return (avion.CantidadDeAsientos * 20) / 100;
            }
        }

        public int CantidadAsientoClaseTurista
        {
            get
            {
                return (avion.CantidadDeAsientos * 80) / 100;
            }
        }
   
        public float PesoValija
        {
            get
            {
                float ret = 0;
                float total = pesoValija + this.avion.CapacidadBodega;
                if(pesoValija < total)
                {
                    if (this.clase == Clase.Turista)
                    {
                        if (pesoValija <= 25)
                        {
                            ret = pesoValija;
                        }
                    }
                    else if (this.clase == Clase.Premium)
                    {
                        if (pesoValija <= 42)
                        {
                            ret = pesoValija;
                        }
                    }
                }
     
                return ret;
            }
        }

        
        private Vuelo()
        {
            this.ciudadDePartida = "Buenos Aires";
            listaPasajeros = new List<Pasajero>();
        }

        public Vuelo(DateTime fechaDeVuelo, Aeronave avion, Clase clase, float pesoValija)
        : this()
        {
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            this.cantidadAsientoClasePremium = CantidadAsientoClasePremium;
            this.cantidadAsientoClaseTurista = CantidadAsientoClaseTurista;
            this.clase = clase;
            this.pesoValija = pesoValija;
        }
        

        public virtual string MostrarVuelo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha de vuelo: {FechaDeVuelo}");
            sb.AppendLine($"Ciudad de partida: {CiudadDePartida}");
            sb.AppendLine($"Cantidad asientos clase premium: {CantidadAsientoClasePremium}");
            sb.AppendLine($"Cantidad asientos clase turista: {CantidadAsientoClaseTurista}");
            sb.AppendLine($"Clase: {clase}");
            sb.AppendLine($"Peso valija: {pesoValija}");

            return sb.ToString();
        }
    }
}
