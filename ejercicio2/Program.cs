using System;
using System.Net;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y 
            //devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números 
            //y mostrar por pantalla cuántos son pares
            int num, cont = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                if (Par(num))
                {
                    cont += 1;
                }
            }
            Console.WriteLine("De los 20 numeros, " + cont + " son pares");
        }
        static bool Par(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
