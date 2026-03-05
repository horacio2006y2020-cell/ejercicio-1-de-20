using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, (string Nombre, int Edad, string Carrera)> estudiantes =
           new Dictionary<int, (string, int, string)>();

            estudiantes.Add(1001, ("Ana", 20, "Ingenieria"));
            estudiantes.Add(1002, ("Carlos", 22, "Derecho"));
            estudiantes.Add(1003, ("Maria", 19, "Medicina"));
        }
    }
}
