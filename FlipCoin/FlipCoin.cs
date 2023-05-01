using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    internal class FlipCoin
    {
        public static void DisplayPercentage()
        {
            Console.WriteLine("please enter the number of flip");
            int Headcount = 0;
            int Tailcount = 0;
            double Headpercentage = 0;
            double Tailpercentage = 0;
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    Random random = new Random();
                    int chance = random.Next(2);
                    Console.WriteLine("the random function is :" + chance);
                    if (chance == 1)
                    {
                        Headcount++;
                        Console.WriteLine("head count is " +Headcount);
                    }
                    else if (chance == 0)
                    {
                        Tailcount++;
                        Console.WriteLine("Tail count is " +Tailcount);
                    }
                }
                    Console.WriteLine("the head count is :" + Headcount);
                    Console.WriteLine("the tail count is :" + Tailcount);
                    Headpercentage = Headcount * 100 / number;
                    Tailpercentage = Tailcount * 100 / number;
                    Console.WriteLine("tail per {0}" + Tailpercentage);
                    Console.WriteLine("head per {1}" + Headpercentage);


                
            }
        }
    }
}
