using System;
using System.Collections.Generic;
using Entidades;


namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Empleado> lista = new List<Empleado>();
            List<Empleado> lista2 = new List<Empleado>();
            Empleado emp3 = new Empleado("Florencia", 34, 100000);
            Empleado emp4 = new Empleado("Natalia", 48, 190000);

            lista.Add(emp3);
            lista.Add(emp4);

            //EN JSON
            /*
            if(JSON.SerializarJSON(lista))
            {
                Console.WriteLine("Se serializó Ok Json");
                Console.Clear();
            }

            lista2 = JSON.DeserializarJSON();
            Console.WriteLine("----------------------");
            Console.WriteLine("Muestro deserializado:");
            Console.WriteLine("----------------------");
            foreach (Persona item in lista2)
            {
                Console.WriteLine(item);
            }

            */


            //En XML

            /*
            if (XML.SerializarXml(lista))
            {
                Console.WriteLine("Se serializó Ok Xml");
                Console.Clear();
            }

            lista2 = XML.DeserializarXml();
            Console.WriteLine("----------------------");
            Console.WriteLine("Muestro deserializado:");
            Console.WriteLine("----------------------");
            foreach (Persona item in lista2)
            {
                Console.WriteLine(item);
            }*/


            Console.ReadKey();
        }
    }

}
