using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaHerencia
{
    class EmpleadoHoras:Empleado
    {
        public int preciohora = 10;

        public int numerohoras { get; set; }

        public int Horatrabajada()
        {
            return this.preciohora;
        }

        public int SueldoCalculado()
        {
            int total;

            total = numerohoras * preciohora;
            return total;

        }
    }
}
