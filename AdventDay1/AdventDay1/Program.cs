using System;
using System.Collections.Generic;

namespace AdventDay1
{
    public class Program
    {
        public List<int> customList = new List<int>
        {
            98, 25, 30, 77, 120, 80, 40, 105, 130, 60, 50
        };

        public List<int> numList = new List<int>();
        public int num1;
        public int num2;
        public int num3;
        static void Main(string[] args)
        {
        }

        public void listExtract()
        {
            string line;
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"D:\Sparta training\Testing\Homework\TDDPractice\AdventDay1\AdventDay1\input.txt");
            while ((line = file.ReadLine()) != null)
            {
                numList.Add((Int32.Parse(line)));
            }
        }

        public int listSumTwoNums(List<int> numList, int expOutput)
        {
            foreach (var numOne in numList)
            {
                num1 = numOne;
                foreach (var numTwo in numList)
                {
                    num2 = numTwo;
                    if(num1 + num2 == expOutput)
                    {
                        return expOutput;
                    }
                }
            }
            return 0;
        }

        public int listSumThreeNums(List<int> numList, int expOutput)
        {
            foreach (var numOne in numList)
            {
                num1 = numOne;
                foreach (var numTwo in numList)
                {
                    num2 = numTwo;
                    foreach (var numThree in numList)
                    {
                        num3 = numThree;
                        if (num1 + num2 + num3 == expOutput)
                        {
                            return expOutput;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
