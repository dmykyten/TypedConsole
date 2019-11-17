using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dmykyt.Console.Input;

namespace Test
{
    class Program
    {
        public delegate int RoundDelegate(decimal arg);
        public static Func<String, decimal> ConvertDoSomething;

        static void Main(string[] args)
        {
            TypedConsole.read<int>(int.Parse);
            TypedConsole.read<int>(int.Parse,"amount of boxes");
            TypedConsole.read<int>();
        }

        static void DelegateExamples(string s)
        {
            ConvertDoSomething = (String som) => Decimal.Parse(som + ".01");

            ConvertDoSomething = Decimal.Parse;
            ConvertDoSomething = func;

            ConvertDoSomething("Hello");

            RoundDelegate rounder;
            rounder = RoundUp;
            rounder = Round;
            rounder = RoundUp;
            rounder = Round;

            Func<decimal, int> rounder2;
            rounder2 = RoundUp;
            rounder2((decimal)1.7);
            var a = rounder((decimal)1.2);

            Action<String> Print;
            Print = Console.WriteLine;
            Print("ss");

            int aaa;

            // TypedConsole<decimal>.read<int>();
        }

        static decimal func(string s)
        {
            Console.Write(s);
            return 15;
        }
        static int Round(decimal number)
        {
            return (int)Math.Round(number);
        }
        static int RoundUp(decimal number)
        {
            return (int)Math.Round(number + (decimal)0.5);
        }
    }
}