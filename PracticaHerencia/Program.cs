using System;

namespace PracticaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Temporal Miguel = new Temporal("Aguarte","Miguel",25,"Finanzas",550,2020,2019);
            Miguel.MostrarTemporal();
            Fijo Eddu = new Fijo("Copiano", "Eddu", 45,"Gestion",20,2005);
            Eddu.MostrarFijo();
            Hora George = new Hora("Floyd", "George", 21, "Marketing",17,300);
            George.MostrarHora();
        }
    }
}
