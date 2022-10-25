using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Entidades
{
    public static class JSON
    {
        public static StreamWriter writer;
        public static StreamReader reader;
        public static string path;

        static JSON()
        {
            JSON.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            JSON.path += "\\Empleados.json";
        }

        public static bool SerializarJSON(List<Empleado> lista)
        {
            bool retorno = false;
            try
            {
                using(JSON.writer=new StreamWriter(JSON.path))
                {

                    string json = JsonSerializer.Serialize(lista);

                    JSON.writer.Write(json);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }

        public static List<Empleado> DeserializarJSON()
        {
            List<Empleado> aux = new List<Empleado>();
            try
            {
                using (JSON.reader = new StreamReader(JSON.path))
                {
                    string json = JSON.reader.ReadToEnd();

                    aux = JsonSerializer.Deserialize<List<Empleado>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return aux;
        }

    }
}
