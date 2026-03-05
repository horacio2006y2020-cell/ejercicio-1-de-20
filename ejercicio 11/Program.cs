using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> productos = new Dictionary<int, string>()
        {
            {101,"Laptop"},
            {102,"Mouse"},
            {103,"Teclado"}
        };

            foreach (var item in productos)
                Console.WriteLine(item.Key + " - " + item.Value);
        }
    }
}
