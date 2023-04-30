using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Destino : Vuelo
    {
        Enum CiudadDestino { get; set; }


        public bool EsDestinoNacional()
        {
            return CiudadDestino.GetType() == typeof(DestinoNacional);
        }

        public bool EsDestinoInternacional()
        {
            return CiudadDestino.GetType() == typeof(DestinoInternacional);
        }

        public float DuracionDelVuelo
        {

            get
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


        public decimal CostoClase
        {
            get
            {
                decimal costo = 0;
                if (base.clase == Clase.Turista)
                {
                    costo = CostoTurista;
                }
                else if (this.clase == Clase.Premium)
                {
                    costo = CostoPremium;
                }

                return costo;
            }
        }

        public Destino(Vuelo vuelo, Enum ciudadDestino) 
            :base(vuelo.FechaDeVuelo, vuelo.Avion, vuelo.Clase1, vuelo.PesoValija)
        {
            this.CiudadDestino = ciudadDestino;
            base.costoClase = CostoClase;
            base.duracionDelVuelo = DuracionDelVuelo;
        }

        public Destino(DateTime fechaDeVuelo, Aeronave avion, Clase clase,float pesoValija, Enum ciudadDestino)
           : this(new Vuelo(fechaDeVuelo, avion, clase, pesoValija), ciudadDestino)
        {
        }

        public override string MostrarVuelo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarVuelo());
            sb.AppendLine($"Destino: {CiudadDestino}");

            return sb.ToString();
        }
    }
}
