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
        bool enVuelo;

        public bool EligeComida { get => eligeComida; set => eligeComida = value; }
        public bool EligeInternet { get =>  eligeInternet; set => eligeInternet = value; }

        public Clase TipoClase { get => tipoClase; set => tipoClase = value; }
        public bool EnVuelo { get => enVuelo; set => enVuelo = value; }

        public PreferenciasPasajero(string nombre, string apellido, double dni, int edad, EquipoDeViaje equipo, float pesoValija, bool eligeComida, bool eligeInternet, Clase tipoClase, bool enVuelo)
            : base(nombre, apellido, dni, edad, equipo, pesoValija)
        {
            this.eligeComida = eligeComida;
            this.eligeInternet = eligeInternet;
            this.tipoClase = tipoClase;
            this.enVuelo = enVuelo;
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
