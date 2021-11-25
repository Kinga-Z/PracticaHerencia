using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaHerencia
{
    class EmpleadoFijo:Empleado
    {
        public int complementoanual = 10;

        public int sueldo = 500;

        public int añoentrada { get; set; }
        public int Suma()
        {
            int totalfijo, años, sumaanual;

            años = 2021 - añoentrada;

            sumaanual = años * complementoanual;

            totalfijo = sueldo + sumaanual;

            return totalfijo;
            
        }

    }
}
