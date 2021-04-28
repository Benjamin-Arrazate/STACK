using System;

namespace STACK
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcion = "";
            while (opcion != "9")
            {

                opcion = "";
                while (opcion != "1" && opcion != "2" && opcion != "9")
                {   
                    Console.WriteLine("1) Decir \"Hola Mundo!\"");
                    Console.WriteLine("2) Decir \"Hola [nombre]!\"");
                    Console.WriteLine("9) Decir Salir");

                    Console.WriteLine("Por favor selecciona una opción:");
                    opcion = Console.ReadLine();

                    if (opcion != "1" && opcion != "2" && opcion != "9")
                    {
                        Console.WriteLine("La opción seleccionada no es correcta");
                    }
                }


                if (opcion == "1")
                {
                    Console.WriteLine("Hola Mundo!");

                }
                else if (opcion == "2")
                {
                    Console.WriteLine("Introduce tu Nombre:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Hola " + nombre + "!");
                }
                else if (opcion == "9")
                {
                    Console.WriteLine("Hasta Luego");
                }

            }
        }

    }

}
