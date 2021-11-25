using System;

namespace PracticaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoTemporal empleado;


            empleado = new EmpleadoTemporal();


            Console.WriteLine("Apellido: " + empleado.apellidos + ("Zambrano"));

            Console.WriteLine("Nombre: " + empleado.nombres + ("Jorge"));

            Console.Write("Edad: ");

            Console.WriteLine(empleado.edad = (30));

            Console.WriteLine("Departamento: " + empleado.departamento + ("Finanzas"));

            Console.WriteLine("Fecha de Ingreso: " + empleado.ingreso + ("2010/10/10"));

            Console.WriteLine("Fecha de salida: " + empleado.salida + ("2011/03/10"));

            Console.WriteLine("El sueldo es : " + empleado.Sueldototal());

            Console.WriteLine("-----------------------------------");

            EmpleadoHoras empleado2 = new EmpleadoHoras();

            Console.WriteLine("Apellido: " + empleado2.apellidos + ("Alonso "));

            Console.WriteLine("Nombre: " + empleado2.nombres + ("Anthony"));

            Console.WriteLine("Edad: " + empleado2.edad + 30);

            Console.WriteLine("Departamento: " + empleado2.departamento + ("Recursos humanos"));

            Console.WriteLine("Precio de la hora: " + empleado2.Horatrabajada());

            Console.Write("Numero de horas: ");

            Console.WriteLine(empleado2.numerohoras = (8));

            Console.WriteLine("El sueldo es : " + empleado2.SueldoCalculado());

            EmpleadoFijo empleado3 = new EmpleadoFijo();

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Apellido: " + empleado3.apellidos + ("Chavez "));

            Console.WriteLine("Nombre: " + empleado3.nombres + ("Fabrizzio"));

            Console.Write("Edad: ");

            Console.WriteLine( empleado3.edad = (50));

            Console.WriteLine("Departamento: " + empleado3.departamento + ("Soporte"));

            Console.Write("El año de entrada es : ");

            Console.WriteLine(empleado3.añoentrada= (2010));

            Console.WriteLine("El sueldo es " +empleado3.Suma());


        }
    }
}
