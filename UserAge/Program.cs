using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"oled sündinud aastal {YearOfBirth};

            Console.WriteLine("Palun, sisesta oma vanus");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - UserAge;

            //string interpolation

            Console.WriteLine($"Oled sündinud aastal {YearOfBirth}.");


        }
    }
}