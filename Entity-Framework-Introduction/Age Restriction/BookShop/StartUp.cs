namespace BookShop
{
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);
            Console.WriteLine(CountBooks(db,40));
        }
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var books = context.Books.Where(s => s.AgeRestriction.ToString().ToLower() == command.ToLower())
                .OrderBy(a => a.Title)
                .Select(b=>b.Title)
                .ToArray();
            
            return string.Join(Environment.NewLine, books);
        }
        public static string GetGoldenBooks(BookShopContext context) 
        {

            var goldenbooks = context.Books
                .Where(b=>b.EditionType==Models.Enums.EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b=>b.Title)
                .ToList();

            return string.Join(Environment.NewLine, goldenbooks);
        }
        public static string GetBooksByPrice(BookShopContext context) 
        {
            StringBuilder sb = new StringBuilder();
            var BooksInfo = context.Books.Where(p => p.Price > 40)
                .Select(b => new { b.Price, b.Title })
                .OrderByDescending(b=>b.Price).ToList();
            foreach (var book in BooksInfo) 
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetBooksNotReleasedIn(BookShopContext context, int year) 
        {
            var BooksInfo = context.Books.Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b=>b.BookId)
                .Select(b => b.Title)
                .ToList();
            return string.Join(Environment.NewLine, BooksInfo);
        }

        public static string GetBooksByCategory(BookShopContext context, string input) 
        {
            var categories = input
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(c => c.ToLower())
            .ToList();

            var bookTitles = context.Books
                .Where(b => b.BookCategories
                    .Any(bc => categories.Contains(bc.Category.Name.ToLower())))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, bookTitles);
        }
        public static string GetBooksReleasedBefore(BookShopContext context, string date) 
        {
            StringBuilder sb = new StringBuilder();
            var DismemberedDate = date
                .Split("-", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            DateTime date1 = new DateTime(int.Parse(DismemberedDate[2]), int.Parse(DismemberedDate[1]), int.Parse(DismemberedDate[0]));

            var bookTitles = context.Books
                .Where(b => b.ReleaseDate.Value.Date < date1)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price
                });
            foreach (var book in bookTitles)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input) 
        {
            var authorInfo = context.Authors
                  .Where(a => a.FirstName.EndsWith(input))
                  .OrderBy(a => a.FirstName)
                  .ThenBy(a => a.LastName)
                  .Select(a => $"{a.FirstName} {a.LastName}")
                  .ToList();

            return string.Join(Environment.NewLine, authorInfo);
        }
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var bookTitles = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(a => a.Title)
                .Select(b => b.Title)
                .ToList();
            return string.Join(Environment.NewLine, bookTitles);
        }
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            StringBuilder sb= new StringBuilder();
            var books = context.Books
                .Where(a => a.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(a => a.BookId)
                .Select(b => new
                {
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                    b.Title
                })
                .ToList();
            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} ({book.AuthorName})");
            }
            return sb.ToString().TrimEnd();
        }
        public static int CountBooks(BookShopContext context, int lengthCheck) 
        {
            var BookInfo = context.Books.Count(a => a.Title.Length > lengthCheck);
            return BookInfo;
        }
        public static string CountCopiesByAuthor(BookShopContext context) 
        {
            StringBuilder sb= new StringBuilder();
            var books = context.Authors
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}",
                    TotalCopies = a.Books
                        .Sum(b => b.Copies)
                })
                .ToArray()
                .OrderByDescending(b => b.TotalCopies); 

            foreach (var a in books)
            {
                sb.AppendLine($"{a.FullName} - {a.TotalCopies}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetTotalProfitByCategory(BookShopContext context) 
        {
            StringBuilder sb= new StringBuilder();
            var ProfitPerCategory = context.Categories
                .Select(c => new
                {
                    Name = c.Name,
                    TotalProfit = c.CategoryBooks
                        .Select(cb => cb.Book.Price * cb.Book.Copies)
                        .Sum()
                })
                .OrderByDescending(c => c.TotalProfit)
                .ThenBy(c => c.Name)
                .ToList();
            foreach (var category in ProfitPerCategory)
            {
                sb.AppendLine($"{category.Name} ${category.TotalProfit}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}