using System;
using System.Reflection.Metadata;
using System.Threading;
class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
}

class Program
{
    static void Main()
    {
        #region Q1
        Book book = new Book();
        book.Title = "C# Basics";
        book.Pages = 300;
        object obj = book;
        Console.WriteLine(obj);
        #endregion

        #region Q2
        Book book = new Book();
        book.Title = "C# Basics";
        book.Pages = 300;
        Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.GetType());
        #endregion

        #region Q3
        int pages = int.Parse("464");
        #endregion

        #region Q4
        int a = 10;
        int b = 0;
        int result = a / b;
        Console.WriteLine(result);
        ////                مش عارف اكمل السؤال
        #endregion


        #region Q5
        int pages = 300;
        double d = pages;
        Console.WriteLine(d);
        #endregion

        #region Q6
        double price = 49.99;
        int result = (int)price;
        Console.WriteLine(result);
        #endregion

        #region Q7
        string pagesText = "464";
        int pages = Convert.ToInt32(pagesText);
        Console.WriteLine(pages);
        #endregion

        #region Q8
        string yearText = "2023";
        int year = int.Parse(yearText);
        Console.WriteLine(year);
        string badText = "abc";
        if (int.TryParse(badText, out int result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
        #endregion

        #region Q9

        int pages = 464;
        string pagesText = pages.ToString();
        Console.WriteLine(pagesText);
        Console.WriteLine(pagesText.GetType());
        #endregion

        #region Q10
        int copies = 100;
        object boxed = copies;
        int unboxed = (int)boxed;
        Console.WriteLine(boxed);
        Console.WriteLine(unboxed);
        #endregion

    }
}