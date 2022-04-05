using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1guiaCAI
{
    //6. Lea las teclas presionadas y finalice al presionar Shift+Ctrl+F.
    internal class Ejercicio1
    {
        public void Ej1()
        {
            //1. Presente el mensaje “Hola mundo” al usuario, espere la presión de una tecla y finalice.
            Console.WriteLine("Hola Mundo!");
        }

        public void Ej2()
        {
            //2. Solicite el ingreso de un texto cualquiera y lo presente nuevamente al usuario.
            string Nombre;
            Console.WriteLine("Ingrese texto por favor:");
            Nombre = Console.ReadLine();
            Console.WriteLine(Nombre);
        }

        public void Ej3()
        {
            //3. Lea las teclas presionadas y finalice al presionar la tecla “X”.
            do
            {
            } while (Console.ReadKey().Key != ConsoleKey.X);

        }
        public void Ej4()
        {
            //4. Permita el ingreso de frases, finalizando cuando el usuario ingresa “fin”.
            do
            {
            } while (Console.ReadLine() != "fin");
        }

        public void Ej5()
        {
            //5. Lea las teclas presionadas y finalice al presionar Ctrl+F(Ctrl y F al mismo tiempo).
            do
            {
            } while (Console.ReadKey().Modifiers != ConsoleModifiers.Control & Console.ReadKey().Key != ConsoleKey.F);
        }

    }
}
