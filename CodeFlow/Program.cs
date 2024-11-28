using System.Security.Cryptography.X509Certificates;

namespace CodeFlow
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            // Prac Test 01
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Prac Test 02
            for (int i =5; i>0; i--)
            {
                for (int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // Prac Test 03
            int a = 1;
            do
            {
                for( int i=0; i<a; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            while (a++ < 5);

            a = 5;
            do
            {
                for (int i = 0; i < a; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            while (a-- > 1);


            // Prac Test 04

            Console.WriteLine("반복 횟수를 입력하세요.");
            string input_num=Console.ReadLine();
            int target_num = int.Parse(input_num);

            if (target_num > 0) 
            {
                for(int i=0; i<target_num+1; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("0이하의 수는 사용할 수 없습니다.");
            }





            // Prac Test 05

            string input_index = Console.ReadLine();
            long index_test = long.Parse(input_index);
            Console.WriteLine(Fibonacci.GetNumber(index_test)); 
            
           

            


        }
    }
}
