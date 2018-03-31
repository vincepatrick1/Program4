// File: GroundPackage.cs
// This file creates a GroundPackage class capable of validating
// the zip codes and details of the package the user has entered while
// also calculating the zone distance and price.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class GroundPackage
    {
        public const int MIN_ZIP = 00000; // Minimum zip for validation
        public const int MAX_ZIP = 99999; // Maximum zip for validation

        private int _orginZip;  // Variable for orgin zip #
        private int _destZip;   // Variable for destination zip #
        private double _length; // Variable for length of package in inches
        private double _width;  // Variable for width of package in inches
        private double _height; // Variable for height of package in inches
        private double _weight; // Variable for weight of package in pounds

        // Precondition:  00000 <= orgin <= 99999
        //                00000 <= dest <= 99999
        //                0 < l
        //                0 < wi
        //                0 < h
        //                0 < we
        // Postcondition: The GroundPackage object has been initialized with the specified
        //                orgin zip, dest zip, length, width, height, weight
        public GroundPackage(int orgin, int dest, double l, double wi, double h, double we)
        {
            OrginZip = orgin;      // set the OrginZip property
            DestinationZip = dest; // set the Destination property
            Length = l;  // set the Length property
            Width = wi;  // set the Width property
            Height = h;  // set the Height property
            Weight = we; // set the Weight property
        }
        
        public int OrginZip
        {
            // Precondition:  None
            // Postcondition: The orginZip has been returned
            get
            {
                return _orginZip;  // return orginZip value
            }

            // Precondition:  00000 <= value <= 99999
            // Postcondition: The orginZip has been set to the specified value
            set
            {
                if ((value >= MIN_ZIP) && (value <= MAX_ZIP))  // If value is in between range
                    _orginZip = value;                         // set orginzip to value entered 
            }
        }
        public int DestinationZip
        {
            // Precondition:  None
            // Postcondition: The destZip has been returned
            get
            {
                return _destZip;  // return destZip value
            }

            // Precondition:  00000 <= value <= 99999
            // Postcondition: The destinationZip has been set to the specified value
            set
            {
                if ((value >= MIN_ZIP) && (value <= MAX_ZIP))  // If value is in between range
                    _destZip = value;                          // set destZip to value entered
            }
        }
        public double Length
        {
            // Precondition:  None
            // Postcondition: The length has been returned
            get
            {
                return _length; // return length value
            }

            // Precondition:  value > 0
            // Postcondition: The length has been set to the specified value
            set
            {
                if (value > 0)       // If greater than 0
                    _length = value; // set length to value entered
            }
        }
        public double Width
        {
            // Precondition:  None
            // Postcondition: The width has been returned
            get
            {
                return _width; // return width value
            }

            // Precondition:  value > 0
            // Postcondition: The width has been set to the specified value
            set
            {
                if (value > 0)      // If greater than 0
                    _width = value; // set width to value entered
            }
        }
        public double Height
        {
            // Precondition:  None
            // Postcondition: The height has been returned
            get
            {
                return _height; // return height value
            }

            // Precondition:  value > 0
            // Postcondition: The height has been set to the specified value
            set
            {
                if (value > 0)       // If greater than 0
                    _height = value; // set height to value entered
            }
        }
        public double Weight
        {
            // Precondition:  None
            // Postcondition: The weight has been returned
            get
            {
                return _weight; // return width value
            }

            // Precondition:  value > 0
            // Postcondition: The weight has been set to the specified value
            set
            {
                if (value > 0)       // If greater than 0
                    _weight = value; // set weight to value entered
            }
        }
        public int ZoneDistance
        {
            // Precondition:  00000 <= orginZip <= 99999
            //                00000 <= destZip <= 99999
            // Postcondition: The zoneDistance has been returned
            get
            {
                int zoneDist;  // Declare variable to hold zone distance
                zoneDist = Math.Abs((_orginZip / 10000) - (_destZip / 10000)); // Calculate the absolute value of Zone distance
                return zoneDist;  // return zone distance
            }
        }
        // Precondition:  Length, Width, Height, Weight, Zone Distance are all validated
        // Postcondition: The cost of sending the package is returned
        public double CalcCost()
        {
            double cost; // create variable to hold cost
            cost = .20 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * (Weight); // Calculate cost
            return cost; // return cost value
        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the details of the package
        public override string ToString()
        {
            return "Orgin: "+ OrginZip.ToString("D5") + System.Environment.NewLine 
                + "Destination: "+DestinationZip.ToString("D5") + System.Environment.NewLine+
                "Length: " + Length.ToString("F1") + System.Environment.NewLine + "Width: " + Width.ToString("F1")
                + System.Environment.NewLine + "Height: " + Height.ToString("F1") + System.Environment.NewLine +
                "Weight: " + Weight.ToString("F1");  // return the details of package as a string
        }
    }
}
