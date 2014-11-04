using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appsumapromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4, suma, promedio;
            Console.WriteLine(" programa y promedio de 4 numeros");
            Console.WriteLine("digite numero1:");
            num1=float.Parse(Console.ReadLine());
            Console.WriteLine("digite numero2:");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite numero3:");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite numero4:");
            num4 = float.Parse(Console.ReadLine());
  
            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;
            Console.WriteLine("la suma es:" + suma);
            Console.WriteLine("el promedio es:" + promedio);
            Console.ReadKey();





        }
    }
}
