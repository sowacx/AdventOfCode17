using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_17_RestOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"11	11	13	7	0	15	5	5	4	4	1	1	7	1	15	11";
            int solution = PuzzleSolver.Solve62(input);
            Console.WriteLine(solution);
            Console.ReadKey();
        }
    }

    public static class PuzzleSolver
    {
        public static int Solve62(string input)
        {
            string[] words = input.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();
            StringBuilder sb = new StringBuilder();
            foreach (var el in words)
            {
                numbers.Add(int.Parse(el));
                sb.Append(el);
            }
            string primaryList = sb.ToString();
            Dictionary<String,int> listOfLists = new Dictionary<string,int>();
            listOfLists.Add(primaryList, 0);

            int steps = 0;
            bool isRepeating = false;

            while (!isRepeating)
            {
                int maxNumber = numbers.Max();
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == maxNumber)
                    {
                        i++;
                        int indexOfMax = i - 1;
                        for (int j = maxNumber; j > 0; j--)
                        {

                            if (i < numbers.Count)
                            {
                                numbers[i]++;
                            }
                            else
                            {
                                numbers[(i % numbers.Count)]++;
                            }

                            numbers[indexOfMax]--;
                            i++;
                        }
                        break;
                    }
                }
                steps++;
                sb = new StringBuilder();
                foreach (int num in numbers)
                {
                    sb.Append(num.ToString());
                }
                var newList = sb.ToString();
                if (listOfLists.Keys.Contains(newList))
                {
                    isRepeating = true;
                    steps = steps - listOfLists[newList];
                }
                else
                {
                    listOfLists.Add(newList, steps);
                }

            }

            return steps;
        }

        public static int Solve61(string input)
        {
            string[] words = input.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();
            StringBuilder sb = new StringBuilder();
            foreach (var el in words)
            {
                numbers.Add(int.Parse(el));
                sb.Append(el);
            }
            string primaryList = sb.ToString();
            List<String> listOfLists = new List<string>() { primaryList };

            int steps = 0;
            bool isRepeating = false;

            while (!isRepeating)
            {
                int maxNumber = numbers.Max();
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == maxNumber)
                    {
                        i++;
                        int indexOfMax = i - 1;
                        for (int j = maxNumber; j > 0; j--)
                        {

                            if (i < numbers.Count)
                            {
                                numbers[i]++;
                            }
                            else
                            {
                                numbers[(i % numbers.Count)]++;
                            }

                            numbers[indexOfMax]--;
                            i++;
                        }
                        break;
                    }
                }
                steps++;
                sb = new StringBuilder();
                foreach (int num in numbers)
                {
                    sb.Append(num.ToString());
                }
                var newList = sb.ToString();
                if (listOfLists.Contains(newList))
                {
                    isRepeating = true;
                }
                else
                {
                    listOfLists.Add(newList);
                }

            }

            return steps;
        }


        public static int Solve52(string input)
        {
            string[] lines = input.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();
            foreach (var el in lines)
            {
                numbers.Add(int.Parse(el));
            }

            int steps = 0;
            int currentPos = 0;
            bool isOut = false;

            while (!isOut)
            {
                if (currentPos < 0 || currentPos >= numbers.Count)
                {
                    isOut = true;
                    return steps;
                }

                int lastPos = currentPos;
                currentPos += numbers[currentPos];
                numbers[lastPos] += numbers[lastPos] >= 3 ? -1 : 1;
                steps++;
            }

            return steps;
        }

        public static int Solve51(string input)
        {
            string[] lines = input.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();
            foreach (var el in lines)
            {
                numbers.Add(int.Parse(el));
            }

            int steps = 0;
            int currentPos = 0;
            bool isOut = false;

            while (!isOut)
            {
                if (currentPos < 0 || currentPos >= numbers.Count)
                {
                    isOut = true;
                    return steps;
                }

                int lastPos = currentPos;
                currentPos += numbers[currentPos];
                numbers[lastPos]++;
                steps++;
            }

            return steps;
        }
    }
}
