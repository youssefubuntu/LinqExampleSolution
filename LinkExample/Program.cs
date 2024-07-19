// Join(); [similar to INNER JOIN in SQL]
using LinkExample;

var books = DataSource.GetBooks();
var authors = DataSource.GetAuthors();

Console.WriteLine("----------Join----------");

// Method Syntax
var booksWithAuthor = books.Join( // outer collection
    authors, // inner collection
    book => book.AuthorId, // outer key selector
    author => author.Id, // inner key selector
    (book, author) => new BookWithAuthor // result selector
    {
       BookId = book.Id,
       BookTitle = book.Title,
       BookPrice = book.Price,
       BookAuthor = author.FullName,
    });

// Query Syntax
var booksWithAuthorQuery = from book in books // outer collection
                           join author in authors // inner collection
                           on book.AuthorId equals author.Id // key selectors
                           select new BookWithAuthor // result selector
                           {
                               BookId = book.Id,
                               BookTitle = book.Title,
                               BookPrice = book.Price,
                               BookAuthor = author.FullName,
                           };


foreach(var bookWithAuthor in booksWithAuthorQuery)
    Console.WriteLine(bookWithAuthor.ToString());


Console.WriteLine("----------Group Join----------");

// Method Syntax
var booksWithAuthorGroupJoin = books.GroupJoin( // outer collection
    authors, // inner collection
    book => book.AuthorId, // outer key selector
    author => author.Id, // inner key selector
    (book, authorCollection) => new BookWithAuthorGroupGoin // result selector
    {
        BookId = book.Id,
        BookTitle = book.Title,
        BookPrice = book.Price,
        Author = authorCollection.ToList()
    });

// Query Syntax
var booksWithAuthorGroupJoinQuery = from book in books // outer collection
                           join author in authors // inner collection
                           on book.AuthorId equals author.Id // key selectors
                           into authorCollection
                           select new BookWithAuthorGroupGoin // result selector
                           {
                               BookId = book.Id,
                               BookTitle = book.Title,
                               BookPrice = book.Price,
                               Author = authorCollection.ToList()
                           };


foreach (var item in booksWithAuthorGroupJoinQuery)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Book Title: {item.BookTitle}, Book Price: {item.BookPrice}");
    foreach(var author in item.Author)
    {
        Console.WriteLine(
            $"Author FullName: {author.FullName}, Author Country: {author.Country}");
    }
    Console.WriteLine("---");
}





Console.ReadKey();
