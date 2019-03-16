using System;
using System.Collections.Generic;

namespace takeuchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to book management system!");

            Console.WriteLine("Please select menu...");
            Console.WriteLine("1) Register");
            Console.WriteLine("2) Remove");
            Console.WriteLine("3) Check All Books");
            int selected = int.Parse(Console.ReadLine());

            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Please input Title.");
                        string Title = Console.ReadLine();

                        Console.WriteLine("Please input Author.");
                        string Author = Console.ReadLine();

                        Console.WriteLine("Please input Price.");
                        int Price = int.Parse(Console.ReadLine());


                        Console.WriteLine("Do you register this book?  [y/n]");
                        string reply = Console.ReadLine();

                        switch (reply)
                        {
                            case "y":
                                Book book1 = new Book(Title, Author, Price);
                                BookService service = new BookService();
                                service.RegisterBook(book1);

                                foreach (Book book in service.GetAllBooks())
                                {
                                    Console.WriteLine("<===book===>");
                                    Console.WriteLine(book.Title);
                                    Console.WriteLine(book.Author);
                                    Console.WriteLine(book.Price);
                                }

                                service = null;  //デストラクタの呼び出し

                                break;

                            case "n":

                                break;

                            default:
                                break;
                        }
                    }break;

                case 2: break;

                case 3: break;

                default: break;


            }
        }

      }

    class Book
    {
        public string Title;
        public string Author;
        public int Price;

        //constructor
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

        ~BookService(){
            Console.WriteLine("<デストラクタ>");
        }

        //Create
        public void RegisterBook(Book book)
        {
            BookDB list = new BookDB();
            booklist = list.GetBookList();

            // add
            booklist.Add(book);
            Console.WriteLine("test = " + booklist.Count);
        }

        //Remove


        //Check All Books
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
