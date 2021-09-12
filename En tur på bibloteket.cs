using System;

namespace En_tur_på_Bibloteket
{

    class BookList
    {

        public string Name;
        public double Number_Of_Pages;
        public string Author_Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public double number_of_pages
        {
            get { return Number_Of_Pages; }
            set { Number_Of_Pages = value; }
        }

        public string author_name
        {
            get { return Author_Name; }
            set { Author_Name = value; }
        }




    }

    class Program
    {
        static void Main(string[] args)
        {

            BookList book1 = new BookList();
            {
                book1.name = "Harry Potter";
                book1.number_of_pages = 377;
                book1.author_name = "J.K Rowling";
            }

            BookList book2 = new BookList();
            {
                book2.name = "Lord of the rings";
                book2.number_of_pages = 568;
                book2.author_name = "J.R.R. Tolkien";
            }

            BookList book3 = new BookList();
            {
                book3.name = "Alice's Adventures in Wonderland";
                book3.number_of_pages = 241;
                book3.author_name = "Lewis Carroll";
            }

        }
    }
}
