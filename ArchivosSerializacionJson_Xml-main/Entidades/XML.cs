using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public static class XML
    {
        private static StreamWriter writer;
        private static StreamReader reader;
        public static XmlSerializer serializer;
        private static string path;

        static XML()
        {
          XML.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
          XML.path += "\\Empleados.xml";
        }
        
        public static bool SerializarXml(List<Empleado> lista)
        {
            bool retorno = false;
            try
            {
                using (XML.writer = new StreamWriter(XML.path))
                {
                    XML.serializer = new XmlSerializer(typeof(List<Empleado>));

                    XML.serializer.Serialize(XML.writer, lista);
                }
             retorno = true;
            }
            catch (Exception e)
            {
             Console.WriteLine(e.Message);
            }
            return retorno;
        }

        public static List<Empleado> DeserializarXml()
        {
            List<Empleado> aux = new List<Empleado>();
            try
            {
                using (XML.reader= new StreamReader(XML.path))
                {
                    XML.serializer = new XmlSerializer(typeof(List<Empleado>));

                    aux = (List<Empleado>)XML.serializer.Deserialize(XML.reader);
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
