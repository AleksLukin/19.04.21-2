using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04._21_2
{
    public static class Program
    {
        public class TestCase
        {
            
            public int Expected { get; set; }
            public int NUMBER { get; set; }
            public int D { get; set; }
            //public Exception ExpectedException { get; set; }
        }

        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                NUMBER=4,
                Expected = 1,
                D = 1,
                //ExpectedException = null,
            };
            TestNumber(testCase1);
            var testCase2 = new TestCase()
            {
                NUMBER = 5,
                Expected = 1,
                D = 1,
                //ExpectedException = null,
            };
            TestNumber(testCase2);

        }
        static void TestNumber(TestCase testCase)
        {

                var actual = CheckNumber(testCase.D,testCase.NUMBER);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("действительный тест");
                }
                else
                {
                    Console.WriteLine("недействительный тест");
                }
        }



        static int CheckNumber(int number, int d)
        {
            number = int.Parse(Console.ReadLine());
            
            d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                else
                {
                    i++;
                }
                if (d == 0)
                {
                    Console.WriteLine(number + " - простое число");
                }
                else
                {
                    Console.WriteLine(number + " - непростое число");
                }
                break;
            }
            return d;
        }
    }
}
