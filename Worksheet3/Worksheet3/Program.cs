using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Worksheet3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();

            Magazine mag1 = new Magazine();

            book1.Title = "Book 1";
            book2.Title = "Book 2";
            mag1.Title = "Magazine 1";
            book1.Copies = 5;
            book2.Copies = 10;

            Console.WriteLine(book1.Title + " " + book1.SellCopy());
            Console.WriteLine(book2.Title + " " + book2.OrderCopies(5));

            mag1.CurrIssue = 6;
            mag1.RecNewIssue();
            Console.WriteLine("Current issue for " + mag1.Title + " is " + mag1.CurrIssue);

            Console.ReadKey();
        }
    }
}
