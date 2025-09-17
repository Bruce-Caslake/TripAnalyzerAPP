using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TripAnalyzerAPP
{
    public class ExampleTrip
    {
        private string Destination { get; set; }
        private double MilesDriven { get; set; } 
        private double NumberOfGallons { get; set; }
        private double CostOfGas { get; set; }


        public ExampleTrip(string destination, double milesDriven, double numberOfGallons, double costOfGas)
        {
            Destination = destination;
            MilesDriven = milesDriven;
            NumberOfGallons = numberOfGallons;
            CostOfGas = costOfGas;
        }
        public double CalculateMilesPerGallon()
        {
            return MilesDriven / NumberOfGallons;
        }
        public double CalculateCostPerMile()
        {
            return CostOfGas / NumberOfGallons;
        }
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
