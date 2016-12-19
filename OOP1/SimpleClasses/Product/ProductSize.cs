using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses._Product
{
    class ProductSize : Product
    {

        protected double height;
        protected double width;
        protected double depth;
        public ProductSize()
            : base()
        {
            height = 0;
            width = 0;
            depth = 0;
        }
        public ProductSize(string ProductName, string Manufacturer, double Price, int ShelfLife, int Quantity, DateTime ExpirationDate, double height, double width, double depth)
            : base(ProductName, Manufacturer, Price, ShelfLife, Quantity, ExpirationDate)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
        }

        public double GetVolume
        {
            get { return height * width * depth; }
            set { height = Math.Pow(value, 1 / 3); width = height; depth = height; }
        }
        public double GetHeight()
        { return height; }
        public double GetWidth()
        { return width; }
        public double GetDepth()
        { return depth; }
        override public void ConsoleWrite()
        {
            Console.WriteLine("Найменування: {0}\nВиробник: {1}\nЦіна: {2}\nТермін зберігання: {3}\nКількість: {4}\nТермін придатності: {5}\nВисота: {6}\nШирина: {7}\nГлубина: {8}\n", ProductName, Manufacturer, Price, ShelfLife, Quantity, ExpirationDate, height, width, depth);
        }

    }


}
