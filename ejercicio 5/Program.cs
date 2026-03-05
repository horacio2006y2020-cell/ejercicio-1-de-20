using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usuarios = new Dictionary<string, string>();

            usuarios.Add("admin", "1234");
            usuarios.Add("jose", "abcd");

            Console.WriteLine("Contraseña de jose: " + usuarios["jose"]);
        }
    }
}
