using System;

namespace Exame_Kondrashin
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
          
            Console.WriteLine("Введите количество углов: ");   
            int n = Int32.Parse(Console.ReadLine());            

            Console.WriteLine("Введите радиус окружности: ");
            for (i = 0; i < n; i++) ;
            int r = Int32.Parse(Console.ReadLine());

            double tg = 3.14 * n;                 //нахождение тангенса
            Console.WriteLine("Taнгенс");
            Console.WriteLine(tg);

            object P = 2 * r * tg;                //нахождение периметра
            Console.WriteLine("Периметр");
            Console.WriteLine(P);

            double S = n * r * r * tg;             //нахождение площади
            Console.WriteLine("Площадь");
            Console.WriteLine(S);







        }
    }
}
