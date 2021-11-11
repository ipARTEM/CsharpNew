using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNew10part2
{
    internal class Class1
    {
        public int Property1 { get; set; }
        public int Property2 { get; set; }

        //(int x, int y) = point;

        // assignment:
        int x1 = 0;
        int y1 = 0;
        //(x1, y1) = point;

    }

    internal class Class2
    {
        void Method()
        {
            string? representation;
            if ((c != null) && c.GetDependentValue(out object obj)) == true)
{
                representation = obj.ToString(); // undesired error
            }

            // Or, using ?.
            if (c?.GetDependentValue(out object obj) == true)
            {
                representation = obj.ToString(); // undesired error
            }

            // Or, using ??
            if (c?.GetDependentValue(out object obj) ?? false)
            {
                representation = obj.ToString(); // undesired error
            }

        }

        public static void Validate(bool condition, [CallerArgumentExpression("condition")] string? message = null)
        {
            if (!condition)
            {
                throw new InvalidOperationException($"Argument failed validation: <{message}>");
            }
        }
    }




}
