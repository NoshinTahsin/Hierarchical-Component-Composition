using System;
using ClassLibraryBookFinder;

namespace DetermineBestSeller
{
    public interface IDetermineBestSeller
    {
        public String sortList(String booklist);
        public String showBestSellerList(int year);
    }
}
