using System;

namespace P3_Conversion_Medidas
{
    class Program

        //Angie Yahaira Campos Arias
        // 20222000215
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ** CONVERSIÓN DE MEDIDAS -- EMP.TEXTIL ** ");
            Console.WriteLine(" ");

            double metros;
            Console.Write("Ingrese cantidad de metros: ");
            metros = double.Parse(Console.ReadLine());

            double centimetros = metros * 100.0;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12.0;
            double yardas = pies / 3.0;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("CENTIMETROS: " + centimetros.ToString("0.00"));
            Console.WriteLine("PULGADAS: " + pulgadas.ToString("0.00"));
            Console.WriteLine("PIES: " + pies.ToString("0.00"));
            Console.WriteLine("YARDAS: " + yardas.ToString("0.00"));


            Console.ReadKey();
        }
    }
}
