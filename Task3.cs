using lesson_5_dz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5_dz
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsRead { get; set; }
    }

    public class BookList
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public bool ContainsBook(Book book)
        {
            return books.Contains(book);
        }

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
        public void Show()
        {
            foreach (var book in this.books)
            {
                Console.WriteLine($"Title : {book.Title}, Author : {book.Author}, IsRead : {book.IsRead}");
            }
        }
    }
    internal class Task3
    {
        public static void task3()
        {
            BookList bookList = new BookList();

            // Додаємо книги до списку
            bookList.AddBook(new Book { Title = "1984", Author = "George Orwell", IsRead = false });
            bookList.AddBook(new Book { Title = "Brave New World", Author = "Aldous Huxley", IsRead = true });
            bookList.AddBook(new Book { Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams", IsRead = false });

            bookList.Show();

            // Перевіряємо наявність книги в списку
            Book bookToFind = new Book { Title = "1984", Author = "George Orwell", IsRead = false };
            if (bookList.ContainsBook(bookToFind))
            {
                Console.WriteLine("Книга знайдена в списку!");
            }

            // Видаляємо книгу зі списку
            bookList.RemoveBook(bookToFind);
            Console.WriteLine();
            bookList.Show();
        }
    }
}
