using System;
using System.Collections.Generic;
using System.IO;
using Entidades;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Empleado emp1 = new Empleado("Juan", 25, 90000);
            Empleado emp2 = new Empleado("Jose", 45, 180000);

            List<Persona> lista = new List<Persona>();

            lista.Add(emp1);
            lista.Add(emp2);

            if(ArchivosDeTexto.AgregarAlArchivo(lista))
            {
                Console.WriteLine("Se agregó correctamente");
                Console.Clear();
            }

            List<Persona>lista2=ArchivosDeTexto.LeerArchivoLineaALinea();
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("Leo línea a línea:");
            Console.WriteLine("------------------");
            foreach (Persona item in lista2)
            {
                Console.WriteLine(item);
            }

            lista.Clear();

            Empleado emp3 = new Empleado("Florencia", 34, 100000);
            Empleado emp4 = new Empleado("Natalia", 48, 190000);

            lista.Add(emp3);
            lista.Add(emp4);

            if(ArchivosDeTexto.SobreescribirElArchivo(lista))
            {
                Console.WriteLine("Se sobreescribió correctamente");
                Console.Clear();
            }
            lista.Clear();
            lista.Add(emp1);
            lista.Add(emp2);

            if (ArchivosDeTexto.AgregarAlArchivo(lista))
            {
                Console.WriteLine("Se agregó correctamente");
            }



            string listaString = ArchivosDeTexto.LeerArchivoHastaElFinal();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("Leo hasta el final:");
            Console.WriteLine("------------------");
            Console.WriteLine(listaString);


            if(!File.Exists("..\\Archivos\\empleadosCopiados.txt"))
            {
                File.Copy(ArchivosDeTexto.path, "..\\Archivos\\empleadosCopiados.txt");
            }
            

            Console.ReadKey();
            
        }
    }
}
