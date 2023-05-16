using System;
using System.Linq;

namespace ClassLibrary
{
    public class Class1
    {
        public static void Main()
        {
            int count = int.Parse(System.Console.ReadLine());

            int[] ballots = new int[count];
            for (int i = 0; i < count; i++)
                ballots[i] = int.Parse(System.Console.ReadLine());

            if (count == 1)
            {
                Console.WriteLine(0);
                return;
            }
            else if(ballots.Distinct().Count() <= 1)
            {
                Console.WriteLine(1);
                return;
            }

            int dasom = ballots[0];
            int prev = dasom;
            ballots[0] = 0;
            while(true)
			{
                Array.Sort(ballots);
                ballots.Reverse();

                if (ballots.Max() >= dasom)
                {
                    ballots[count - 1]--;
                    dasom++;
                }
                else
                    break;

			}

            Console.WriteLine(dasom - prev);
        }
    }
}