using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses._Product
{
    class ProductWeigth:ProductSize
    {
        protected double weigth;
       
          public ProductWeigth() :base()
              {  weigth=0;}
          public ProductWeigth(string ProductName, string Manufacturer, double Price, int ShelfLife, int Quantity, DateTime ExpirationDate, double height, double width, double depth, double weigth)
              : base(ProductName, Manufacturer, Price, ShelfLife, Quantity, ExpirationDate, height, width, depth)
          {
              this.weigth = weigth;
          }
    
          public double Weigth
          {
              get
              { return weigth; }
              set
              { weigth = value; }
          }
          public double GetWeigth()
          { return weigth; }
          override public void ConsoleWrite()
          {
              Console.WriteLine("Найменування: {0}\nВиробник: {1}\nЦіна: {2}\nТермін зберігання: {3}\nКількість: {4}\nТермін придатності: {5}\nВисота: {6}\nШирина: {7}\nГлубина: {8}\nВага: {9}\n", ProductName, Manufacturer, Price, ShelfLife, Quantity, ExpirationDate, height, width, depth,weigth);
          }

    }
}

