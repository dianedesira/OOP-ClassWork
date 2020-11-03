using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Que7
{
    class RandomNumbers
    {
        Random rand = new Random();

        int num1 = 0;
        int num2 = 0;
        int sum = 0;

        public void GenerateNumbers()
        {
            num1 = rand.Next(1, 11);
            num2 = rand.Next(1, 11);
        }

        public int GetNumber1()
        {
            return num1;
        }

        public int GetNumber2()
        {
            return num2;
        }

        public void FindSum()
        {
            sum = num1 + num2;
        }

        public bool IsEqual(int userInput)
        {
            if (sum == userInput)
                return true;
            else
                return false;
        }

    }
}
