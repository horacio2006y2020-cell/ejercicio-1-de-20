using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ciudades = new Dictionary<int, string>()
        {
            {1,"Retalhuleu"},
            {2,"Quetzaltenango"},
            {3,"Belice"}
        };

            foreach (var item in ciudades)
                Console.Write(item.Key + " ");

            Console.WriteLine();

            foreach (var item in ciudades)
                Console.Write(item.Value + " ");
        }
    }
}
