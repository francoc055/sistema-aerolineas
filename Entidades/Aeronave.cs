using System.Text;


namespace Entidades
{
    public class Aeronave
    {
        private  string matricula;
        private static string lastMatricula = "AAAA0000";

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

        private string GenerarRandomMatricula()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numeros = "0123456789";
            char[] stringChars = new char[8];
            var random = new Random();
            string matricula = "";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    stringChars[i] = chars[random.Next(8)];
                    stringChars[j] = numeros[random.Next(8)];
                    matricula += stringChars[i];
                }
            }
            return matricula;
        }

        private string generarMatricula()
        {
            if (lastMatricula == "" || lastMatricula == matricula)
            {
                // No se ha generado una matrícula para esta aeronave aún, así que generamos una nueva
                lastMatricula = GenerarRandomMatricula();
                matricula = lastMatricula;
            }
            return lastMatricula;
        }

        public string Matricula
        {
            get
            {
                //matricula = GenerarRandomMatricula();
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        //private string GenerarMatricula()
        //{
        //    string nuevaMatricula = GenerarRandomMatricula();

        //    string nuevaMatricula;
        //    do
        //    {
        //        nuevaMatricula = GenerateMatricula();
        //    } while (nuevaMatricula == lastMatricula);

        //    lastMatricula = nuevaMatricula;
        //    return nuevaMatricula;
        //}

        public int CantidadDeAsientos { get => cantidadDeAsientos; set => cantidadDeAsientos = value; }
        public int CantidadDeBanios { get => cantidadDeBanios; }
        public bool ServicioDeInternet { get => servicioDeInternet; }
        public bool OfreceComida { get => ofreceComida; }
        public int CapacidadBodega { get => capacidadBodega; }

        private Aeronave()
        {
            lastMatricula = GenerarRandomMatricula();
            Matricula = lastMatricula;
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
            sb.AppendLine($"Matricula: {matricula}");
            sb.AppendLine($"Cantidad de asientos: {CantidadDeAsientos}");
            sb.AppendLine($"Cantidad de baños: {CantidadDeBanios}");
            sb.AppendLine($"Servicio de internet?: {ServicioDeInternet}");
            sb.AppendLine($"Ofrece Comida: {OfreceComida}");
            sb.AppendLine($"Capacidad de bodega: {CapacidadBodega}");

            return sb.ToString();
        }

        //public static bool operator ==(Aeronave avion1, Aeronave avion2)
        //{
        //    if(avion1 is not null && avion2 is not null)
        //    { 
        //        return (avion1.matricula == avion2.matricula);
        //    }
        //    return false;
        //}

        //public static bool operator !=(Aeronave avion1, Aeronave avion2)
        //{
        //    return !(avion1.matricula == avion2.matricula);
        //}

    }
}