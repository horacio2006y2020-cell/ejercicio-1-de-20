using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Dictionary<int, string> inventario = new Dictionary<int, string>();
        int opcion;

        do
        {
            Console.WriteLine("\n1 Agregar");
            Console.WriteLine("2 Eliminar");
            Console.WriteLine("3 Mostrar");
            Console.WriteLine("0 Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
                {
                    case 1:
                        Console.Write("Codigo: ");
                        int c = int.Parse(Console.ReadLine());
                        Console.Write("Producto: ");
                        string p = Console.ReadLine();
                        inventario[c] = p;
                        break;

                    case 2:
                        Console.Write("Codigo: ");
                        c = int.Parse(Console.ReadLine());
                        inventario.Remove(c);
                        break;

                    case 3:
                        foreach (var item in inventario)
                            Console.WriteLine(item.Key + " " + item.Value);
                        break;
                }

            } while (opcion != 0);
        }
    }
}
