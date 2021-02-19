using System;

namespace BlazorApp1.Core.Services.Books
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
                    new Book { Id = 0, Title = "Test Book", Overview = "Random overview", Price = 15},
                    new Book { Id = 1, Title = "The Big Book of Maps", Overview = "all your map needs inside", Price = 35},
                    new Book { Id = 2, Title = "Comic Book Price Guide", Overview = "how much is your comic worth?", Price = 25}
                };
            }
        }
    }
}
