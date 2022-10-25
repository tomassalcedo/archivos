using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado: Persona
    {
        private double salario;

        public Empleado()
        {

        }

        public Empleado(string n,int e,double s):base(n,e)
        {
            this.salario = s;
        }

        public double Salario { get { return this.salario; } set { this.salario = value; } }

        public override string ToString()
        {
            return base.ToString() +" - " + this.salario;
        }
    }
}
