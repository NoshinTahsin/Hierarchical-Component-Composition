using System;

namespace ClassLibraryBookFinder
{
    public class BookFinder:IBookFinder
    {
        public String findBooks(int year)
        {
            String books_of_year = "List of books sold in " + year;
            return books_of_year;
        }
    }
}
