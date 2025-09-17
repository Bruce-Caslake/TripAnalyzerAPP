//Bruce Caslake
//September 17 2025
//CIS162AD 19607

using static System.Console;

namespace TripAnalyzerAPP
{
    class Program
    {
        static void Main()
        {
            ExampleTrip tripExample = new ExampleTrip("Denver", 546, 34, 120.23);

            WriteLine("Welcome to your Trip Analzyer APP");
            WriteLine();
            WriteLine("This is an example Output!");
            WriteLine("----------------------------");
            WriteLine();
            tripExample.DisplayInfo();
            WriteLine();
            WriteLine("*****************************");
            Write("Please press Enter to enter your Trip: ");
            WriteLine();
            ReadKey();

            UserTrip userTravel = new UserTrip();

            userTravel.Destination = AskForDestination();
            userTravel.MilesDriven = AskForMilesDriven();
            userTravel.GallonsUsed = AskForGallonsUsed();
            userTravel.CostOfGas = AskForCostOfGas();


            WriteLine("********************************");
            WriteLine();
            WriteLine("Welcome to your travel cost analyzer: ");
            WriteLine();
            WriteLine(userTravel.ToString());
            ReadKey();

            static string AskForDestination()
            {
                string inValue;
                Write("Enter your destination: ");
                inValue = ReadLine();
                return inValue;
            }
            static double AskForMilesDriven()
            {
                Write("Enter the amount of Miles you traveled: ");
                string input = ReadLine();
                double inValue = Convert.ToDouble(input);
                return inValue;
            }
            static double AskForCostOfGas()
            {
                Write("Enter how much you spent on gas: ");
                string input = ReadLine();
                double inValue = Convert.ToDouble(input);
                return inValue;
            }
            static int AskForGallonsUsed()
            {
                Write("Enter how many Gallons you used on your trip: ");
                string input = ReadLine();
                double inValue = Convert.ToDouble(input);
                return (int)inValue;

            }
        }
    }
}
