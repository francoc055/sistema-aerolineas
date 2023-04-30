using System.Text;

namespace Entidades
{
    public class Aeronave
    {
        int matricula;
        int cantidadDeAsientos;
        int cantidadDeBanios;
        bool servicioDeInternet;
        bool ofreceComida;
        int capacidadBodega;

        public override int GetHashCode()
        {
            Random random = new Random();
            return random.Next(10000000, 99999999);
        }

        public int Matricula
        {
            get
            {
                return GetHashCode();
            }
        }

        public int CantidadDeAsientos { get => cantidadDeAsientos; }
        public int CantidadDeBanios { get => cantidadDeBanios; }
        public bool ServicioDeInternet { get => servicioDeInternet; }
        public bool OfreceComida { get => ofreceComida; }
        public int CapacidadBodega { get => capacidadBodega; }

        private Aeronave()
        {
            this.matricula = Matricula;
        }

        public Aeronave(int cantidadDeAsientos, int cantidadDeBanios, bool servicioDeInternet, bool ofreceComida, int capacidadBodega)
        :this()
        {
            this.cantidadDeAsientos = cantidadDeAsientos;
            this.cantidadDeBanios = cantidadDeBanios;
            this.servicioDeInternet = servicioDeInternet;
            this.ofreceComida = ofreceComida;
            this.capacidadBodega = capacidadBodega;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de asientos: {CantidadDeAsientos}");
            sb.AppendLine($"Cantidad de baños: {CantidadDeBanios}");
            sb.AppendLine($"Servicio de internet?: {ServicioDeInternet}");
            sb.AppendLine($"Ofrece Comida: {OfreceComida}");
            sb.AppendLine($"Capacidad de bodega: {CapacidadBodega}");

            return sb.ToString();
        }
    }
}