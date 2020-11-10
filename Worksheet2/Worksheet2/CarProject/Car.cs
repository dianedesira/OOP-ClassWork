using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Car
    {
        // All our fields are private since the default access modifier for Class Elements is private
        string manufacturer;
        string colour;
        string typeOfFuel;

        int odoMeterReading;
        double litres;

        public string Manufacturer
        {
            get { return manufacturer; } // read access
            set { manufacturer = value; } // write access
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public string TypeOfFuel
        {
            get { return typeOfFuel; } // read only
        }

        // new syntax for properties
        public int OdoMeterReading { get => odoMeterReading; set => odoMeterReading = value; }
        public double Litres { get => litres; set => litres = value; }

        public Car(string manufacturer, string colour)
        {
            this.manufacturer = manufacturer;
            this.colour = colour;
            this.Litres = 0;
        }

        public string Drive(string destination)
        {
            if (destination != "")
                return "Vroom Vroom!";
            else
                return "You need to input a destination to drive the car!";
        }

        public string FillTank(double monetaryAmount)
        {
            double newLitres = 0;
            if (typeOfFuel == null || typeOfFuel == "")
                return "Kindly go to the Details Menu Option and indicate your car's type of fuel.";
            else if (typeOfFuel == "diesel")
            {
                newLitres = monetaryAmount * 0.71;
            }
            else
            {
                newLitres = monetaryAmount * 0.65;
            }

            this.litres += newLitres; // this.litres = this.litres + newLitres;

            return "Your car has been filled with " + newLitres + " litres of " + typeOfFuel;
        }

        public string CarDetails(string typeOfFuel, string colour, int odoMeterReading)
        {
            this.colour = colour;
            this.OdoMeterReading = odoMeterReading;
            typeOfFuel = typeOfFuel.ToLower();
            if (typeOfFuel == "diesel" || typeOfFuel == "petrol")
            {
                this.typeOfFuel = typeOfFuel;
                return "";
            }
            else
            {
                return "The inputted type of fuel is incorrect";
            }

        }

        public void Repaint(string newColour)
        {
            this.colour = newColour;
        }
    }
}
