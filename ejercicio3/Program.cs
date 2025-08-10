using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “primo” que reciba un número entero y 
            //devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. 
            //El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos

            int num, contPrimos = 0,acuPrimos=0;
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                if (Primo(num))
                {
                    contPrimos++;
                    acuPrimos += num;
                }
                
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                
            }
            float promedio;
            promedio =acuPrimos / contPrimos;
            Console.WriteLine("El promedio de numeros primos de la lista es: " + promedio);
        }
        static bool Primo(int n)
        {
            int cont = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 1)
            {
                return true;
            }
            else
                return false;
        }
    }
}
