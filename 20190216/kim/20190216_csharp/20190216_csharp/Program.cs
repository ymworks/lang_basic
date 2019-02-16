using System;

namespace _20190216_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //可変長引数
            //int a = 314, b = 159, c = 123, d = 333, e = 113;

            //int max = Max(a, b, c);
            //Console.WriteLine($"result={max}");

            // : vs =
            int x = 1;
            Console.WriteLine(x);

            Console.WriteLine(Square(2));
            Console.WriteLine(Square(x));
            Console.WriteLine(Square(x = 3)); // xが書き換わってしまう。
            Console.WriteLine(Square(x: 3));
            // Console.WriteLine(Square(y: 3)); 引数の名前も一致させる必要がある。

            Console.WriteLine(x);

        }

        private static int Square(int x)
        {
            return x * x;
        }

        private static int Max(params int[] a)
        {
            int max = a[0];
            for(int i = 1; i < a.Length; ++i)
            {
                if(max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }

        void Sing()
        {

        }

        void Sing(string a, int b)
        {

        }

        void Sing(int c, string d)
        {

        }

    }
}
