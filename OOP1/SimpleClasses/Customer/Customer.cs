using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses._Customer
{
   public class Customer
    {

        public string Surname { get; protected set; }
        public string Name { get; protected set; }
        public string FatherName { get; protected set; }
        protected string Adrress;
        protected string PhoneNumber;
        protected string NumCreditCard;
        protected string AdrressLive;
        protected double Cash;
        public Customer()
        {
            Surname = "невідомо";
            Name = "невідомо";
            FatherName = "невідомо";
            Adrress = "невідомо";
            PhoneNumber = "невідомо";
            NumCreditCard = "невідомо";
            AdrressLive = "невідомо";
            Cash = 0;
        }
        protected string CreditCard
        {
            get { return NumCreditCard; }
            set { if (value.Length < 15) NumCreditCard = value; else NumCreditCard = "0000000000000"; }
        }
        public double CashValue
        { get { return Cash; } }
        public string CrashPhoneNum
        {
            set { if (value.Length < 15) PhoneNumber = value; }
        }

        public Customer(string surname, string name, string fathername, string adrress, string phonenumber, string numcreditcard, string adrresslive, double cash)
        {
            Surname = surname;
            Name = name;
            FatherName = fathername;
            Adrress = adrress;
            PhoneNumber = phonenumber;
            CreditCard = numcreditcard;
            AdrressLive = adrresslive;
            Cash = cash;
        }
        public Customer(string surname, string name, string fathername, string phonenumber, string numcreditcard, string adrresslive)
        {
            Surname = surname;
            Name = name;
            FatherName = fathername;
            Adrress = "невідомо";
            PhoneNumber = phonenumber;
            CreditCard = numcreditcard;
            AdrressLive = adrresslive;
            Cash = 0;
        }
        public bool ChangeAdrress(string adrress, string phonenumber)
        {
            if (phonenumber == PhoneNumber) { Adrress = adrress; return true; }
            else return false;
        }
        public void Change(string phonenumber, string oldphonenumber)
        {
            if (PhoneNumber == oldphonenumber) PhoneNumber = phonenumber;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public string GetFatherName()
        {
            return FatherName;
        }
        public string GetNumCreditCard()
        {
            return CreditCard;
        }
        public double GetCash(string phonenum)
        {
            return Cash;
        }
        public string GetAdrress()
        {
            return Adrress;
        }
        public string GetAdrressLive()
        {
            return AdrressLive;
        }
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public virtual  void ConsoleWrite()
        {
            Console.Write("Прізвище: {0}\nІм'я: {1}\nПо батькові: {2}\nАдреса: {3}\nТелефон: {4}\nНомер кредитної картки:{5}\nАдреса проживання: {6}\nЗагальна сума покупок: {7}\n", Surname, Name, FatherName, Adrress, PhoneNumber, NumCreditCard, AdrressLive, Cash);
        }
    }
}
