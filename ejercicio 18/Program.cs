using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usuarios = new Dictionary<string, string>();

            Console.Write("Usuario: ");
            string user = Console.ReadLine();

            if (usuarios.ContainsKey(user))
                Console.WriteLine("Ya existe.");
            else
            {
                Console.Write("Contraseña: ");
                string pass = Console.ReadLine();
                usuarios.Add(user, pass);
            }
    }
}
