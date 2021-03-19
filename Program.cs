using System;

namespace TeoremaDeHeron
{
    class Program
    {
        static void Main(string[] args)
        {
         double lado1 = 3;
         double lado2 = 25;
         double lado3 = 26;

         double sP ;
         double area ;

         sP = Convert.ToDouble(lado1 + lado2 + lado3) / 2;
         area = Math.Sqrt(sP * (sP - lado1) * (sP - lado2) * (sP - lado3));
         Console.WriteLine($"Resultado do Semiperímetro é = {sP}");
         Console.WriteLine($"Àrea é igual = {area}");


                      
        }
    }
}
