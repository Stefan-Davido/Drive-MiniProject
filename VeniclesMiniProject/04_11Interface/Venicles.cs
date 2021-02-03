using System;
using System.Collections.Generic;
using System.Text;

namespace _04_11Interface
{
    public class Venicles
    {                     
        public void ChoseVenicle()
        {
            IPerfomance IPerf = new Perfomance();
            IMarks IMarks = new Marks();
            Console.WriteLine("Chose your venicle:");
            Console.WriteLine(" 1) for Car");
            Console.WriteLine(" 2) for Bicycle");


            int venicle = int.Parse(Console.ReadLine());
            Console.WriteLine("Enjoy your ride");    
            switch (venicle)
            {
                case 1:
                    IMarks.CarMarks();
                    IPerf.Colour_();
                    Console.WriteLine("UpArrow to Speed Up");
                    Console.WriteLine("SpaceBar to slow Speed");
                    IPerf.CarSpeedGear();
                    ChoseVenicle();                   
                    break;
                case 2:
                    IMarks.BikeMarks();
                    IPerf.Colour_();
                    Console.WriteLine("UpArrow to Speed Up");
                    Console.WriteLine("DownArrow to slow Speed");
                    IPerf.BikeSpeed();
                    ChoseVenicle();
                    break;
            }           
        }       
    }
}
