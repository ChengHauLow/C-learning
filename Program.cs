using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace LearnC_
{
    class Car
    {
        public string color = "red";
        public string model;
        string regNum = "123ABC";
        public string RegNum
        { get { return regNum; }
          set { regNum = value; }
        }
        public Car(string modelName)
        {
            model = modelName;
        }
        public string getColor()
        {
            return $"My {model} is {color}";
        }
    }
    internal class Program
    {
        static readonly int myNum = 8;
        static readonly long myAccountMoney = 9223372036854775807;
        static readonly ulong myAccountMoneyExpected = 9223372036854775808;
        static public string myName = "CH Low";
        static public string myChar = "";
        static public char singleChar = 'A';
        
        static void Main()
        {
            Car myCar = new Car("Volkswagen Golf 1.4 TSI");
            Console.WriteLine(myCar.color);
            Console.WriteLine(myCar.getColor());
            Console.WriteLine(myCar.RegNum);
            myCar.RegNum = "456DEF";
            Console.WriteLine(myCar.RegNum);
            Greet($"{myName} - {myNum}");
            Greet();
            myChar = $"{Console.ReadKey().Key}";
            if(myChar != null)
            {
                singleChar = Convert.ToChar(myChar);
            }
            Console.WriteLine("----------------");
            Console.WriteLine(singleChar);
            if(singleChar == 'Q')
            {
                Console.WriteLine("3Q");
            }
            else if(singleChar == 'E')
            {
                Console.WriteLine($"I wish I have {myAccountMoneyExpected}");
            }
            else if (singleChar == 'M')
            {
                Console.WriteLine($"I have {myAccountMoney}");
            }
            else 
            { 
                Console.WriteLine("Thank You");
            }
            int myNum1 = PlusMethod(8, 5);
            decimal myNum2 = (decimal) PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
        static void Greet(string args="")
        {
            if (args != "") 
            {
                Console.WriteLine($"Hello {args}");
            }
            else 
            {
                Console.WriteLine("Hello World");
            }
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}
