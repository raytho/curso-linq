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
    }
}