using System;
using System.Runtime.ConstrainedExecution;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;

            while (contador <=5)
            {
                acumulador += contador;
                contador++;

                Console.WriteLine($"Contador: {contador} - Acumulador: {acumulador}");
            }

            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/

            /*Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1 * 2 * 3 * 4 * 5)*/

            int contador = 1;
            int acumulador = 1;
            int numero = 0;

            Console.WriteLine("Ingrese un número para calcular su factorial");
            numero=Int32.Parse(Console.ReadLine());

            while (contador<=numero)
            {
                acumulador*=contador;
                contador++;
            }
            Console.WriteLine($"La factorial del número {numero} es: {acumulador}");
        }
    }
}
