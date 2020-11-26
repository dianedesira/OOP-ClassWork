using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookScenario
{
    class Program
    {
        static void Main(string[] args)
        {
            Author auth1 = new Author(322, "Joe", "Aquilina", 5999);
            Author auth2 = new Author(688, "Charmaine", "Bartolo", 3911);
            Author auth3 = new Author(188, "Richard", "Mizzi", 8112);

            Book book1 = new Book(2110000, "First Book", 26.50);
            book1.AddAuthor(auth1); book1.AddAuthor(auth2);
            book1.AddChapter("Chapter 1"); book1.AddChapter("Chapter 2"); book1.AddChapter("Chapter 3");

            for (int i = 0; i < 20; i++)
            {
                book1.Chapters[0].AddPage();
            }

            for (int i = 0; i < 25; i++)
            {
                book1.Chapters[1].AddPage();
            }

            book1.AddStock(10);

            Console.WriteLine("How many copies would you like to purchase of Book1?");
            int quantityToBuy = int.Parse(Console.ReadLine());

            string result = book1.Purchase(quantityToBuy);

            Console.WriteLine(result);

            if (result.Contains("There are only "))
            {
                string ans = Console.ReadLine().ToLower();
                switch (ans)
                {
                    case "y":
                        Console.WriteLine(book1.Purchase(book1.Stock));
                        break;
                    case "n":
                        Console.WriteLine("Thanks anyway!");
                        break;
                    default:
                        Console.WriteLine("Incorrect input!");
                        break;
                }
            }

            Book book2 = new Book(82222, "Book2", 34);
            book2.AddAuthor(auth3); book2.AddAuthor(auth1);
            book2.AddChapter("Chapter 1"); book2.AddChapter("Chapter 2");
            Console.WriteLine(auth3.PublishBook(book2));

            Console.ReadKey();

        }
    }
}
