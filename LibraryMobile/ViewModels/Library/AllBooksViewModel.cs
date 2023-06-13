using LibraryMobile.Services;
using LibraryMobile.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryMobile.Service.Reference;

namespace LibraryMobile.ViewModels.Library
{
    public class AllBooksViewModel : AViewModel<BookDataStore>
    {
        public List<Book> Books { get; private set; }

        public AllBooksViewModel()
        {
            Books = new List<Book>();
            myText = "test1";
        }

        public async Task LoadBooks()
        {
            var books = await DataStore.GetItemsAsync(true);
            Books = new List<Book>(books);
            myText = "test2";
        }




        public string myText = "test";
    }
}
