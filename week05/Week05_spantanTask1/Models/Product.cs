using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_spantanTask1.Models;

public abstract class Product
{
    static int UniqueId = 0;
    int _productId, _count;
    float _price;
    string _name;

    public Product()
    {
        this._productId = Product.UniqueId++;
    }

    public double TotalIncome { get; protected set; }
    public int Id { get => this._productId; }
    public string Name { get => this._name; set { this._name = value; } }
    public float Price { get => this._price; set { this._price = value; } }
    public int Count { get => this._count; set { this._count = value; } }


    public abstract void Sell();
    public abstract void ShowInfo();
}

public class Book : Product
{
    string _authorName;
    int _pageCount;

    public string AuthorName { get; set; }
    public int PageCount { get; set; }


    public override void Sell()
    {
        if (this.Count > 0)
        {
            this.Count--;
            this.TotalIncome += this.Price;
        }
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Id: " + this.Id);
        Console.WriteLine("Book's name: " + this.Name);
        Console.WriteLine("Author's name: " + this.AuthorName);
        Console.WriteLine("Page count: " + this.PageCount);
        Console.WriteLine("Amount: " + this.Count);
        Console.WriteLine("Price: " + this.Price);
        Console.WriteLine("Income till now: " + this.TotalIncome);
    }
}

public class Library
{
    Book[] arr = new Book[0];

    public int HowManyBooks { get => arr.Length; }
    public void AddBook(Book book)
    {
        Book[] NewArr = new Book[arr.Length + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            NewArr[i] = arr[i];
        }

        NewArr[arr.Length] = book;
        arr = NewArr;
    }
    public Book GetBookById(int id)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Id == id) return arr[i];
        }
        return null;
    }
}

