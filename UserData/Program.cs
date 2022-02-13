using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutav kasutaja vanust;
            //proramm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma sünniaasta");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - YearOfBirth;

            //Console.WriteLine("Oled " + UserAge + " aastat vana.");

            //string interpolation

            Console.WriteLine($"Oled {UserAge} aastat vana.");
            


        }
    }
}
