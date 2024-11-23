namespace TaskForOOP
{

    class Book
    {
        public string title;
        public string Aother;
        public string ISBN;
        public bool Availbilty;

        public Book(string title, string Aother, string ISBN, bool Availbilty = true)

        {
            this.title = title;
            this.Aother = Aother;
            this.ISBN = ISBN;
            this.Availbilty = Availbilty;
        }


        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return this.title;
        }


        public void setAouther(string aouther)
        {
            this.setAouther(aouther);
        }

        public string GetAuthor()
        {
            return this.Aother;
        }

        public void SetISBN(string _ISBN)
        {
            this.ISBN = _ISBN;
        }

        public string GetISBN()
        {
            return this.ISBN;
        }

        public void SetAaviabilty(bool Aaviabilty)
        {
            this.Availbilty = Aaviabilty;
        }


        public bool GetAviabilty()
        {
            return this.Availbilty;
        }


    }




    class Library
    {
        public List<Book> books;
        public Library()
        {
            books = new List<Book>();
        }


        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book SearchBookTitleOrAuthor(string titleOrAuthor)
        {
            foreach (Book book in books)
            {

                if (book.title == titleOrAuthor || book.Aother == titleOrAuthor)
                    return book;
               
            }
            return new Book("NA" , "NA" , "NA" , false);
        }  


        public void BorrowBook(string Brrowing)
        {
            foreach (Book book in books)
            {

                if(book.ISBN == Brrowing || book.title == Brrowing || book.Aother == Brrowing)
                    book.Availbilty = false;

            }
        }



        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            Console.WriteLine("\nReturning books...");
            //library.ReturnBook("Gatsby");
            //library.ReturnBook("Harry Potter"); // This book is not borrowed

            Console.ReadLine();

        }
    }
}
