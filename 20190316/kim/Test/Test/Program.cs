using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to book management system");

            Console.WriteLine("Please select menu");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Check all books");

            int selected = int.Parse(Console.ReadLine());
            switch(selected)
            {
                case 1:
                    Console.WriteLine("Please input title.");
                    string Title = Console.ReadLine();

                    Console.WriteLine("Please input author.");
                    string Author = Console.ReadLine();

                    Console.WriteLine("Please input price.");
                    int Price = int.Parse(Console.ReadLine());

                    Console.WriteLine("Do you register this book? y / n");
                    string reply = Console.ReadLine();

                    switch (reply)
                    {
                        case "y":
                            Book book = new Book(Title, Author, Price);
                            BookService service = new BookService();
                            service.RegisterBook(book);

                            foreach(Book b in service.GetAllBooks())
                            {
                                Console.WriteLine(b.Title + ", " + b.Author + ", " + b.Price);
                            }

                            service = null; // call Deconstructor

                            break;

                        case "n":
                            break;

                        default:
                            break;
                    }

                    break;

                case 2:
                    break;

                case 3:
                    break;

                default:
                    break;
            }


        }
    }

    class Book
    {
        public string Title;
        public string Author;
        public int Price;

        public Book(string Title, string Author, int Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }
    }

    class BookService
    {
        public BookDB db;
        public List<Book> booklist;

        public BookService()
        {
            this.db = new BookDB();
            this.booklist = db.GetBookList();
        }

        ~BookService()
        {
            Console.WriteLine("BookService Deconstructing starts.");
        }

        // Create
        public void RegisterBook(Book book)
        {
            booklist.Add(book);
            Console.WriteLine(booklist.Count);
        }

        // Remove

        // Update

        // getAll
        public List<Book> GetAllBooks()
        {
            return this.booklist;
        }
    }

    class BookDB
    {
        List<Book> list = new List<Book>();

        public List<Book> GetBookList()
        {
            return this.list;
        }
    }
}
