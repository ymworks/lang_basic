using System;

namespace takeuchi
{

    class Program
    {

        static void Main(string[] args)
        {
            /* P.54
            キーワード（予約語）は変数名に使用できない
            前に@をつけることでエスケープできるが
            ややこしいのであまり推奨されない
            */
            //int @out = 1;

            //int @if = 1;
            //int @for = 1;



            //parsing
            int xx = int.Parse("12345");
            //int x = int.Parse("文字列");   これはエラーになる。
            //Console.WriteLine("Parsing Result = " +xx);


            dynamic x2 = 1;
            x2 = "文字列";    //dynamic型の場合、違う型でもOK



            // P.60  C#では同じ名前を2度使用できない
            // （Javaでは、異なるスコープ内であれば使用可能）
            //{
            //    int same = 1;
            //}
            //string same = "sameName";



            // P.78  文字列置換
            //int x = 1;
            //int y = 2;
            //Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            //Console.WriteLine($"{x} + {y} = {x + y}");


            // P.88  演算子の例（インクリメント）
            //int num1 = 1;
            //int num2 = 1;
            //Console.WriteLine(num1++);   //出力は1
            //Console.WriteLine(++num2);   //出力は2


            // P.95 null合体演算
            //ある値がnullかどうかを判定
            //string str1 = "aaa";
            //string str2 = null;  //C#は宣言時にnullと明記しないとダメ。

            // 以下の2行は、内容的には同じ
            //string nonNUllStr1 = str1 != null ? str : "default string";
            //string nonNUllStr2 = str2 ?? "default string";

            //Console.WriteLine(nonNUllStr1);
            //Console.WriteLine(nonNUllStr2);


            // P.99  namerOf演算子
            Calculate();


        }

        public static void Calculate()
        {
            var x = 10;
            var y = 20;
            Console.WriteLine($"In {nameof(Calculate)} method:");
            Console.WriteLine($"{nameof(x)} = {x}");
            Console.WriteLine($"{nameof(y)} = {y}");
            Console.WriteLine($"{nameof(x)} + {nameof(y)} = {x + y}");
        }
    }
}
