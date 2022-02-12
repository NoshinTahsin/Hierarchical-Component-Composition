using System;
using ClassLibraryBookFinder;

namespace DetermineBestSeller
{
    public interface IBestSeller
    {
        public String sortList(String booklist);
        public String showBestSellerList(int year);
    }
}
