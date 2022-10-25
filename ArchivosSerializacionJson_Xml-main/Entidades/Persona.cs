using System;
using System.Xml.Serialization;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public int Edad { get { return this.edad; } set { this.edad = value; } }

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }

        public Persona(){ }

        public Persona(string n,int e) 
        {
            this.nombre = n;
            this.edad = e;
        }

        public override string ToString()
        {
            return this.nombre + " - " + this.edad;
        }


    }
}
