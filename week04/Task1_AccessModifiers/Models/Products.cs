using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_AccessModifiers.Models
{
    public class Product
    {
        int _count;
        double _price;

        public double Price
        {
            set
            {
                if (value >= 0)
                {
                    this._price = value;
                }
                else
                {
                    Console.WriteLine("Price error.");
                }
            }
        }
        public Product(int Count, double Price)
        {
            this.Price = Price;
            this._count = Count;
        }
    }
    public class  NoteBook : Product
    {
        string _brand, _model;
        int _RAM;
        int _storage;

        public string Brand
        {
            set
            {
                if (value.Length > 2 && value.Length < 31)
                {
                    this._brand = value;
                }
                else
                {
                    Console.WriteLine("Brand error.");
                }
            }
        }
        public string Model
        {
            set
            {
                if (value.Length > 2 && value.Length < 31)
                {
                    this._model = value;
                }
            }
        }
        public int RAM
        {
            set
            {
                // if value is power of 2, which is more realistic for RAM
                // and no more than 128:
                if (value >= 0 && (value - 1 & value) == 0 && value <= 128)
                {
                    this._RAM = value;
                }
                else
                {
                    Console.WriteLine("RAM error.");
                }
            }
        }
        public int Storage
        {
            set
            {
                if (value >= 0)
                {
                    this._storage = value;
                }
                else
                {
                    Console.WriteLine("Storage error.");
                }
            }
        }
        public NoteBook(int Count, double Price, string Model) : base(Count, Price)
        {
            // model is must be, but brand is no??
            this.Model = Model;
        }

        public bool checker()
        {
            if (String.IsNullOrWhiteSpace(this._model)) return false;
            if (String.IsNullOrWhiteSpace(this._brand)) return false;
            // dose not matter if buyer get RAM or storage >:D
            // because 0 is acceptable even for price xD
            return true;
        }
    }
}
