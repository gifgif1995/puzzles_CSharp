  
using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {

        static int[] RandomArray()

        {
            Console.WriteLine("First Problem . . . . .");
            int[] randomArr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; ++i){
                randomArr[i] = rand.Next(5,26);
            }
            int min = randomArr[0];
            int max = randomArr[0];
            int sum = randomArr[0];
            for (int i = 1; i < randomArr.Length; ++i)
            {
                if (min > randomArr[i]){
                    min = randomArr[i];
                }
                if (max < randomArr[i]){
                    max = randomArr[i];
                }
                sum += randomArr[i];
            }
            Console.WriteLine("Minimum: {0}\nMaximum: {1}\nSum: {2}", min, max, sum);
            return randomArr;
        }
        static String TossCoin(Random rand)
        {
            string result = "Heads";
            if (rand.Next(0,2) == 1)
            {
                result = "Tails";
            }
            Console.WriteLine("Result: " + result);
            return result;
        }
        static Double TossMultipleCoins(int num)
        {

            Double headsNum = 0;
            Random rand = new Random();
            for (int i = 0; i < num; ++i){
                if (TossCoin(rand) == "Heads")
                {
                    ++headsNum;
                }
            }
            Console.WriteLine("Next Problem . . . . .");
            Console.WriteLine($"Heads Ratio: {headsNum/num}");
            return headsNum/num;
        }
        static string[] Names()
        {
            Console.WriteLine("Next Problem . . . . .");
            string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            // shuffle
            Random rand = new Random();
            String temp = "";
            for (int i = 0; i < names.Length; ++i)
            {
                int index = rand.Next(i,names.Length);
                temp = names[i];
                names[i] = names[index];
                names[index] = temp;
                Console.WriteLine("Index {0} has {1}", i, names[i]);
            }
            Console.WriteLine("Next Problem . . . . .");
            List<string> longNamesList = new List<string>();
            for (int i = 0; i < names.Length; ++i)
            {
                if (names[i].Length > 5){
                    longNamesList.Add(names[i]);
                }
            }
            string[] longNames = longNamesList.ToArray();
            for (int i = 0; i < longNames.Length; ++i)
            {
                Console.WriteLine(longNames[i]);
            }
            return longNames;
        }
                static void Main(string[] args)
        {
            Random rand = new Random();
            RandomArray();
            TossCoin(rand);
            TossMultipleCoins(11);
            Names();
        }
    }
}