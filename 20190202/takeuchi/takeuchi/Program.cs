using System;
using System.Collections.Generic;

namespace takeuchi
{
    class Program
    {
        static void Main(string[] args)
        {

            //リストの宣言
            //配列よりこちらの方がよく使用する。長さが可変で扱いやすい。
            var list = new List<int>
            {
                1,2,3
            };

            list.Add(4);
            list.Remove(1);

            foreach (int i in list)
            {
                Console.WriteLine("List：" + i);
            }

            Console.WriteLine("----------");


            //customized data
            var person = new Person();
            person.name = "Yuna";
            person.age = 21;
            person.address = "Nara";

            person.DeletePerson(person);

            Console.WriteLine("----------");

            //Enum Class
            var years = new JapaneseYear[3]
            {
                JapaneseYear.平成,
                JapaneseYear.昭和,
                JapaneseYear.大正
            };

            for(int i=0; i < 3; i++)
            {
                Console.WriteLine($"JapaneseYear: "+years[i]);
            }

        }
    }

    //model class
    class Person
    {
        public string name;     //名前
        public uint age;        //年齢
        public string address;  //住所

        public void DeletePerson(Person person)
        {
            Console.WriteLine($"{ person.name } is Deleted!");
        }
    }

    enum JapaneseYear
    {
        明治, 大正, 昭和, 平成, 新元号
    }

}
