using System;

namespace BlazorApp1.DAL.Models.Books
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public int Price { get; set; }
    }
}
