using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasics
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //TryingNullConditionalStatments();

        //    //TryingSwitchCases();

        //    int a=10;
        //   // TryingSwitchCasesWithUnReachableCaseStmts(a);

        //    TryingSwitchCasesWithUnReachableCaseStmts_v2(a);

        //}

        private static void TryingSwitchCasesWithUnReachableCaseStmts_v2(int a)
        {
            switch (a)
            {
                case int b when b < 2:
                    Console.WriteLine("this works too." + b); //No error here, as a 
                    break;
                case int x:
                    Console.WriteLine("This works as well");
                    break;
                //case int b when b > 2: Console.WriteLine("this works too."); //A compile time error: The switch case has already been handled by a previous case.
                //    break; 
                

            }
        }

        private static void TryingSwitchCasesWithUnReachableCaseStmts(object x)
        {
            ///In case there are case statements which are not reachable because of more generic case statements preceeding it, 
            ///the compiler will issue compile time error.
            
            switch (x) {
                //case object z:
                //    Console.WriteLine("This is just an object");        //This doesn't compile.
                //    break; 
                case int a: Console.WriteLine("This is int");
                    break;
                case string s: Console.WriteLine("This is string");
                    break;
                case object z: Console.WriteLine("This is just an object");         //This works because the case int executes before this.
                    break;  
            }
        }

        private static void TryingSwitchCases()
        {
            int a = 10;
            switch(a)
            {
                case 10: Console.WriteLine("Print 10");
                    break;
                case 11://the control flows to the next case statement.
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
