using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaHerencia
{
    class Temporal : Empleado
    {
        private int Sueldo = 700;
        public int FechaSalida { get; set; }
        public int FechaIngreso { get; set; }
        public Temporal(string apellidos, string nombres, int edad, string departamento, int Sueldo, int FechaSalida, int FechaIngreso):base(apellidos,nombres,edad,departamento)
        {
            this.FechaIngreso = FechaIngreso;
            this.FechaSalida = FechaSalida;
        }
        public void MostrarTemporal()
        {
            Console.WriteLine("-----------------\n    Temporal\n-----------------");
            Console.WriteLine("Nombre: "+nombres+"\nApellido: "+apellidos+"\nEdad: "+edad+"\nDepartamento: "+departamento+"");
            Console.WriteLine("-----------------\n-----------------");
            Console.WriteLine("El sueldo es de "+Sueldo+"$ mensuales");
            Console.WriteLine("El año de Ingreso es "+FechaIngreso);
            Console.WriteLine("El año de Salida es "+FechaSalida);
        }

    }
}
