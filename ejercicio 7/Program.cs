using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> productos = new Dictionary<int, string>();

            int codigo = 101;

            if (!productos.ContainsKey(codigo))
                productos.Add(codigo, "Laptop");
        }
    }
}
