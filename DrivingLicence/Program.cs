using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm, arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et taotleda juhiluba.";
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"Oled piisvalt vana, et taotleda juhiluba.";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"palju õnne! Nüüd sa saad taotleda juhiluba."

            //programm küsib kasutaja sünniaastat;
            //programm arvutav kasutaja vanust;

            Console.WriteLine("Palun, sisesta oma sünniaasta");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - YearOfBirth;


            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"Oled piisvalt vana, et taotleda juhiluba.";

            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et taotleda juhiluba.";

            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad taotleda juhiluba."

            if (UserAge > 18)
            {
                Console.WriteLine("Oled piisvalt vana, et taotleda juhiluba.");
            }
            else if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et taotleda juhiluba.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad taotleda juhiluba.");
            }



        }
    }
}