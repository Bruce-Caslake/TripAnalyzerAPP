using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TripAnalyzerAPP
{
    public class UserTrip
    {
        private string destination;
        private double milesDriven;
        private double numberOfGallons;
        private double costOfGas;
        
        public UserTrip()
        {

        }
        public UserTrip(string destination, double milesDriven, double numberOfGallons, double costOfGas)
        {
            Destination = destination;
            MilesDriven = milesDriven;
            GallonsUsed = numberOfGallons;
            CostOfGas = costOfGas;
        }
        public string Destination { get; set; }
        public double MilesDriven { get; set; }
        public double GallonsUsed { get; set; }
        public double CostOfGas { get; set; }

        // the code Block below calculates the mpg and the cost per mile based on the input the user uses.
        public double CalculateMilesPerGallon()
        {
            return MilesDriven / GallonsUsed;
        }
        public double CalculateCostPerMile()
        {
            return CostOfGas / GallonsUsed;
        }

        // The code block below takes variables that the users enters and formats it into a output
        public override string ToString()
        {
            return "Destination: " + Destination + "\nDistance Traveled: " +
                    MilesDriven + " " + "miles" + "\nTotal Cost of Gas: " + CostOfGas +
                    "\nNumber Of Gallons Used: " + GallonsUsed +
                    "\n\nYou were averaging:" + " " + CalculateMilesPerGallon().ToString("F2") + " MPG" +
                    "\nYou average cost per mile was: " + " " + CalculateCostPerMile().ToString("C2");
        }
    }
}
