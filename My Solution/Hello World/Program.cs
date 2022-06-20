using System;

namespace Hello_World
{
    public class HelloWorld
    {
        static void Main(string[] args)
        {
            var gender = "M";

            if (gender == "m")
            {
                Console.WriteLine("Male");
            }
            else if (gender == "f" || gender == "v")
            {
                Console.WriteLine("Female");
            }
            else
            {
                Console.WriteLine("Other");
            }


            switch (gender.ToLower())
            {
                case "m":
                    Console.WriteLine("Male");
                    break;

                case "v":
                case "f":
                    Console.WriteLine("Female");
                    break;

                default:
                    Console.WriteLine("Other");
                    break;

            }


            var n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }


            n = 1;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n <= 10);


            for (n = 1; n <= 10; n++)
            {
                Console.WriteLine(n);
            }

            int cijfer = EnterNumberBetween(1, 10, "Welke cijfer heb je gehaald? : ");
            Console.WriteLine("Je hebt een " + cijfer + " gehaald.");

            List<int> numbers = new List<int>(new int[]{ 1, 5, 2, 3, 4 });
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            int magic_number = 11;
            for (int i = 1; i <= 20; i++)
            {
                if (i == magic_number) break;
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 20; i++)
            {
                if (i == magic_number) continue;
                Console.WriteLine(i);
            }

            string sentence = "it is a beautiful day today";
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();

        }

        static int EnterNumberBetween(int lower, int upper, string message)
        {
            int number;

            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                number = int.Parse(input);
            } while (!(number >= lower && number <= upper));

            return number;
        }


    }

}
