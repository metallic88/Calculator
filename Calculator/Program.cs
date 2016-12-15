using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator\n");
            Console.Clear();
            Prog();
            Console.WriteLine("would you like to calculate 2 more numbers\nEnter y or n");
            Console.Write(">");
            string a = Console.ReadLine();
            a.ToLower();
            while (a == "y" || a == "yes")
            {
                Prog();
                Console.WriteLine("would you like to calculate 2 more numbers\nEnter y or n");
                Console.Write(">");
                a = Console.ReadLine();
                a.ToLower();
            }
            Environment.Exit(0);
        }

        public static void Prog()
        {
            int a;
            int b;
            int c;

            Console.Clear();
            Console.WriteLine("Select a # to Add, Subtract, Multiply, or Divide 2 Numbers.\n");
            Console.WriteLine("1.Add\n2.Subtract\n3.Multiply\n4.Divide\n");
            Console.Write(">");
            string d = Console.ReadLine();
            Int32.TryParse(d,out c);
            Console.Clear();
            if(c == 1)
            {
                Console.WriteLine("Enter the first # to be Added");
                Console.Write(">");
                string num1 = Console.ReadLine();
                Int32.TryParse(num1, out a);
                Console.WriteLine("Enter the second # to be Added");
                Console.Write(">");
                string num2 = Console.ReadLine();
                Int32.TryParse(num2, out b);
                Add(a,b);
            }
            if (c == 2)
            {
                Console.WriteLine("Enter the first # to be Subtracted");
                Console.Write(">");
                string num1 = Console.ReadLine();
                Int32.TryParse(num1, out a);
                Console.WriteLine("Enter the second # to be Subtracted");
                Console.Write(">");
                string num2 = Console.ReadLine();
                Int32.TryParse(num2, out b);
                Sub(a,b);
            }
            if (c == 3)
            {
                Console.WriteLine("Enter the first # to be Multiplyed");
                Console.Write(">");
                string num1 = Console.ReadLine();
                Int32.TryParse(num1, out a);
                Console.WriteLine("Enter the second # to be Multiplyed");
                Console.Write(">");
                string num2 = Console.ReadLine();
                Int32.TryParse(num2, out b);
                Multi(a,b);
            }
            if (c == 4)
            {
                Console.WriteLine("Enter the first # to be Divided");
                Console.Write(">");
                string num1 = Console.ReadLine();
                Int32.TryParse(num1, out a);
                Console.WriteLine("Enter the second # to be Divided");
                Console.Write(">");
                string num2 = Console.ReadLine();
                Int32.TryParse(num2, out b);

                while(b == 0)
                {
                    Console.WriteLine("Cannot devide buy zero\nEnter another #");
                    Console.Write(">");
                    string num3 = Console.ReadLine();
                    Int32.TryParse(num3, out b);
                }
                Div(a,b);
            }
        }

        public static void Add(int a, int b)
        {
            int c = a + b;
            Console.Clear();
            Console.Write("The Result Is\n");
            Console.Write(">");
            Console.WriteLine(c);
        }

        public static void Sub(int a, int b)
        {
            int c = a - b;
            Console.Clear();
            Console.Write("The Result Is\n");
            Console.Write(">");
            Console.WriteLine(c);
        }

        public static void Multi(int a, int b)
        {
            int c = a * b;
            Console.Clear();
            Console.Write("The Result Is\n");
            Console.Write(">");
            Console.WriteLine(c);
        }

        public static void Div(int a, int b)
        {
            int c = a / b;
            Console.Clear();
            Console.Write("The Result Is\n");
            Console.Write(">");
            Console.WriteLine(c);
        }
    }
}
