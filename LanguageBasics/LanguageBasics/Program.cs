using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            TryingNullConditionalStatments();

            TryingSwitchCases();



        }

        private static void TryingSwitchCases()
        {
            int a = 10;
            switch(a)
            {
                case 10: Console.WriteLine("Print 10");
                    break;
                case 11:
                case 12: Console.WriteLine("Print 12");
                    break;
                default: Console.WriteLine("Print Default");
                    break;
            }
        }

        private static void TryingNullConditionalStatments()
        {
            StringBuilder sb = new StringBuilder();
            string str = null;

            //Elvis Operator or Null Conditional Operator [New Feature in C# 6.0]
            string s = sb?.ToString();

            //Null Coalescing Operator : Returns the right side value when the left side is null;
            str = str ?? "Honey I am not home";

            Console.WriteLine(str);
        }
    }
}
