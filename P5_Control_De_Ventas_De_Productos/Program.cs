using System;

namespace P5_Control_De_Ventas_De_Productos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ** CONTRO DE VENTA DE PRODUCTOS ** ");
            Console.WriteLine(" ");

            double precio;
            int cantidad;

            Console.Write("Ingrese precio del producto: HNL. ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad comprada: ");
            cantidad = int.Parse(Console.ReadLine());

            double importe = cantidad * precio;
            double descuento = 11 / 100.0 * importe;
            double total = importe - descuento;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("IMPORTE TOTAL:   HNL. " + importe.ToString("0.00"));
            Console.WriteLine("DESCUENTO :      HNL. " + descuento.ToString("0.00"));
            Console.WriteLine("TOTAL A PAGAR:   HNL. " + total.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
