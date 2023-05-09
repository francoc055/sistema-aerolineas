using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero
    {
        string nombre;
        string apellido;
        double dni;
        int edad;
        EquipoDeViaje equipo;
        float pesoValija;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public EquipoDeViaje Equipo { get => equipo; set => equipo = value; }
        public float PesoValija { get => pesoValija; }

        private bool EsDeBodega()
        {
            if(Equipo == EquipoDeViaje.DeBodega)
            {
                return true;
            }
            return false;
        }

        public Pasajero(string nombre, string apellido, double dni, int edad, EquipoDeViaje equipo, float pesoValija)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.equipo = equipo;
            if(EsDeBodega())
            {
                this.pesoValija = pesoValija;
            }
        }

        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"Dni: {Dni}");
            sb.AppendLine($"equipo de viaje: {Equipo}");
            if (EsDeBodega())
            {
                sb.AppendLine($"peso de la valija: {PesoValija}");
            }

            return sb.ToString();
        }

        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            if(p1 is not null && p2 is not null)
            {
                return (p1.Dni == p2.Dni);
            }
            return false;
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1.Dni == p2.Dni);
        }

    }
}
