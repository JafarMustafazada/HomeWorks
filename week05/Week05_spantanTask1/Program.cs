using Week05_spantanTask1.Models;

namespace Week05_spantanTask1;

internal class Program
{
    static void Main(string[] args)
    {
        Library JafarsLib = new Library();

        Book temp = new Book
        {
            Price = 10,
            Name = "Qraf Monte Kristo",
            AuthorName = "Dunno",
            PageCount = 193,
            Count = 3,
        };
        JafarsLib.AddBook(temp);

        temp = new Book
        {
            Price = 10,
            Name = "How to become millionaire",
            AuthorName = "Jafar",
            PageCount = 3,
            Count = 70,
        };
        JafarsLib.AddBook(temp);

        JafarsLib.GetBookById(0).ShowInfo();
        Console.WriteLine("////////////////////////////");

        temp = JafarsLib.GetBookById(1);
        temp.ShowInfo();
        Console.WriteLine("////////////////////////////");

        temp.Sell();
        temp.ShowInfo();
    }
    
}