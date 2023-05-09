using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades
{
    public class Deserializador
    {
        public static List<Usuarios> DeserializarUsuarios()
        {
            try
            {
                if (File.Exists("MOCK_DATA.json"))
                {
                    using (StreamReader sr = new StreamReader("MOCK_DATA.json"))
                    {
                        string json_str = sr.ReadToEnd();

                        List<Usuarios> lista = (List<Usuarios>)System.Text.Json.JsonSerializer.Deserialize<List<Usuarios>>(json_str);
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                //MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static List<Aeronave> DeserializarAviones(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        string json_str = sr.ReadToEnd();

                        List<Aeronave> lista = (List<Aeronave>)System.Text.Json.JsonSerializer.Deserialize<List<Aeronave>>(json_str);
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }

        public static List<Vuelo> DeserializarVuelos()
        {
            try
            {
                if (File.Exists("simulacionVuelos.Json"))
                {
                    using (StreamReader sr = new StreamReader("simulacionVuelos.Json"))
                    {
                        string json_str = sr.ReadToEnd();

                        List<Vuelo> lista = JsonConvert.DeserializeObject<List<Vuelo>>(json_str);
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }


        public static List<PreferenciasPasajero> DeserializarPasajeros()
        {
            try
            {
                if (File.Exists("simulacionPasajeros.Json"))
                {
                    using (StreamReader sr = new StreamReader("simulacionPasajeros.Json"))
                    {
                        string json_str = sr.ReadToEnd();

                        List<PreferenciasPasajero> lista = JsonConvert.DeserializeObject<List<PreferenciasPasajero>>(json_str);
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
    }
}
