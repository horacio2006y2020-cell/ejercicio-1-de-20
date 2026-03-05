using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estudiantes = new Dictionary<int, string>();

            estudiantes.Add(1, "Juan");
            estudiantes.Add(2, "Maria");
            estudiantes.Add(3, "Carlos");

            estudiantes.Remove(2);

            foreach (var item in estudiantes)
                Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}
