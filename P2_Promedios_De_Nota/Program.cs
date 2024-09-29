using System;

//Angie Yahaira Campos Arias
//20222000215

namespace P2_Promedios_De_Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ** PROMEDIO DE NOTAS ** ");
            Console.WriteLine(" ");

            string alumno;
            int nota1, nota2, nota3;

            Console.Write("Ingrese nombre del alumno: ");
            alumno = Console.ReadLine();
            Console.Write("Ingrese la nota 1: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 2: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 3: ");
            nota3 = int.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("EL PROMEDIO: " + promedio.ToString("0.00") + "%");

            Console.ReadKey();


        }
    }
}
