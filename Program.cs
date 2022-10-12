/*Crear un programa donde se definan variables de tipo lógico, entero, cadena texto y
decimal. Almacene un dato correspondiente para cada tipo y muestre el contenido de cada
variable por pantalla.*/


using System;

namespace EJ3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Bienbennido a definiendo variables");

            bool variableLogica;
            variableLogica = true;

            int variableEntera;
            variableEntera = 55;

            string variableTexto;
            variableTexto = "Hola";

            float variableDecimal;
            variableDecimal = 22.65F;

            Console.WriteLine("La variable Logica es: " + variableLogica);
            Console.ReadKey();
            Console.WriteLine("La variable Entera es: " + variableEntera);
            Console.ReadKey();
            Console.WriteLine("La variable Decimal es: " + variableDecimal);
            Console.ReadKey();
            Console.WriteLine("La variable Texto es:  " + variableTexto);
            Console.ReadKey();




        }
    }
}
