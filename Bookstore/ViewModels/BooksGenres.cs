using Bookstore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookstore.ViewModels
{
    public class BooksGenres
    {
        public IList<Book> Books { get; set; }

        public SelectList Genres { get; set; }
        public string Search { get; set; }
        public string BookGenre { get; set; }
    }
}
