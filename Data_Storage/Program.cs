using System;
using System.Runtime.Intrinsics.Arm;
using static System.Console;

namespace Data_Storage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 255;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000;
            uint f = 3_0000_0000;

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;
            Console.WriteLine($"g={g}, h={h}");

            // signed, unsigned

            byte by1 = 255;
            sbyte sby1 = (sbyte)by1;
            Console.WriteLine(by1);                     // 255
            Console.WriteLine(sby1);                    // -1



            //Over, Underflow

            int num1 = int.MaxValue;

            Console.WriteLine($"num1 = {num1}");

            num1++;

            Console.WriteLine($"num1 = {num1}");

            // float , double, decimal


            float f1 = 3.1415_9265_3589_7932_3846f;
            Console.WriteLine(f1);                      // 3.1415927

            double b1 = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b1);                      // 3.141592653589793

            decimal dcm1 = 3.1415_9265_3589_7932_3846m;
            Console.WriteLine(dcm1);                    // 3.14159265358979323846
        }
    }
}
