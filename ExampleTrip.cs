using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//This is the Example Class for the TripAnalyzerAPP. 

namespace TripAnalyzerAPP
{
    public class ExampleTrip
    {
        // These are the Constructors, the accessors and mutators. They are private so only the ExampleTrip Class can modify them
        private string Destination { get; set; }
        private double MilesDriven { get; set; } 
        private double NumberOfGallons { get; set; }
        private double CostOfGas { get; set; }

        // This block is the I dont exactly know..
        public ExampleTrip(string destination, double milesDriven, double numberOfGallons, double costOfGas)
        {
            Destination = destination;
            MilesDriven = milesDriven;
            NumberOfGallons = numberOfGallons;
            CostOfGas = costOfGas;
        }
        //The following calculates mpg and cost per mile for the example class given.
        public double CalculateMilesPerGallon()
        {
            return MilesDriven / NumberOfGallons;
        }
        public double CalculateCostPerMile()
        {
            return CostOfGas / NumberOfGallons;
        }
        // This DisplayInfo is what the main() function in the TripAnalyzerAPP pulls when the code is run.
        public void DisplayInfo()
        {
            WriteLine($"Destination: {Destination}");
            WriteLine($"Miles Driven: {MilesDriven}");
            WriteLine($"Number of Gallons Used: {NumberOfGallons}");
            WriteLine($"Total Cost of Gas: {CostOfGas:C}");
            WriteLine();
            WriteLine($"Your cost per Mile was: {CalculateCostPerMile(),2:C}");
            WriteLine($"You were getting: {CalculateMilesPerGallon(),2:F} mpg");   
        }

    }
}
