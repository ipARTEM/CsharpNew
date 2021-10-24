using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNew
{
    public static  class Test01
    {

        public static bool IsLetter(this char c) =>
        c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        public static bool IsLetterOrSeparator(this char c) =>
        c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';



        public static void TestNull(string str)
        {
            if (str is not null)
            {
                Console.WriteLine("Есть ссылка");
            }
            else
                Console.WriteLine($"str: {str}"); ;
        }
    }
}
