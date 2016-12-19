using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses._Customer
{
    public class CustomerCart: Customer
    {
        protected int orderingNum ;
        protected string product;
        public CustomerCart()
            : base()
        {
            orderingNum = 0;
            product = "noname";
        }
        public CustomerCart(string surname, string name, string fathername, string adrress, string phonenumber, string numcreditcard, string adrresslive, double cash, int orderingNum, string product)
            : base(surname, name, fathername, adrress, phonenumber, numcreditcard, adrresslive, cash)
        {
            this.orderingNum = orderingNum;
            this.product = product;
        }
        public int GetOrderingNum
        { get { return orderingNum;}}
        public override void ConsoleWrite()
        {
            Console.Write("Прізвище: {0}\nІм'я: {1}\nПо батькові: {2}\nАдреса: {3}\nТелефон: {4}\nНомер кредитної картки:{5}\nАдреса проживання: {6}\nЗагальна сума покупок: {7}\nНомер покупки: {8}\nТовар: {9}\n", Surname,Name, FatherName, Adrress, PhoneNumber, NumCreditCard, AdrressLive, Cash,orderingNum,product);
        }
        public string getProduct()
        { return product; }
        public void setNewCash (double price)
        {
            Cash = Cash + price;
        }
    }
}
