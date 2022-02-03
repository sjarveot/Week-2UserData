using System;

namespace User_age
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm arvutab kasutaja sünniaasta
            //programm kuvab sünniaastat konsoolis
            //"oled sündinud aastal{yearOfBearth}

            Console.WriteLine("Palun sisesta enda vanus?");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            Console.WriteLine("Oled " + userAge + " aastal sündinud.");

        }
    }
}
