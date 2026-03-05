using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estudiantes = new Dictionary<int, string>();

            estudiantes.Add(1, "Juan");
            estudiantes.Add(2, "Maria");
            estudiantes.Add(3, "Carlos");
            Console.WriteLine("Nombre con ID 2: " + estudiantes[2]);
        }
    }
}
