using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookScenario
{
    class Author : Person // inheritance
    {
        int registrationNumber;
        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }

        public Author(int id, string name, string surname, int registrationNumber) :
            base(id, name, surname)
        {
            this.registrationNumber = registrationNumber;
        }

        public string PublishBook(Book bookToPublish) // simple association since the Book type
        // is not part of the Author type since it is not one of its attributes thus it does not
        // make up the Author. The Author only USES the Book.
        {
            string listOfAuthors = "";
            int authorCount = 1;

            foreach (Author author in bookToPublish.Authors)
            {
                listOfAuthors += "\nAuthor " + authorCount + " Name: " + author.Name + " Surname: " +
                    author.Surname;
                authorCount++;
            }

            return "Book published\nTitle: " + bookToPublish.Title + "\nISBN: "
                + bookToPublish.Isbn + "\nAuthors: " + listOfAuthors + "\nChapters: " +
                bookToPublish.Chapters.Count;
        }
    }
}
