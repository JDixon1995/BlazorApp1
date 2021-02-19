using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IBookService
    {
        Book[] GetBooks();
    }
    public class BookService : IBookService
    {
        
        public Book[] GetBooks()
        {
            var rng = new Random();
            {
                return new Book[]
                {
                    new Book { Title = "Test Book", Overview = "Random overview", Price = 15},
                    new Book { Title = "The Big Book of Maps", Overview = "all your map needs inside", Price = 35},
                    new Book { Title = "Comic Book Price Guide", Overview = "how much is your comic worth?", Price = 25}
                };
            }
        }
    }
}
