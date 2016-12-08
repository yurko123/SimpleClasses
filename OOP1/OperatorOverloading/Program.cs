using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Fraction
    {
        protected bool sing;
        protected int intPart;
        protected int numcator;
        protected int denominator;
        public Fraction()
        {
            sing = true;
            intPart = 0;
            numcator = 0;
            denominator = 1;
        }
        public Fraction(Fraction a)
        {
            sing = a.sing;
            intPart = a.intPart;
            numcator = a.numcator;
            denominator = a.denominator;
        }
        public Fraction(int intPart)
        {
            sing = true;
            this.intPart = intPart;
            numcator = 0;
            denominator = 1;
        }
        public Fraction(int numcator, int denominator)
        {
            sing = true;
            intPart = 0;
            this.numcator = numcator;
            this.denominator = denominator;
        }
        public Fraction(int intPart, int numcator, int denominator)
        {
            sing = true;
            this.intPart = intPart;
            this.numcator = numcator;
            this.denominator = denominator;
        }
        public Fraction(bool sing, int numcator, int denominator)
        {
            this.sing = sing;
            intPart = 0;
            this.numcator = numcator;
            this.denominator = denominator;
        }
        public Fraction(bool sing, int intPart, int numcator, int denominator)
        {
            this.sing = sing;
            this.intPart = intPart;
            this.numcator = numcator;
            this.denominator = denominator;
        }
        protected int NSD(int a, int b)
        {
            if (b == 0) return a;
            else
                return NSD(b, a % b);
        }
        public void reduce()
        {
            int Nsd = NSD(numcator, denominator);
            numcator /= Nsd; denominator /= Nsd;

        }// скорочення
        public char GetSing()
        {
            if (sing == true) return ' ';
            else return '-';
        }// отримати знак символом
        public string ToString()
        { return String.Concat(GetSing(), intPart + " " + numcator + "/" + denominator); }
        protected int GetSingNum()
        { return (sing) ? 1 : -1; }
        public double GetDouble()
        {
            double res = intPart;
            res += (double)numcator / denominator;
            if (sing == false) res *= -1.0;
            return res;
        }
        public void GetIntPart()
        {
            if (numcator >= denominator)
            {
                intPart += numcator / denominator;
                numcator %= denominator;
            }
        }
        public void SetFractionVaule()
        {
            numcator += intPart * denominator;
            intPart = 0;
        }// перетворити цілу частину в дробову
        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction res = new Fraction();

            res.numcator = a.GetSingNum() * a.numcator * b.denominator + b.GetSingNum() * b.numcator * a.denominator;
            res.denominator = a.denominator * b.denominator;
            res.GetIntPart();
            res.intPart += a.intPart + b.intPart;
            res.reduce();

            if (res.numcator < 0)
            {
                res.numcator *= -1;
                res.sing = false;
            }
            res.GetIntPart();
            return res;

        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            b.sing = !(b.sing);
            res = a + b;
            return res;
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            a.SetFractionVaule();
            b.SetFractionVaule();
            res.numcator = a.numcator * b.numcator;
            res.denominator = a.denominator * b.denominator;
            if (a.sing != b.sing) res.sing = false;
            res.reduce();
            res.GetIntPart();
            return res;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction res = new Fraction(b);
            res.SetFractionVaule();
            a.SetFractionVaule();
            int temp = res.numcator;
            res.numcator = res.denominator;
            res.denominator = temp;

            
            res = a * res;
            return res;
        }
        public static bool operator <(Fraction a, Fraction b)
        {

            if (a.GetDouble() < b.GetDouble()) return true;
            return false;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            if (b<a) return true;
            return false;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            if (a.GetDouble() <= b.GetDouble()) return true;
            return false;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            if (a.GetDouble() >= b.GetDouble()) return true;
            return false;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (Math.Round(a.GetDouble(),5) == Math.Round(b.GetDouble(),5)) return true;
            return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (!(a == b)) return true;
            else return false;
        }
        public static Fraction operator ++(Fraction a)
        {
            Fraction res = new Fraction(a);
            if (res.sing) res.intPart++;
            else res.intPart--; 
            return res;
        }//інкремент
        public static Fraction operator --(Fraction a)
        {
            Fraction res = new Fraction(a);
            if (res.sing) res.intPart--;
            else res.intPart++;
            return res;
        }// декримент
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(1,1,3);
            Fraction b = new Fraction(1,3);
            Console.WriteLine("a="+a.ToString()+" b="+ b.ToString());
           
            Fraction c = new Fraction();
            c = a + b;
            Console.WriteLine("a+b="+c.ToString());
            c=a-b;
            Console.WriteLine("a-b="+c.ToString());
            c = a * b;
            Console.WriteLine("a*b=" + c.ToString());
            c = a / b;
            Console.WriteLine("a/b=" + c.ToString());
            c++;
            Console.WriteLine("c++=" + c.ToString());
            if (a==b) Console.WriteLine("a==b");
            if (a != b) Console.WriteLine("a!=b");
            if (a <= b) Console.WriteLine("a<=b");
            if (a >= b) Console.WriteLine("a>=b");
            if (a < b) Console.WriteLine("a<b");
            if (a > b) Console.WriteLine("a>b");
            Console.WriteLine("a->Double= " + a.GetDouble());

            Console.ReadKey();
        }
    }
}
// to be continued...