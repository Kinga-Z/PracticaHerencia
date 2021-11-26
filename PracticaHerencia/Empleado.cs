using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaHerencia
{
    class Empleado
    {
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public int edad { get; set; }
        public string departamento { get; set; }
        public Empleado(string apellidos, string nombres, int edad, string departamento)
        {
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.edad = edad;
            this.departamento = departamento;
        }
    }
}
