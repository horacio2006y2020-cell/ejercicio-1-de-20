using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> productos = new Dictionary<int, string>();

            productos.Add(101, "Laptop");
            productos.Add(102, "Mouse");
            productos.Add(103, "Teclado");

            foreach (var item in productos)
                Console.WriteLine("Codigo: " + item.Key + " Producto: " + item.Value);
        }
    }
}
