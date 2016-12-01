using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

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
                Console.Write("Прізвище: {0}\nІм'я: {1}\nПо батькові: {2}\nАдреса: {3}\nТелефон: {4}\nНомер кредитної картки:{5}\nАдреса проживання: {6}\nЗагальна сума покупок: {7}\n", Surname, Name, FatherName, Adrress, PhoneNumber, NumCreditCard, AdrressLive, Cash);
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
                PhoneNumber = phonenumber;
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
            public string GetPhoneNumber()
            {
                return PhoneNumber;
            }
            public string GetDepartament()
            {
                return Department;
            }
            public int GetCourse()
            {
                return Course;
            }
            public void SetSNF(string surname, string name, string fathername)
            {
                Surname = surname;
                Name = name;
                FatherName = fathername;
            }
            public void SetCourse(int course)
            {
                Course = course;
            }
        }
        public class Product
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

        }
        public class CustomerFile
        {
            protected Customer[] customers;
            public CustomerFile(string InputFile)
            {
                FileInfo f = new FileInfo(InputFile);
                if (f.Exists)
                {
                    string str = f.OpenText().ReadToEnd();
                    Regex regexp = new Regex(@"(\w+) (\w+) (\w+) ([a-zA-Z0-9-,.]+@[a-zA-Z0-9-,]+(\.[a-zA-Z0-9-,/&?=_]+)+) (\d+) (\d+) (\w+) (\d+,?\d*)");
                    MatchCollection match = regexp.Matches(str);
                    customers = new Customer[match.Count];
                    int i =0;
                    foreach (Match m in match)
                    {
                        
                        customers[i] = new Customer(m.Groups[1].Value, m.Groups[2].Value, m.Groups[3].Value, m.Groups[4].Value, m.Groups[6].Value, m.Groups[7].Value, m.Groups[8].Value, double.Parse(m.Groups[9].Value));
                        i++;
                    }

                }
                else Console.Write("неможливо відкрити файл");
            }

            public void ConsoleWriteCollection()
            {
                for (int i = 0; i < customers.Length; i++)
                    customers[i].ConsoleWrite();
            }
            public void SearchPhone(string phonenumber)
            { 
                for (int i = 0; i < customers.Length; i++)
                    if (customers[i].GetPhoneNumber() == phonenumber) customers[i].ConsoleWrite();
                  
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
                Customer yurko = new Customer("Polischuk", "Yurii", "Kostyantinovich", "0983778101", "1234567890123", "Chudniv");
                yurko.ConsoleWrite();
                Console.Write("Для зміни адреси введіть свій номер телефону :");
                string num = Console.ReadLine();
                Console.Write("Для зміни адреси введіть свою нову адресу :");
                string adr = Console.ReadLine();
                yurko.ChangeAdrress(adr, num);
                yurko.ConsoleWrite();
                Product apple = new Product("Apple", 6.75, 5, DateTime.Parse("12.12.2016"));
                Console.Write(apple.GetExpirationDate().ToString());
                // 
                CustomerFile coust = new CustomerFile("input.txt");
                coust.ConsoleWriteCollection();
                Console.Write("Введіть номер телефону того кого шукаєте");
                string phone = Console.ReadLine();
                coust.SearchPhone(phone);

                Console.ReadKey();
            }
        }
    }

