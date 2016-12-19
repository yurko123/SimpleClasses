using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using SimpleClasses._Customer;
using SimpleClasses._Student;
using SimpleClasses._Product;

namespace SimpleClasses
{
  
      
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
                ProductWeigth pw = new ProductWeigth("apple", "apple inc.", 12.34, 12, 12, DateTime.Parse("12.12.2016"), 12, 23, 34, 100);
                ProductSize a = new ProductSize("apple", "apple inc.", 12.34, 12, 12, DateTime.Parse("12.12.2016"), 12, 23, 34);
                a.ConsoleWrite();

                CustomerCart z = new CustomerCart();
                z.ConsoleWrite();
                CustomerCart a = new CustomerCart("pavlyuk", "vasya", "grigoryovich", "zhitomir", "vassya@vasya.com", "32342234234234", "zhitomir", 2343.23, 213243, "socks");
                a.setNewCash(200);
                a.ConsoleWrite();
                Customer yurko = new Customer ("Polischuk", "Yurii", "Kostyantinovich", "0983778101", "1234567890123", "Chudniv");
                yurko.CrashPhoneNum = "380983778101";
                yurko.ConsoleWrite();
                Console.WriteLine("{0} {1} {2} {3}",yurko.Surname,yurko.Name,yurko.FatherName,yurko.CashValue);// можна прочитать но неможна змінити 
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
                ProductWeigth pw = new ProductWeigth("apple", "apple inc.", 12.34, 12, 12, DateTime.Parse("12.12.2016"), 12, 23, 34, 100);
                ProductSize ap = new ProductSize("apple", "apple inc.", 12.34, 12, 12, DateTime.Parse("12.12.2016"), 12, 23, 34);
                ap.ConsoleWrite();

                Console.ReadKey();
            }
        }
    }

