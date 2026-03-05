using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Dictionary<string, double> notas = new Dictionary<string, double>();

        notas.Add("Juan", 80);

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        if (notas.ContainsKey(nombre))
        {
            Console.Write("Nueva nota: ");
            double nota = double.Parse(Console.ReadLine());
            notas[nombre] = nota;
        }

        foreach (var item in notas)
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}
