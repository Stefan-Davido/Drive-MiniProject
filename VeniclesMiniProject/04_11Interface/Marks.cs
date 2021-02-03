using System;
using System.Collections.Generic;
using System.Text;

namespace _04_11Interface
{
    class Marks:IMarks
    {
        public void CarMarks()
        {
            Console.WriteLine("Chose car mark:");
            Console.WriteLine(" 1) Audi");
            Console.WriteLine(" 2) BMW");
            Console.WriteLine(" 3) Mercedes");
            Console.WriteLine(" 4) Seat");
            Console.WriteLine(" 5) Volvo");
            Console.WriteLine(" 6) Honda");
            Console.WriteLine(" 7) Toyota");
            Console.WriteLine(" 8) Ferrari");
            Console.WriteLine(" 9) Bugatti");

            int CarMark = int.Parse(Console.ReadLine());
            switch(CarMark)
            {
                case 1:
                    Console.WriteLine("You chose Audi");
                    break;
                case 2:
                    Console.WriteLine("You chose BMW");
                    break;
                case 3:
                    Console.WriteLine("You chose Mercedes");
                    break;
                case 4:
                    Console.WriteLine("You chose Seat");
                    break;
                case 5:
                    Console.WriteLine("You chose Volvo");
                    break;
                case 6:
                    Console.WriteLine("You chose Honda");
                    break;
                case 7:
                    Console.WriteLine("You chose Toyota");
                    break;
                case 8:
                    Console.WriteLine("You chose Ferrari");
                    break;
                case 9:
                    Console.WriteLine("You chose Bugatti");
                    break;
            }
        }
        public void BikeMarks()
        {
            Console.WriteLine("Chose your bike mark");
            Console.WriteLine(" 1) Scott");
            Console.WriteLine(" 2) Ghost");
            Console.WriteLine(" 3) Max");
            Console.WriteLine(" 4) Viper");
            Console.WriteLine(" 5) Merida");

            int BikeMark = int.Parse(Console.ReadLine());
            switch(BikeMark)
            {
                case 1:
                    Console.WriteLine("You chose Scott");
                    break;
                case 2:
                    Console.WriteLine("You chose Ghost");
                    break;
                case 3:
                    Console.WriteLine("You chose Max");
                    break;
                case 4:
                    Console.WriteLine("You chose Viper");
                    break;
                case 5:
                    Console.WriteLine("You chose Merida");
                    break;
            }
        }
    }
}
