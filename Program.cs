// See https://aka.ms/new-console-template for more information
using curso_linq;

Console.WriteLine("Hello, World!");

LinqQueries queries = new LinqQueries();

PrintValues(queries.AllCollection());

void PrintValues(IEnumerable<Book> queryBooks)
{
  Console.WriteLine("{0, -60} {1, 15} {2, 15}", "Titulo", "N. Paginas", "Fecha Publicacion");

  foreach (var book in queryBooks)
  {
    Console.WriteLine("{0, -60} {1, 15} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
  }
}