using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            const string miNombre = "juan"; //cadena constante
            const string buenNombre = "ana";
            const string graciosoNombre = "pepín";
            string nombre;
            WriteLine("¿Cuál es tu nombre?:");
            nombre = ReadLine();
            switch (nombre.ToLower())//toda la cadena nombre se convierte a minúsculas.
            {
                case miNombre://comapración de la cadena
                    WriteLine("Te llamas como yo.");
                    break;
                case buenNombre:
                    WriteLine("Bonito nombre.");
                    break;
                case graciosoNombre:
                    WriteLine("¡Qué nombre más gracioso!");
                    break;
            }
            WriteLine($"Hola {nombre}");
            ReadKey();     
        }
    }
}
