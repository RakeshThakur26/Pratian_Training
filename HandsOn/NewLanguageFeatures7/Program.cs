using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NewLanguageFeatures6;

namespace NewLanguageFeatures7
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> addOne = n => n + 1;
            Console.WriteLine("Result: {0}", addOne(5));

            Expression<Func<int, int>> addOneExpression = n => n + 1;
            var addOneFunc = addOneExpression.Compile();
            Console.WriteLine("Result: {0}", addOneFunc(5));
            Console.Read();

        }
    }
}
