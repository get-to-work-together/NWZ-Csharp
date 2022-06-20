using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secret = rnd.Next(1, 99);
            int gok = 0;
            int aantalPogingen = 0;

            Console.WriteLine("Raad een getal tussen 1 en 99.");

            do
            {
                Console.Write("Wat denk je dat het getal is? : ");
                string antwoord = Console.ReadLine();

                try
                {
                    gok = int.Parse(antwoord);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Dat is geen getal!!!!");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Er is iets anders mis gegaan!!!!");
                    Console.WriteLine(ex.Message);
                    break;
                }

                aantalPogingen++;

                if (gok > secret)
                {
                    Console.WriteLine("Lager ...");
                }
                else if (gok < secret)
                {
                    Console.WriteLine("Hoger ...");
                }
                else
                {
                    Console.WriteLine("Jaaaa! Goed geraden. Het getal was " + secret);
                    Console.WriteLine("Daar had je {0} pogingen voor nodig", aantalPogingen);
                }

            } while (gok != secret);

            Console.ReadKey();
        }
    }
}