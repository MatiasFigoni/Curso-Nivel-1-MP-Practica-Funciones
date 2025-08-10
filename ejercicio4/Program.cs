using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero”
            // que reciba un número por valor y una variable por referencia. 
            // Que analice el número y escriba variable recibida por referencia con:
            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.

            int num, result = 2;
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            PositivoNegativoCero(num, ref result);
            Console.WriteLine("El numero es " + result);

        }
        static void PositivoNegativoCero(int n, ref int tipo)
        {
            if (n >= 0)
            {
                if (n != 0)
                {
                    tipo = 1;
                }
                else
                    tipo = 0;
            }
            else
                tipo = -1;
        }
    }
}
