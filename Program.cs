using System;

namespace STACK
{
    class Program
    {
        static void Main(string[] args)
        {
            
            STACKNOTAS stackNotas = new STACKNOTAS(); 
            stackNotas.Push("Primer Nota"); 
            stackNotas.Push("Segunda Nota"); 
            stackNotas.Push("Tercer Nota"); 


            string opcion = "";
            while (opcion != "9")
            {

                opcion = "";
                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "9")
                {   
                    Console.WriteLine("1) Imprimir notas (PrintStack)");
                    Console.WriteLine("2) Agregar nota (Push)");
                    Console.WriteLine("3) Quitar nota (Pop)");
                    Console.WriteLine("4) Consutar un elemento (Peak)");
                    Console.WriteLine("9) Salir");

                    Console.WriteLine("Por favor selecciona una opción:");
                    opcion = Console.ReadLine();

                    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "9")
                    {
                        Console.WriteLine("La opción seleccionada no es correcta");
                    }
                }


                if (opcion == "1")
                {
                    stackNotas.PrintStack();

                }
                else if (opcion == "2")
                {
                    Console.WriteLine("Agregar Nota:");
                    string nota = Console.ReadLine();
                    stackNotas.Push(nota); 
                }
                else if (opcion == "3")
                {
                    string nota = stackNotas.Pop();
                    Console.WriteLine("Nota Removida:");
                    Console.WriteLine(nota);
                }
                else if (opcion == "4")
                {
                    string nota = stackNotas.Peak();
                    Console.WriteLine("Nota Consultada:");
                    Console.WriteLine(nota);
                }
                else if (opcion == "9")
                {
                    Console.WriteLine("Hasta Luego");
                }

            }
        }

    }

}
