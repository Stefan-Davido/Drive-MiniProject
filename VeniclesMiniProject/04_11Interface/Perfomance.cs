using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _04_11Interface
{
    public class Perfomance:IPerfomance
    {

        ConsoleKeyInfo cki;
        public int Speed;
        public int Gear=1;
        public string Colour;

        public void Colour_()
        {
            Console.WriteLine("Chose your venicle's colour:");
            Console.WriteLine(" 1) Red");
            Console.WriteLine(" 2) Black");
            Console.WriteLine(" 3) Blue");
            Console.WriteLine(" 4) Yellow");
            Console.WriteLine(" 5) Green");

            int colour = int.Parse(Console.ReadLine());
            switch (colour)
            {
                case 1:
                    Console.WriteLine("Your venicle's is Red");
                    break;
                case 2:
                    Console.WriteLine("Your venicle's is Black");
                    break;
                case 3:
                    Console.WriteLine("Your venicle's is Blue");
                    break;
                case 4:
                    Console.WriteLine("Your venicle's is Yellow");
                    break;
                case 5:
                    Console.WriteLine("Your venicle's is Green");
                    break;
            }
        }
        public void CarSpeedGear()
        {                   
                do
                {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.UpArrow)
                {                  
                    Speed = Speed + 10;
                    Console.WriteLine(Speed);
                }
                else if(cki.Key == ConsoleKey.Spacebar)
                {                 
                    Speed = Speed - 10;
                    if (Speed == -10)
                    {
                        Console.WriteLine("0");
                    }
                    else
                   Console.WriteLine(Speed);
                }
                if (Speed == 0 && cki.Key == ConsoleKey.UpArrow)
                {
                    Gear++;
                    Console.WriteLine($"Your gear is {Gear}");
                }
                else if (Speed == 0 && cki.Key == ConsoleKey.Spacebar)
                {
                    Gear--;
                    Console.WriteLine($"Your gear is {Gear}");
                }
                else if (Speed == 20 && cki.Key == ConsoleKey.UpArrow)
                {
                    Gear++;
                    Console.WriteLine($"Your gear is {Gear}");
                }
                else if (Speed == 20 && cki.Key == ConsoleKey.Spacebar)
                {
                    Gear--;
                    Console.WriteLine($"Your gear is {Gear}");
                }
                else if (Speed == 50 && cki.Key == ConsoleKey.UpArrow)
                {
                    Gear++;
                    Console.WriteLine($"Your gear is {Gear}");
                }
                else if (Speed == 50 && cki.Key == ConsoleKey.Spacebar)
                {
                    Gear--;
                    Console.WriteLine($"Your gear is {Gear}");
                }
                else if (Speed == 70 && cki.Key == ConsoleKey.UpArrow)
                {
                    Gear++;
                    Console.WriteLine($"Your gear is {Gear}");
                }
                else if (Speed == 70 && cki.Key == ConsoleKey.Spacebar)
                {
                    Gear--;
                    Console.WriteLine($"Your gear is {Gear}");
                }
                else if (Speed == 100 && cki.Key == ConsoleKey.UpArrow)
                {
                    Gear++;
                    Console.WriteLine($"Your gear is {Gear}");
                }
                else if (Speed == 100 && cki.Key == ConsoleKey.Spacebar)
                {
                    Gear--;
                    Console.WriteLine($"Your gear is {Gear}");
                }
                else if (Speed == 220 || Speed<0)
                {
                    Console.WriteLine("This is the limit");
                    break;
                }
            }   
                while (cki.Key == ConsoleKey.UpArrow || cki.Key ==ConsoleKey.Spacebar);
        }
        
        public void BikeSpeed()
        {
            ConsoleKeyInfo cki;
            int Speed=0;
            int Gear = 0;
            

            do 
            {   
                cki = Console.ReadKey();                                    
                if(cki.Key == ConsoleKey.UpArrow)
                {
                    Speed += 5;
                    Console.WriteLine(Speed);
                            
                    switch (Speed)
                    {
                        case 10:
                            Gear++;
                            Console.WriteLine($"Your gear is {Gear}");
                                break;
                        case 15:
                            Gear++;
                            Console.WriteLine($"Your gear is {Gear}");
                            break;
                        case 20:
                            Gear++;
                            Console.WriteLine($"Your gear is {Gear}");
                            break;
                        case 30:
                            Gear++;
                            Console.WriteLine($"Your gear is {Gear}");
                            break;                       
                    }
                }
                else if(cki.Key == ConsoleKey.DownArrow)
                {                   
                    Speed -= 5;
                    Console.WriteLine(Speed+5);

                    switch (Speed)
                    {
                        case 10:
                            Gear--;
                            Console.WriteLine($"Your gear is {Gear}");
                            break;
                        case 15:
                            Gear--;
                            Console.WriteLine($"Your gear is {Gear}");
                            break;
                        case 20:
                            Gear--;
                            Console.WriteLine($"Your gear is {Gear}");
                            break;
                        case 30:
                            Gear--;
                            Console.WriteLine($"Your gear is {Gear}");
                            break;                     
                    }                    
                }
                if (Speed == 40 || Speed < 0)
                    break;
            }
            while (cki.Key == ConsoleKey.UpArrow || cki.Key == ConsoleKey.DownArrow);
        }
    }
}
