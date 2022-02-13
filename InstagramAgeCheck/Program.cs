using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust.
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana.
            //Kui kasutaja on 13 või vanem, siis võib instagrami kasutada.
            //kui on noorem, siis ei saa instagrami kasutada.

            Console.WriteLine("palun, sisesta oma vanus:");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            if (UserAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et konto luua.");
            }
            else if (UserAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et konto luua.");
            }
            else
            {
                Console.WriteLine("Oled piisavalt vana, et konto luua.");
            }

            Console.WriteLine("kena päeva!");

        }
    }
}
