using System;

namespace MyApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            var p1 = new Person("Peter", "Lhee");

            Console.WriteLine(p1.TellMeAboutYourself());

            Console.ReadKey();
        }
    }

}
