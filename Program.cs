namespace CSharpLearningCourse;

// Create a publicly Instantiateable class called Program without an constructor
public class Program
{
    // Variables
    private static readonly int[] _numberArray = {5, 9, 10, 3, 2};
    private static readonly string[] _wordsToSplit = { "Hello", "World", "LOL" };
    private static readonly int[] _keys = {1, 3, 5};
    private static readonly int[] _value = {3, 5, 7};
    private static readonly string[] _stringULs = { "HaLlO", "WeLt", "LOL" };
    private static readonly int _iterations = 10;
    private static readonly int _rangeStart = 15;
    private static readonly int _rangeEnd = 30;
    // Static Main as Program Entry Point
    public static int Main()
    {
        // Logging
        Console.WriteLine("Build Successful and all Classes were Loaded");

        // Instantiate new Instance of Loops Class
        Loops loops = new Loops();
        // Call all methods of class Loops
        loops.iterateIntArray(_numberArray);
        loops.splitStringsIntoCharacter(_wordsToSplit);
        loops.dictionaryIteration(_keys, _value);
        loops.reversedCaseString(_stringULs);
        loops.randomNumberGeneration(_iterations, _rangeStart, _rangeEnd);
        // Return 0, Program ran successfully
        return 0;
    }
}