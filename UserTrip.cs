using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TripAnalyzerAPP
{
    //This is the UserTrip for the TripAnalyzerAPP. It gathers the information the user enters, when the app is run.
    public class UserTrip
    {
        private string destination;
        private double milesDriven;
        private double numberOfGallons;
        private double costOfGas;

        // These are the constructors. Not exactly sure what they are used for.
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
        //The following are the Modifer's, the getters, and setters for the user's entered information.
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
