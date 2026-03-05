using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> empleados = new Dictionary<int, string>()
        {
            {1,"Luis"},
            {2,"Pedro"}
        };

            foreach (var item in empleados)
                Console.WriteLine("ID: " + item.Key + " Nombre: " + item.Value);
        }
    }
}
