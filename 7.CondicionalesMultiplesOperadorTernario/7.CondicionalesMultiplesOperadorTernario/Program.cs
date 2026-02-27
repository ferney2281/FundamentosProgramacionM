using System;
using System.Security.Cryptography;

namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber:
             * 
             Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra. 

            Si el día es martes o jueves, se realizará un descuento del 15 % por la compra.  

            Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra. 

            Si es domingo no se realiza descuento.

            Visualizar el día, el descuento y el total a pagar por la compra. */

            /*char diaSemana = ' ';
            float totalCompra = 0;
            float descuento = 0;
            Console.WriteLine("Ingrese el día de la semana: (l= lunes, m= martes, x=miércoles, j= jueves, v=viernes, s=sábado, d=domingo)");
            diaSemana= Char.Parse( Console.ReadLine() );
            Console.WriteLine("Ingrese el total de la compra:");
            totalCompra=Single.Parse( Console.ReadLine() );

            switch (diaSemana)
            {
                case 'l':
                    descuento = totalCompra * 0.1f;
                    Console.WriteLine($"Hoy es Lunes, el descuento es de {descuento}, el total de la compra es de {totalCompra}");
                    break;
                case 'm':
                    descuento = totalCompra * 0.15f;
                    Console.WriteLine($"Hoy es martes, el descuento es de {descuento}, el valor de la compra es de {totalCompra}");
                    break;
                case 'x':
                    descuento = totalCompra * 0.1f;
                    Console.WriteLine($"Hoy es miércoles, el descuento es de {descuento}, el valor de la compra es de {totalCompra}");
                    break;
                case 'j':
                    descuento = totalCompra * 0.15f;
                    Console.WriteLine($"Hoy es jueves, el descuento es de {descuento}, el valor de la compra es de {totalCompra}");
                    break;
                case 'v':
                    descuento = totalCompra * 0.2f;
                    Console.WriteLine($"Hoy es viernes, el descuento es de {descuento}, el valor de la compra es de {totalCompra}");
                    break;
                case 's':
                    descuento = totalCompra * 0.2f;
                    Console.WriteLine($"Hoy es sábado, el descuento es de {descuento}, el valor de la compra es de {totalCompra}");
                    break;
                case 'd':
                    descuento = 0;
                    Console.WriteLine($"Hoy es domingo, el descuento es de {descuento}, el valor de la compra es de {totalCompra}");
                    break;
                default:
                    Console.WriteLine("Seleccione un día correcto de la semana");
                    break;
            }*/



            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario.Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/

            /*Algoritmo que permita ingresar dos número enteros y decir cual es el número mayor*/
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Ingrese el valor del número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( num1>num2 ? $"El numero mayor es: {num1}" : $"El numero mayor es: {num2}");

            /*if (num1>num2)
            {
                Console.WriteLine($"El numero mayor es: num1");
            }
            else
            {
                Console.WriteLine($"El numero mayor es: num2");
            }*/

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario, mostrar el mensaje “No es apto para el contenido de este sitio web”. */



        }
    }
}
