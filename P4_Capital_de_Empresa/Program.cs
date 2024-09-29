using System;

namespace P4_Capital_de_Empresa
{
    // Angie Yahaira Campos Arias
    // 20222000215
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ** CAPITAL DE LA EMPRESA ** ");
            Console.WriteLine(" ");

            double monto1, monto2, monto3;

            Console.Write("Ingrese monto socio 1: HNL ");
            monto1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese monto socio 2: HNL ");
            monto2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese monto socio 3: HNL ");
            monto3 = double.Parse(Console.ReadLine());

            double capital = monto1 + monto2 + monto3;
            double pSocio1 = (monto1 * 100) / capital;
            double pSocio2 = (monto2 * 100) / capital;
            double pSocio3 = (monto3 * 100) / capital;

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("CAPITAL: HNL. " + capital.ToString("0.00"));
            Console.WriteLine("PORCENTAJE SOCIO 1: HNL " + pSocio1.ToString("0.00") + "%");
            Console.WriteLine("PORCENTAJE SOCIO 2: HNL " + pSocio2.ToString("0.00") + "%");
            Console.WriteLine("PORCENTAJE SOCIO 3: HNL " + pSocio3.ToString("0.00") + "%");

            Console.ReadKey();

        }
    }
}
