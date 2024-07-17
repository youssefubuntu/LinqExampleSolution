namespace LinkExample
{
    public class DataSource
    {
        public static IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, AuthorId = 2, Price = 15.00, Title = "Black Swan" },
                new Book { Id = 2, AuthorId = 2, Price = 10.99, Title = "Skin in The Game" },
                new Book { Id = 3, AuthorId = 2, Price = 11.99, Title = "Fooled By Randomness" },
                new Book { Id = 4, AuthorId = 1, Price = 10.50, Title = "The Alchemist" },
                new Book { Id = 5, AuthorId = 1, Price = 11.00, Title = "Maktub" },
                new Book { Id = 6, AuthorId = 3, Price = 17.50, Title = "The Forty Rules of Love" },
                new Book { Id = 7, AuthorId = 1, Price = 14.99, Title = "Eleven Minutes" },
            };
        }

        public static IEnumerable<Author> GetAuthors()
        {
            return new List<Author>
            {
                new Author { Id = 1, FullName = "Paulo Coelho", Country = "Brazil" },
                new Author { Id = 2, FullName = "Nasim Taleb", Country = "Lebanon" },
                new Author { Id = 3, FullName = "Elif Shafak", Country = "Turkey" },
            };
        }
    }
}
