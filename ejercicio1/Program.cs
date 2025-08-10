using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que 
            //devuelva el producto de ambos. Luego hacer un programa que pida el precio 
            //de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. 
            //Usar la función

            int num1, num2, resul;
            Console.WriteLine("Ingrese el precio del producto: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad del producto: ");
            num2 = int.Parse(Console.ReadLine());
            resul = Producto(num1, num2);
            Console.WriteLine("El precio total es: " + resul);
        }
        static int Producto(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
