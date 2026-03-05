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
        }
    }
}
