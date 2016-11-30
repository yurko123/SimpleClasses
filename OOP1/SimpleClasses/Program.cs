using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    public class Customer
    {
        protected string Surname;
        protected string Name;
        protected string FatherName;
        protected string Adrress;
        protected string PhoneNumber;
        protected string NumCreditCard;
        protected string AdrressLive;
        protected double Cash;
        public Customer ()
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

        public Customer(string surname, string name, string fathername, string adrress, string phonenumber, string numcreditcard, string adrresslive, double cash)
        {
            Surname = surname;
            Name = name;
            FatherName = fathername;
            Adrress = adrress;
            PhoneNumber = phonenumber;
            NumCreditCard = numcreditcard;
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
            NumCreditCard = numcreditcard;
            AdrressLive = adrresslive;
            Cash = 0;
        }
        public bool ChangeAdrress(string adrress,string phonenumber)
        {
            if (PhoneNumber == phonenumber) { Adrress = adrress; return true; }
            else return false;
        }
        public void Change(string phonenumber, string oldphonenumber)
        {
           if(phonenumber==oldphonenumber) PhoneNumber = phonenumber;
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
            return NumCreditCard;
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
        public void ConsoleWrite()
        {
            Console.Write("Прізвище: {0}\nІм'я: {1}\nПо батькові: {2}\nАдреса: {3}\nТелефон: {4}\nНомер кредитної картки:{5}\nАдреса проживання: {6}\nЗагальна сума покупок: {7}",Surname, Name,FatherName,Adrress,PhoneNumber,NumCreditCard,AdrressLive,Cash);
        }

    }
    public class Student
    {
        protected string Surname;
        protected string Name;
        protected string FatherName;
        protected DateTime Birthday;
        protected string Adrress;
        protected string PhoneNumber;
        protected string Department;
        protected int Course;
        public Student()
        {
            Surname = "невідомо";
            Name = "невідомо";
            FatherName = "невідомо";
            Birthday = DateTime.Parse("01.01.1977");
            Adrress = "невідомо";
            PhoneNumber = "невідомо";
            Department = "невідомо";
            Course = 0;
        }
        public Student(string surname, string name, string fathername, string birthday, string adrress, string phonenumber, string department, int course)
        {
            Surname = surname;
            Name = name;
            FatherName = fathername;
            Birthday = DateTime.Parse("01.01.1977");
            Adrress = adrress;
            PhoneNumber =phonenumber;
            Department = department;
            Course = course;
        }
        public Student(string surname, string name, string fathername, string department, int course)
        {
            Surname = surname;
            Name = name;
            FatherName = fathername;
            Birthday = DateTime.Parse("01.01.1977");
            Adrress = "невідомо";
            PhoneNumber = "невідомо";
            Department = department;
            Course = course;
        }
        public string GetSurname()
        { return Surname; }
        public string GetName()
        { return Name; }
        public string GetFatherName()
        { return FatherName; }
        public DateTime GetBirthday()
        { return Birthday; }
        public string GetAdrress()
        {
            return Adrress;
        }
        }
    class Program
    {
        public static void ConsoleConfig(string title)
        {
            Console.Title = title;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.GetEncoding(1251); // може буть несумісність кодувань
            Console.InputEncoding = Encoding.GetEncoding(1251);
        }
        static void Main(string[] args)
        {
            ConsoleConfig("OOП 1");
            Customer a = new Customer();

            Console.ReadKey();
        }
    }
}
