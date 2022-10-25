using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class ArchivosDeTexto
    {
        public static StreamWriter sw; //atributo para escribir
        public static StreamReader sr; //atributo para leer
        public static string path;    //ruta

        static ArchivosDeTexto()
        {  
            if(!Directory.Exists("..\\Archivos")) //si el directorio no existe
            {
             Directory.CreateDirectory("..\\Archivos"); //lo creo
            }

         ArchivosDeTexto.path = "..\\Archivos\\empleados.txt"; //le paso el path
        }

        public static bool AgregarAlArchivo(List<Persona> lista)
        {
            bool agrego = false;

            try
            {
             ArchivosDeTexto.sw = new StreamWriter(ArchivosDeTexto.path, true);//instancio StreamWriter para poder escribir,le paso un booleano para decirle agregue y no sobreescriba
                foreach (Persona item in lista)
                {
                ArchivosDeTexto.sw.WriteLine(item.ToString());//escribo los datos en el archivo
                }
               agrego = true;          
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(ArchivosDeTexto.sw!=null)
                ArchivosDeTexto.sw.Close(); //libero el objeto de memoria
            }
            
            return agrego; //retorno el booleano para saber si se agrego o no
        }


        public static bool SobreescribirElArchivo(List<Persona> lista)
        {
            bool agrego = false;
            try
            {
                using(ArchivosDeTexto.sw = new StreamWriter(ArchivosDeTexto.path))//utilizo el using para que luego se libere la memoria, esta vez no le paso un booleano, por defecto es false, sobrescribira
                {
                 foreach (Persona item in lista)
                 {
                  ArchivosDeTexto.sw.WriteLine(item.ToString());
                 }
                }              
                agrego = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return agrego;
        }




        public static List<Persona> LeerArchivoLineaALinea()
        {
            string retorno = "";
            List<Persona> lista = new List<Persona>(); //instancio lista de personas
            try
            {
                using (ArchivosDeTexto.sr = new StreamReader(ArchivosDeTexto.path)) //vuelvo a utilizar el using , pero esta vez con un StreamReader
                {
                    while ((retorno = ArchivosDeTexto.sr.ReadLine()) != null) //Mientras que lo que lee, sea distinto de null
                    {
                        string[] persona = retorno.Split(" - "); //creo un array de string donde se guardan los datos de la persona

                        Empleado p = new Empleado(persona[0], int.Parse(persona[1]), double.Parse(persona[2])); //Por cada item en la lista creo un empleado y le guardo los datos

                        lista.Add(p); //agrego el empleado a la lista
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return lista;
        }

        public static string LeerArchivoHastaElFinal()
        {
            string retorno = "";
            try
            {
                using (ArchivosDeTexto.sr = new StreamReader(ArchivosDeTexto.path))
                {
                 retorno = ArchivosDeTexto.sr.ReadToEnd();
                } 
            }
            catch (Exception e)
            {
                retorno = e.Message;
            }

            return retorno;
        }


       
    }


}
