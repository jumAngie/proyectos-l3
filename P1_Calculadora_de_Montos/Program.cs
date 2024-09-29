using System;

// Angie Yahaira Campos
// 20222000215

namespace P1_Calculadora_de_Montos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ** CALCULADORA DE MONTOS ** ");
            Console.WriteLine(" ");

            double precio = 0;
            int cantidad = 0;

            Console.Write("Ingrese el precio del producto  L. ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad seleccionada: ");
            cantidad = int.Parse(Console.ReadLine());


            double monto = precio * cantidad;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("MONTO A CANCELAR: L. " + monto.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
