using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> inventario = new Dictionary<int, string>();

            inventario.Add(1, "Laptop");
            inventario.Add(2, "Mouse");

            Console.Write("Codigo a eliminar: ");
            int codigo = int.Parse(Console.ReadLine());

            if (inventario.ContainsKey(codigo))
                inventario.Remove(codigo);
        }
    }
}
