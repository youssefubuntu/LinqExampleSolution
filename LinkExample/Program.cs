// Join(); [similar to INNER JOIN in SQL]
using LinkExample;

var books = DataSource.GetBooks();
var authors = DataSource.GetAuthors();


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



Console.ReadKey();
