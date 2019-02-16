using System;

namespace takeuchi
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** P.181 ***
            //int a = 314, b = 159, c = 265, d = 358, e = 979;

            ////自動的に配列を作って値を格納してくれる。

            ////可変長なので、引数の数を変えても影響はないルことができる
            ////int max = Max(a);
            //int max = Max(a, b, c, d, e);
            //Console.WriteLine($"{max}");



            // *** P.184 ***
            int x = 1;
            Console.WriteLine(x);

            Console.WriteLine(Square(2));
            Console.WriteLine(Square(x = 2));
            Console.WriteLine(Square(x: 2));
            Console.WriteLine(x);  //出力は2になるので注意

        }

        static int Max(params int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; ++i)
            {
                if (max < a[i]) max = a[i];
            }

            return max;

        }

        static int Square(int x)
        {
            return x * x;
        }

    }
}
