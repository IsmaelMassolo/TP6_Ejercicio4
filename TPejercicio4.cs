//Solicitar que se ingresen 2 números enteros, realizar la operación de suma y mostrar resultado por pantalla.
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear ();
            string entrada = "", titulo= "S + U + M + A    D + E    N + U + M + E + R + O + S \n";
            int entero1 = 0, entero2 = 0;
            Console.WriteLine (titulo);
            Console.WriteLine ("Ingresar el primer número entero: \n");
            entrada = Console.ReadLine ();
            entero1 = Convert.ToInt32 (entrada);
            Console.WriteLine ("Ingresar el segundo número entero: \n");
            entrada = Console.ReadLine ();
            entero2 = Convert.ToInt32 (entrada);
            int suma = entero1 + entero2;
            Console.Clear();
            Console.WriteLine (titulo);
            Console.WriteLine ("................ \n");
            Console.WriteLine ("  "+ entero1);
            Console.WriteLine ("+");
            Console.WriteLine ("  "+ entero2);
            Console.WriteLine ("------------");
            Console.WriteLine ("  "+ suma +"\n");
            Console.WriteLine ("................ \n");
            Console.WriteLine ("La suma de los números ingresados {0} y {1} es >> {2}", entero1, entero2, suma);
        }
    }
}