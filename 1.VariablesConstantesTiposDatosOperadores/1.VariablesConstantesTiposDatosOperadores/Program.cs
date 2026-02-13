using System;

namespace _1.VariablesConstantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES NUMÉRICOS
            //Cambio de signo
            int dato1 = 5;
            int dato2 = -dato1;
            Console.Write(dato1 + " // " + dato2);
            //Aritméticos
            int dato3 = 5 + 6;
            int dato4 = 120 - 231;
            int dato5= 12 * 56;
            float dato6 = 5f / 3f; //(5 / 3f); (5f / 3);(float) 5 / 3;
            Console.Write("\nSuma: {0}, Resta: {1}, Multiplicación: {2}, División: {3}", dato3, dato4, dato5, dato6);
            //Incremento - Decremento
            dato3++; //dato3=dato3+1;
            Console.WriteLine("\nincremento :{0}", dato3);
            dato4--;// dato4=dato4-1;
            Console.WriteLine("decremento :{0}", dato4);
            dato5 += 4;//dato5=dato5+4;
            dato3 -= 5;//dato3=dato3-5;
            dato5 *= dato3;//dato5=dato5*dato3;
            dato6/= dato3;//dato6=dato6/dato3;
            //Orden de evaluación Oper5adores numéricos
            float dato7 = 4 * 3 / 2;
            Console.WriteLine(dato7);
            float dato8 = 4.0f * (3.0f / 5.0f);
            Console.WriteLine(dato8);
            float dato9 = 4 + 6 * (2 - 1);
            Console.WriteLine(dato9);
            //Operadores Lógicos - Conjunción (Y) . Disyunción (O)
            Console.WriteLine("TABLA DE VERDAD DE LA CONJUNCIÓN");
            Console.WriteLine("V Y V = " + (true && true));
            Console.WriteLine("V Y f = " + (true && false));
            Console.WriteLine("F Y V = " + (false && true));
            Console.WriteLine("F Y F = " + (false && false));
            Console.WriteLine("------------------------------");
            
            Console.WriteLine("TABLA DE VERDAD DE LA DISYUNCIÓN");
            Console.WriteLine("V O V = " + (true || true));
            Console.WriteLine("V O f = " + (true || false));
            Console.WriteLine("F O V = " + (false|| true));
            Console.WriteLine("F O F = " + (false|| false));
            Console.WriteLine("------------------------------");

            //Operadores de comparación

            bool dato10 = 5 > 3;
            Console.WriteLine(dato10);
            bool dato11 = 4 <-32;
            Console.WriteLine(dato11);
            bool dato12 = 5 <= 5;
            Console.WriteLine(dato12);
            bool dato13 = 4 != 4;
            Console.WriteLine(dato13);
            bool dato14 = dato10 && dato11 || dato12;
            Console.WriteLine(dato14);
        }
    }
}
