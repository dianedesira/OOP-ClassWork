using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que7
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumbers ranNums = new RandomNumbers();

            ranNums.GenerateNumbers();

            Console.Write("The generated numbers are " + ranNums.GetNumber1() + " and " + 
                ranNums.GetNumber2() + ".\nPlease input their sum: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            ranNums.FindSum();

            bool isEqualAns = ranNums.IsEqual(userInput);

            if (isEqualAns) // if(isEqualAns == true)
            {
                Console.WriteLine("Well done correct answer!");
            }
            else
            {
                Console.WriteLine("Sorry incorrect answer.");
            }

            Console.ReadKey();
        }
    }
}
