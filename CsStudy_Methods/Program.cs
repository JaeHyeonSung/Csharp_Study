using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace CsStudy_Methods
{
    internal class Program
    {
        static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }
        static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
        static double Square(double arg)
        {
            
            return arg * arg;
        }

        static void Mean(double a, double b, double c, double d, double e,ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
        static void Main(string[] args)
        {

            // 가변 개수의 인수 params 키워드 사용
            static int Sum(params int[] args)
            {
                int sum = 0;
                for(int i = 0; i < args.Length; i++)
                {
                    sum += args[i];
                }
                return sum;
            }



            var a = Sum([5, 3, 2, 1]);
            Console.WriteLine(a);

            // Prac Test 01

            Console.WriteLine("수를 입력해 주세요. :");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));


            // Prac Test 02

            double mean = 0;
            Mean(1, 2, 3, 4, 5,ref mean);

            Console.WriteLine($"평균 : {mean}");


            // Prac Test 03


            int pt03_a = 3;
            int pt03_b = 4;
            int result_pt03A = 0;

            Plus(pt03_a,pt03_b,out result_pt03A);

            Console.WriteLine($"{pt03_a} + {pt03_b} = {result_pt03A}");

            double pt03_x = 2.4;
            double pt03_y = 3.1;
            double result_pt03B = 0;

            Plus(pt03_x, pt03_y,out result_pt03B);
            Console.WriteLine($"{pt03_x} + {pt03_y} = {result_pt03B}");

            
        }
    }
}
