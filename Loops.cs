using System.Collections.Generic;
using System.Diagnostics;

namespace CSharpLearningCourse;

public class Loops
{
    public void iterateIntArray(int[] numbers)
    {
        Console.WriteLine(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            
            Console.WriteLine(numbers[i] + " ");
        }
    }

    public void splitStringsIntoCharacter(string[] stringToSplit)
    {
        foreach (string item in stringToSplit)
        {
            for (int i = 0; i < item.Length; i++)
            {
                Console.WriteLine(item[i]);
            }
        }
    }

    public void dictionaryIteration(int[] keys, int[] Value)
    {
        // Create Instance of Dictionary Class with 2 Int as key and Value
        Dictionary<int, int> dictToSplit = new Dictionary<int, int>();
        // Fill Dictionary with Value
        for (int i = 0; i < keys.Length; i++)
        {
            dictToSplit.Add(keys[i], Value[i]);
        }

        foreach (KeyValuePair<int, int> dict in dictToSplit)
        {
            Console.WriteLine("Key is: {0} and Value is {1}", dict.Key, dict.Value);
        }
        Console.WriteLine();
    }

    public void reversedCaseString(string[] words)
    {
        foreach (string item in words)
        {
            char[] charitem = item.ToCharArray();
            for (int i = 0; i < words.Length; i++)
            {

                if (char.IsUpper(charitem[i]))
                {
                    charitem[i] = char.ToLower(charitem[i]);
                }
                else if (char.IsLower(charitem[i]))
                {
                    charitem[i] = char.ToUpper(charitem[i]);
                }

                if (i == words.Length - 1)
                {
                    Console.WriteLine(charitem);
                }
            }
        }
        
    }

    public void randomNumberGeneration(int iterations, int rangeStart, int rangeEnd)
    {
        Random rnd = new Random();
        int[] numbers = new int[iterations];
        for (int i = 0; i < iterations; i++)
        {
            numbers[i] = rnd.Next(rangeStart, rangeEnd);
        }

        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
    
    
}