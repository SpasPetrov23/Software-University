namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            var result = CountBooks(db, 40);
            Console.WriteLine(result);
        }
        //11. Count Books
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context.Books
                .Where(x => x.Title.Length > lengthCheck)
                .Select(x => x.Title)
                .Count();

            return books;
        }

        //10. Book Search by Author
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(x => x.Author.LastName
                    .ToLower()
                    .StartsWith(input.ToLower()))
                .OrderBy(x => x.BookId)
                .Select(x => new
                {
                    Title = x.Title,
                    AuthorFirstName = x.Author.FirstName,
                    AuthorLastName = x.Author.LastName,
                });

            var sb = new StringBuilder();
            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} ({book.AuthorFirstName} {book.AuthorLastName})");
            }

            return sb.ToString().TrimEnd();
        }


        //9. Book Search
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {

            var books = context.Books
                .Where(x => x.Title
                    .ToLower()
                    .Contains(input.ToLower()))
                .OrderBy(x => x.Title)
                .Select(x => x)
                .ToList();

            var sb = new StringBuilder();
            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title}");
            }

            return sb.ToString().TrimEnd();
        }

        //8. Author Search
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                .Where(x => x.FirstName.EndsWith(input))
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    FullName = x.FirstName + " " + x.LastName,
                })
                .OrderBy(x => x.FullName);

            var sb = new StringBuilder();
            foreach (var author in authors)
            {
                sb.AppendLine($"{author.FirstName} {author.LastName}");
            }

            return sb.ToString().TrimEnd();
        }

        //7. Released Before Date
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            var books = context.Books
                .Where(x => x.ReleaseDate < DateTime.ParseExact(date, "dd-MM-yyyy", provider))
                .OrderByDescending(x => x.ReleaseDate)
                .Select(x => new
                {
                    Title = x.Title,
                    EditionType = x.EditionType,
                    Price = x.Price,
                });

            var sb = new StringBuilder();
            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:F2}");
            }

            return sb.ToString().TrimEnd();
        }


        //6. Book Titles by Category
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input
                .Split(" ")
                .Select(x => x.ToLower())
                .ToArray();

            var sb = new StringBuilder();

            var bookTitles = context.Books
                    .Where(book => book.BookCategories
                    .Any(cat => categories.Contains(cat.Category.Name.ToLower())))
                    .Select(x => x.Title)
                    .OrderBy(x => x);

            foreach (var book in bookTitles)
            {
                sb.AppendLine(book);
            }

            return sb.ToString().TrimEnd();
        }


        //5. Not Released In
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(x => x.ReleaseDate.Value.Year != year)
                .Select(x => new
                {
                    Title = x.Title,
                    Id = x.BookId,
                })
                .OrderBy(x => x.Id);

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }
            return sb.ToString().TrimEnd();
        }

        //4. Books by Price
        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(x => x.Price > 40)
                .Select(x => new
                {
                    Title = x.Title,
                    Price = x.Price,
                })
                .OrderByDescending(x => x.Price)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:F2}");
            }
            return sb.ToString().TrimEnd();
        }

        //3. Golden Books
        public static string GetGoldenBooks(BookShopContext context)
        {
            var goldenBooks = context.Books
                .Where(x => x.EditionType == EditionType.Gold)
                .Where(x => x.Copies < 5000)
                .Select(x => new
                {
                    Title = x.Title,
                    BookId = x.BookId,
                })
                .OrderBy(x => x.BookId);

            var sb = new StringBuilder();

            foreach (var book in goldenBooks)
            {
                sb.AppendLine(book.Title);
            }
            return sb.ToString().TrimEnd();
        }


        //2. Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var ageRestriction = Enum.Parse<AgeRestriction>(command, true);

            var books = context.Books
                .Where(x => x.AgeRestriction == ageRestriction)
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
