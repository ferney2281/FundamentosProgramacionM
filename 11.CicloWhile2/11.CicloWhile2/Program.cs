using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _11.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99.*/

            /*int contador = 1;
            int acumulador = 0;

            while (contador<=99)
            {
                acumulador += contador;
                contador += 2;
            }

            Console.WriteLine($"Suma de números Impares hasta el 99:{acumulador}");*/

            /*Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar.Al usuario le corresponde ingresar la cantidad de números que va a introducir.  

                El algoritmo debe escribir en pantalla: 

                La cantidad de números introducidos que son mayores que 0

                La cantidad de números introducidos menores que 0

                La cantidad de números iguales a 0.*/

            /* int cantidadNumeros = 0;
             int contador = 1;
             int numero = 0;
             int ceros = 0;
             int mayorCero = 0;
             int menorCero = 0;

             Console.WriteLine("Ingrese la cantidad de números a ingresar");
             cantidadNumeros=int.Parse(Console.ReadLine());

             while (contador<=cantidadNumeros)
             {
                 Console.WriteLine($"Ingrese el valor del número {contador}");
                 numero=int.Parse(Console.ReadLine());

                 if (numero == 0)
                 {
                     ceros++;
                 }
                 else
                 {
                     if (numero>0)
                     {
                         mayorCero++;
                     }
                     else
                     {
                         menorCero++;
                     }
                 }
                 contador++;
             }

             Console.WriteLine($"Ceros: {ceros}, Mayores a cero: {mayorCero}, Menores a cero: {menorCero}");*/

            /*Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes. */

            int contadorMeses = 1;
            float acumuladorAhorro = 0;
            float ahorro = 0;

            while (contadorMeses<=12)
            {
                Console.WriteLine($"En el mes {contadorMeses}, cuánto desea ahorrar:");
                ahorro=Single.Parse( Console.ReadLine() );

                acumuladorAhorro+=ahorro;

                Console.WriteLine($"Este mes usted ahorró ${ahorro}, para el mes {contadorMeses} usted tiene ahorrado $ {acumuladorAhorro}");

                contadorMeses++;

            }

        }
    }
}
