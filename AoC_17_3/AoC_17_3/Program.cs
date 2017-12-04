using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_17_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 325489;
            int solution = PuzzleSolver.Solve(input);
            Console.WriteLine(solution);
            Console.ReadKey();
        }
    }

    public static class PuzzleSolver
    {
        public static int Solve(int input)
        {
            int sqrt = (int)Math.Sqrt((double)input);
            double floorOfSqrt = Math.Floor((double)sqrt);
            int diagonal = 0;

            int x = 0;
            int y = 0;


            if (floorOfSqrt % 2 == 0)
            {
                diagonal =  (int)(Math.Floor(((floorOfSqrt - 1)/2)));
                floorOfSqrt -= 1;
                sqrt = sqrt -1;
            }
            else
            {
                diagonal = (int)Math.Floor(((floorOfSqrt) / 2));
            }

            int diff = input - (int)(floorOfSqrt * floorOfSqrt);


            //x = diagonal + 1;
            //y = -diagonal;
            //for(int i = 0 ; i <= diff; i++)
            //{

            //}
            if (diff == 0)
            {
                x = diagonal;
                y = -diagonal;
            }
            else if (diff <= sqrt + 1)
            {
                x = diagonal + 1;
                y = -diagonal + (diff-1);
            }
            else if (diff <= 2 * (sqrt + 1))
            {
                x = diagonal + 1 - ((diff-2) - (int)sqrt + 1);
                y = -diagonal + (int)sqrt;
            }
            else if (diff <= 3 * (sqrt + 1))
            {
                x = -diagonal - 1;
                y = -diagonal + (int)sqrt - ((diff) - (2 * ((int)sqrt + 1)));
            }
            else if (diff <= 4 * (sqrt + 1))           
            {
                x = -diagonal - 1 + ((diff) - (3 * ((int)sqrt + 1)));
                y = -diagonal - 1;
            }


            return Math.Abs(x) + Math.Abs(y);


        }
    }
}
