using System;
using ClassLibraryBookFinder;

namespace DetermineBestSeller
{
    public class BestSeller:IBestSeller
    {
        public String sortList(String booklist)
        {
            Console.WriteLine("Sorting data...Preparing top 20 best seller list...");
            return "List of top 20 best sellers.";
        }
        public String showBestSellerList(int year)
        {
            BookFinder bookfinder = new BookFinder();
            String booklist = bookfinder.findBooks(year);

            Console.WriteLine("Fetching data...");
            Console.WriteLine("Returned " + booklist + "\n");

            String top_20_bestsellers = this.sortList(booklist);
            Console.WriteLine("Returned " + top_20_bestsellers + "\n");
            return top_20_bestsellers;

        }
    }
}
