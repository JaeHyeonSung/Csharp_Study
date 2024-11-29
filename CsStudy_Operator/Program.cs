using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace CsStudy_Operator
{
    internal class Program
    {
        class Foo
        {
            public int member;
        }

        static void Main(string[] args)
        {
            // 산술 연산자 - + , - , * , / , %

            int a = 111 + 222;
            Console.WriteLine($"a = {a}");

            int b = a - 100;
            Console.WriteLine($"b = {b}");

            int c = b * 10;
            Console.WriteLine($"c = {c}");

            double d = c / 6.3;
            Console.WriteLine($"d = {d}");

            Console.WriteLine($"22/7 = {22 / 7}({22 % 7})");

            // 증가, 감소 연산자

            int a0 = 10;
            a0++;           // 11
            a0--;           // 10

            // 문자열 결합 연산자

            string addstr = "123" + "456";
            Console.WriteLine(addstr);              // 123456

            // 관계 연산자  <, >, <=, >=, ==, !=

            Console.WriteLine($"3<4 : {3 < 4}");
            Console.WriteLine($"3>4 : {3 > 4}");
            Console.WriteLine($"3<=4 : {3 <= 4}");
            Console.WriteLine($"3>=4 : {3 >= 4}");

            Console.WriteLine($"3==4 : {3 == 4}");
            Console.WriteLine($"3!=4 : {3 != 4}");


            // 논리 연산자 - 논리곱 && (AND), 논리합 || (OR), 부정 ! (NOT)

            bool b0 = true;
            bool b1 = false;
            bool result0 = b0 && b1;            // false
            bool result1 = b0 || b1;            // true
            bool result2 = !b0;                 // false

            // 조건 연산자 - 조건식 ? 참일때 값 : 거짓일때 값

            int if_a = 30;
            string result_if = if_a == 30 ? "삼십" : "삼십아님";
            Console.WriteLine( result_if);

            // Nullable 연산자

            // 1. ==연산자 사용

            Foo foo = null;

            int? bar;

            if( foo==null ){ bar = null; }
            else{ bar = foo.member; }

            // 2. ?. 연산자 사용

            bar = foo?.member;  // foo 객체가 null이 아니면 member 필드에 접근하게 해줌



            // Nullable 연산자 사용예시

            ArrayList arrayList = null;
            arrayList?.Add("야구");               // arrayList? 가 null 이므로 Add 메소드 호출 x
            arrayList?.Add("축구");
            Console.WriteLine($" Count : {arrayList?.Count}");
            Console.WriteLine($"{arrayList?[0]}");
            Console.WriteLine($"{arrayList?[1]}");

            arrayList= new ArrayList();           // arrayList가 null이 아니기 때문에 메소드 호출 o
            arrayList?.Add("야구");
            arrayList?.Add("축구");
            Console.WriteLine($"Count : {arrayList?.Count}");
            Console.WriteLine($"{arrayList?[0]}");
            Console.WriteLine($"{arrayList?[1]}");

            // 비트 연산자 - << , >>

            int shift_a = 1;
            Console.WriteLine($"shift_a : {shift_a:D5} (0x{shift_a:X8})");
            Console.WriteLine($"shift_a << 1 : {shift_a << 1:D5} (0x{shift_a<<1:X8})");
            Console.WriteLine($"shift_a << 2 : {shift_a << 2:D5} (0x{shift_a << 2 :X8})");
            Console.WriteLine($"shift_a << 5 : {shift_a << 5:D5} (0x{shift_a << 5:X8})");

            int shift_b = 255;
            Console.WriteLine("shift_b : {0:D5} (0x{0:X8})", shift_b);
            Console.WriteLine("shift_b >> 1 : {0:D5} (0x{0:X8})", shift_b >> 1);
            Console.WriteLine("shift_b >> 2 : {0:D5} (0x{0:X8})", shift_b >> 2);
            Console.WriteLine("shift_b >> 5 : {0:D5} (0x{0:X8})", shift_b >> 5 );

            int shift_c = -255;
            Console.WriteLine("shift_c : {0:D5} (0x{0:X8})", shift_c);
            Console.WriteLine("shift_c >> 1 : {0:D5} (0x{0:X8})", shift_c >> 1);
            Console.WriteLine("shift_c >> 2 : {0:D5} (0x{0:X8})", shift_c >> 2);
            Console.WriteLine("shift_c >> 5 : {0:D5} (0x{0:X8})", shift_c >> 5);

            // 비트 논리 연산자  & , | , ^ , ~




            // null 병합 연산자

            int? nullOP_num = null;
            Console.WriteLine($"{nullOP_num ?? 0}");

            nullOP_num = 99;
            Console.WriteLine($"{nullOP_num ?? 0}");

            string? nullOP_str = null;
            Console.WriteLine($"{nullOP_str ?? "Default"}");

            nullOP_str = "Test";
            Console.WriteLine($"{nullOP_str ?? "Default"}");


            // Practice Problem

            int test00_a = 8 >> 1;        // 4
            int test00_b = test00_a >> 2;        // 1
            Console.WriteLine($"{test00_a}, {test00_b}");

            int test01_a = 0xF0 | 0x0F;       // 0xFFFFFFFF
            Console.WriteLine($"(0x{test01_a:X2})");

            int test03_a = 10;
            string test03_b = a == 0 ? "가나다" : "ABC";
            Console.WriteLine(test03_b);                    // ABC
        }
    }
}
