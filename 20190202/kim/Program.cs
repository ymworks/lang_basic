using System;
using System.Collections.Generic;

namespace _20190202_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[]
            {
                1, 2, 3
            };

            foreach (int i in array)
            {
                Console.WriteLine("array value=" + i);
            }


            //            var array2 = { 1, 2, 3};

            // 配列ではなく、リストを利用すること。
            var list = new List<int>()
            {
                1, 2, 3
            };

            foreach(int i in list)
            {
                Console.WriteLine("list value=" + i);
            }

            list.Add(4);

            foreach (int i in list)
            {
                Console.WriteLine("list value=" + i);
            }
            // /array and list

            // Customized data
            var person = new Person();
            person.name = "Yuna";
            person.age = 21;
            person.address = "Nara";

            person.DeletePerson(person);
            // /Customized data

            // Enum class
            Console.WriteLine($"{JapaneseYear.明治}");

            var years = new JapaneseYear[3]
            {
                JapaneseYear.平成,
                JapaneseYear.明治,
                JapaneseYear.昭和

            };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"JapaneseYear=" + years[i]);
            }
        }
    }
    // model class
    class Person
    {
        public string name;
        public uint age;
        public string address;

        public void DeletePerson(Person person)
        {
            Console.WriteLine($"{person.name} is deleted.");
        }
    }

    enum JapaneseYear
    {
        明治, 昭和, 平成
    }
}

