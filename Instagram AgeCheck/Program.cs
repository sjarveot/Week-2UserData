﻿using System;

namespace Instagram_AgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm kontrollib kas kasutaja on vanem või 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vanem või vanem, siis ta võib instagrammi kasutada
            //kui kasutaja on noorem, kui 13 , siis ta on liiga noor

            Console.WriteLine("Palun, sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            
            if(userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua");

            }
            else
            {
                Console.WriteLine("Oledki 13, nüüd saad endale Instagrami konto luua");

            }
            Console.WriteLine("Kena päeva");

        }
    }
}
