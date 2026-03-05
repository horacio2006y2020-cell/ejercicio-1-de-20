using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ciudades = new Dictionary<int, string>();

            ciudades.Add(1, "Guatemala");
            ciudades.Add(2, "Antigua");
            ciudades.Add(3, "Peten");
            ciudades.Add(4, "Escuintla");
            ciudades.Add(5, "Xela");

            Console.WriteLine("Ciudad con codigo 3: " + ciudades[3]);
        }
    }
}
