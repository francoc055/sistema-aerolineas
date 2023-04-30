using System;
using System.Collections.Generic;
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


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public EquipoDeViaje Equipo { get => equipo; set => equipo = value; }
      

        public Pasajero(string nombre, string apellido, double dni, int edad, EquipoDeViaje equipo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.equipo = equipo;
        }
    }
}
