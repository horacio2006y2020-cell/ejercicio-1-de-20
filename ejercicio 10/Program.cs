using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estudiantes = new Dictionary<int, string>()
        {
            {1,"Juan"},
            {2,"Maria"},
            {3,"Carlos"},
            {4,"Ana"},
            {5,"Luis"}
        };

            foreach (var item in estudiantes)
                Console.WriteLine("Clave: " + item.Key + " Valor: " + item.Value);
        }
    }
}
