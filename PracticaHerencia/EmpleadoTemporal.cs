using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaHerencia
{
    class EmpleadoTemporal:Empleado
    {
        public string ingreso { get; set; }
        public string salida { get; set; }

        public int sueldo = 500;

        public int Sueldototal()
        {
            return this.sueldo;
        }
    }
}
