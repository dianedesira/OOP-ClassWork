using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Honda", "Silver");
            Car car2 = new Car("Fiat", "White");
            /* List<Car> cars = new List<Car>();
             cars.Add(car1);
             cars.Add(car2);
            */

            Car[] cars = new Car[2];
            cars[0] = car1;
            cars[1] = car2;

            int chosenIndex = 0;
            bool correctIndex = false;

            do {
                Console.WriteLine("Choose the car which you are going to use today:");
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.Write((i + 1) + ". " + cars[i].Manufacturer + " ");
                }
                Console.Write("\nChoose: ");
                chosenIndex = Convert.ToInt32(Console.ReadLine());
                chosenIndex--;

                switch (chosenIndex)
                {
                    case 0:
                    case 1:
                        correctIndex = true;
                        break;
                }

                if (!correctIndex)
                {
                    Console.WriteLine("Incorrect index \n");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!correctIndex);

            Console.ReadKey();

            int menuOption = 0;

            do {
                Console.Clear();
                Console.WriteLine("Car Menu");
                Console.WriteLine("========");
                Console.WriteLine("1. Drive Car");
                Console.WriteLine("2. Fill with Fuel");
                Console.WriteLine("3. Change Car Details");
                Console.WriteLine("4. Repaint");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");
                menuOption = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("What is your desitanation?");
                        string destination = Console.ReadLine();
                        Console.WriteLine(cars[chosenIndex].Drive(destination));
                        break;
                    case 2:
                        Console.Write("Enter amount of money: ");
                        double money = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(cars[chosenIndex].FillTank(money));
                        break;
                    case 3:
                        Console.WriteLine("Car Details");                        
                        Console.Write("Colour: ");
                        string colour = Console.ReadLine();
                        int odoRead = 0;
                        try
                        {
                            Console.WriteLine("Odo Metre Reading: ");
                            odoRead = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Odo Metre Reading should be of a number format");
                        }
                        string typeOfFuel = "";
                        do
                        {
                            Console.Write("Type of Fuel (Diesel or Petrol): ");
                            typeOfFuel = Console.ReadLine();
                        } while (cars[chosenIndex].CarDetails(typeOfFuel, colour, odoRead) != "");                       

                        break;
                    case 4:
                        Console.WriteLine("Repaint Car");
                        Console.WriteLine("===========");
                        Console.Write("Colour: ");
                        colour = Console.ReadLine();
                        cars[chosenIndex].Repaint(colour);
                        break;
                    case 5:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid Menu option!");
                        break;
                }

                Console.ReadKey();
            } while (menuOption != 5);

        }
    }
}
