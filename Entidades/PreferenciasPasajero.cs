using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PreferenciasPasajero : Pasajero
    {
        bool eligeComida;
        bool eligeInternet;
        Clase tipoClase;
        int cantVuelo;

        public bool EligeComida { get => eligeComida; set => eligeComida = value; }
        public bool EligeInternet { get =>  eligeInternet; set => eligeInternet = value; }

        public Clase TipoClase { get => tipoClase; set => tipoClase = value; }
        
        public int CantVuelo { get => cantVuelo; set => cantVuelo = value; }

        public PreferenciasPasajero(string nombre, string apellido, double dni, int edad, EquipoDeViaje equipo, float pesoValija, bool eligeComida, bool eligeInternet, Clase tipoClase, int cantVuelo)
            : base(nombre, apellido, dni, edad, equipo, pesoValija)
        {
            this.eligeComida = eligeComida;
            this.eligeInternet = eligeInternet;
            this.tipoClase = tipoClase;
            this.cantVuelo = cantVuelo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Elige comida: {EligeComida}");
            sb.AppendLine($"Elige internet: {EligeInternet}");

            return sb.ToString();
        }


    }
}
