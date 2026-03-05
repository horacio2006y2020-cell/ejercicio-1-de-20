using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> notas = new Dictionary<string, double>();

            notas.Add("Marlon", 85);
            notas.Add("Julia", 90);
            notas.Add("Jose", 75);

            Console.WriteLine("Nota de Julia: " + notas["Julia"]);
        }
    }
}
