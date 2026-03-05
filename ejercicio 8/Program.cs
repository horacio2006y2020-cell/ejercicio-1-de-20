using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> empleados = new Dictionary<int, string>();

            empleados.Add(1, "Luis");

            empleados[1] = "Pedro";

            Console.WriteLine(empleados[1]);
        }
    }
}
