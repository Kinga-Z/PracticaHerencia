using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaHerencia
{
    class Fijo : Empleado
    {
        int YearActual = 2021;
        private int Sueldo = 800;
        public int ComplementoAnual { get; set; }
        public int YearEntrada { get; set; }
        public Fijo(string apellidos, string nombres, int edad, string departamento, int ComplementoAnual, int YearEntrada) : base(apellidos, nombres, edad, departamento)
        {
            this.YearEntrada = YearEntrada;
            this.ComplementoAnual = ComplementoAnual;
        }
        public void MostrarFijo()
        {
            int NuevoYear = YearActual - YearEntrada;
            int SueldoTotal = NuevoYear * ComplementoAnual+Sueldo;
            Console.WriteLine("-----------------\n      Fijo\n-----------------");
            Console.WriteLine("Nombre: " + nombres + "\nApellido: " + apellidos + "\nEdad " + edad + "\nDepartamento: " + departamento);
            Console.WriteLine("-----------------\n-----------------");
            Console.WriteLine("Año de Ingreso: "+YearEntrada);
            Console.WriteLine("Valor del Complemento Anual "+ComplementoAnual+"$");
            Console.WriteLine("Años Trabajados "+NuevoYear);
            Console.WriteLine("Sueldo Actual "+SueldoTotal+"$");
        }
    }
}
