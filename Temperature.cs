using System.Threading;
namespace CSharpLearningCourse;
// Start temp = 20
// Max Temp = 30
// Start temp + or - 2 or 1
// if > 30 == -1 until 18, then quit

public class Temperature
{
    private static int _temperature = 20;
    private static int _maxTemperature = 30;
    private static int _exitTemperature = 18;
    private static int _airConditionerActiveCooling = -1;


    public void TemperatureCalculation()
    {
        // Instantiate a new random class
        Random random = new Random();
        if (_temperature != 20)
        {
            Console.WriteLine("Temperature is not equal to 20 yet, please be patient");
            return;
        }
        else
        {
            while (_temperature > 15 && _temperature < 35)
            {
                Thread.Sleep(5000);
                int sumOrSub = random.Next(0, 1);
                if (sumOrSub == 0)
                {
                    _temperature = _temperature - 1;
                    Console.WriteLine("- 1 degree");
                }
                else
                {
                    _temperature = _temperature + 2;
                    Console.WriteLine("+ 2 degree");
                }
                Console.WriteLine("Current Temperature is " + _temperature);


                if (_temperature > _maxTemperature)
                {
                    while (_temperature > _exitTemperature)
                    {
                        Thread.Sleep(3000);
                        _temperature = _temperature - _airConditionerActiveCooling;
                    }
                    // System.Environment.Exit(1);   <- For Killing Script
                    return;  // <- For Exiting method
                }
            }
        }
    }
    
    
}