using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> notas = new Dictionary<string, double>()
        {
            {"Juan",80},
            {"Maria",90},
            {"Carlos",70}
        };

            double suma = 0;

            foreach (var item in notas)
                suma += item.Value;

            Console.WriteLine("Promedio: " + (suma / notas.Count));
        }
    }
}
