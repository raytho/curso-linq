using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_linq
{
    public class LinqQueries
    {
        private List<Book> booksCollection = new List<Book>();

        public LinqQueries()
        {
            using(StreamReader reader = new StreamReader("books.json")) 
            {
                var json = reader.ReadToEnd();
                this.booksCollection = System.Text.Json.JsonSerializer
                .Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }

        public IEnumerable<Book> AllCollection()
        {
            return booksCollection;
        }

        public IEnumerable<Book> BooksAfter2000()
        {
            // Extension method
            return booksCollection.Where(p => p.PublishedDate.Year >= 2000);

            // Query expresion
            //return from l in booksCollection where l.PublishedDate.Year >= 2000 select l;
        }

        public IEnumerable<Book> BigBooksAction()
        {
            // Extension method
            return booksCollection.Where(p => p.PageCount >= 250 && p.Title.Contains("in Action"));

            // Query expresion
            //return from l in booksCollection where l.PageCount >= 250 && l.Title.Contains("in Action") select l;
        }

        public bool BooksHaveStatus()
        {
            // Extension method
            return booksCollection.All(book => !String.IsNullOrWhiteSpace(book.Status));
        }

        public bool BooksPublishIn2005()
        {
            // Extension method
            return booksCollection.Any(book => book.PublishedDate.Year == 2005);
        }
    }
}