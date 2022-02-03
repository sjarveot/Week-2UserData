using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis 
            //"oled liiga noor, et juhilube saada"
            //kui kasutaja on vanem, kui siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhilube saada"
            //kui kasutaja on 18 siis programm kuvab konsoolis
            //"Palju õnne, nüüd saad sa ka juhilube taotleda" 

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOFBirth = Convert.ToInt32(Console.ReadLine());

            if (yearOFBirth < 2004)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada");
            }
            else if (yearOFBirth > 2004)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada");

            }
            else
            {
                Console.WriteLine("Oledki 18, Palju õne, nüüd saad sa juhilube taotelda");

            }
            Console.WriteLine("Kena päeva");

        }
    }
}
