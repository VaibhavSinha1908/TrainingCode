using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasics
{
 public class Namespaces
    {
      public class A
        {
            public class B {
                public int c;
            };

        }

        static void Main()
        {
            global::A.B obj1 = new global::A.B();  //note the global keyword and it's usage.
            A.B obj = new A.B();
            Console.WriteLine(obj is A.B);
            LanguageBasics.A.B obj2 = new LanguageBasics.A.B();
            obj2.a = 20;
        }
    }

   namespace A {
        public class B {
            public int a;
        };
    }
}

namespace A {
        public class B {
        public int b;
    };
    }

