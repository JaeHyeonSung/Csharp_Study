using System;
using System.Runtime.Intrinsics.Arm;
using static System.Console;

namespace Data_Storage
{
    internal class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
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



            // data format converting

            int dfc_a = 123;
            string dfc_s = dfc_a.ToString();
            Console.WriteLine(dfc_s);                   // "123"  

            float dfc_f = 3.14f;
            string dfc_s1= dfc_f.ToString();            
            Console.WriteLine(dfc_s1);                  // "3.14"

            string dfc_s2 = "123456";
            int dfc_a1=Convert.ToInt32(dfc_s2);         
            Console.WriteLine(dfc_a1);                  // 123456

            string dfc_s3 = "1.234";
            float dfc_f1=float.Parse(dfc_s3);
            Console.WriteLine(dfc_f1);                  // 1.2345

            // Enum formatting
            // enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

            DialogResult result = DialogResult.OK;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.OK);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);

            string teststring = "       Have  a  good     night";

            string[] testresult = teststring.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            foreach(var item in testresult)
            {
                Console.WriteLine(item);
            }


            // String Format

            // 1
            Console.WriteLine("{0}, {1}", "12", "444");

            //2
            Console.WriteLine($"test : {"test"}");




            // 
            Console.WriteLine("너비 입력 :");
            string width_input = Console.ReadLine();

            Console.WriteLine("높이 입력 :");
            string height_input = Console.ReadLine();

            var AreaResult=RectArea.GetRectArea(Int32.Parse(width_input), Int32.Parse(height_input));

            Console.WriteLine($"사각형 넓이 : {AreaResult}");
        }
    }
}
