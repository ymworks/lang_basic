using System;

namespace Overall
{
    class UserInfo
    {
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString() => $"({name}, {age})";

        internal void block()
        {
            Console.WriteLine("user is blocked");
        }
    }

    class Program
    {
        // どのアプリケーションであっても、Mainからプログラムが始まる。
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var user = new UserInfo { name = "takeuchi", age = 21 };

            Console.WriteLine(user.name);
            Console.WriteLine(user.age);

            user.block();
        }
    }
}
