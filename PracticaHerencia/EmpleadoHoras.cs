using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaHerencia
{
    class Hora:Empleado
    {
        public int ValorHora { get; set; }
        public int HoraTrabajo { get; set; }
        public Hora(string apellidos, string nombres, int edad, string departamento, int ValorHora, int HoraTrabajo) : base(apellidos, nombres, edad, departamento)
        {
            this.ValorHora = ValorHora;
            this.HoraTrabajo = HoraTrabajo;
        }
        public void MostrarHora()
        {
            Console.WriteLine("-----------------\n      Hora\n-----------------");
            Console.WriteLine("Nombre: " + nombres + "\nApellido: " + apellidos + "\nEdad " + edad + "\nDepartamento: " + departamento);
            Console.WriteLine("-----------------\n-----------------");
            Console.WriteLine("Valor de Hora: "+ValorHora);
            Console.WriteLine("Valor de la Hora Trabajada "+ValorHora);
            Console.WriteLine("Horas Trabajadas "+HoraTrabajo);
            Console.WriteLine("Sueldo Total "+HoraTrabajo*ValorHora);
        }
    }
}
