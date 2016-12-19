using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses._Product
{
    class Product
    {
        protected string ProductName;
        protected string Manufacturer;
        protected double Price;
        protected int ShelfLife;
        protected int Quantity;
        protected DateTime ExpirationDate;
        public Product()
        {
            ProductName = "default";
            Manufacturer = "default";
            Price = 0;
            ShelfLife = 0;
            Quantity = 0;
            ExpirationDate = DateTime.Today;
        }
        public Product(string ProductName, string Manufacturer, double Price, int ShelfLife, int Quantity, DateTime ExpirationDate)
        {
            this.ProductName = ProductName;
            this.Manufacturer = Manufacturer;
            this.Price = Price;
            this.ShelfLife = ShelfLife;
            this.Quantity = Quantity;
            this.ExpirationDate = ExpirationDate;
        }
        public Product(string ProductName, double Price, int Quantity, DateTime ExpirationDate)
        {
            this.ProductName = ProductName;
            this.Manufacturer = "default";
            this.Price = Price;
            this.ShelfLife = 0;
            this.Quantity = Quantity;
            this.ExpirationDate = ExpirationDate;
        }
        public string GetProductName()
        {
            return ProductName;
        }
        public string GetManufacturer()
        {
            return Manufacturer;
        }
        public double GetPrice()
        {
            return Price;
        }
        public int GetShelfLife()
        {
            return ShelfLife;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public DateTime GetExpirationDate()
        {
            return ExpirationDate;
        }
        virtual public void ConsoleWrite()
        {
            Console.WriteLine("Найменування: {0}\nВиробник: {1}\nЦіна: {2}\nТермін зберігання: {3}\nКількість: {4}\nТермін придатності: {5}\n", ProductName, Manufacturer, Price, ShelfLife, Quantity, ExpirationDate);
        }
    }
}
