using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Calculator
   {
        public int sum(int a,int b)
        {
            return a + b;
        }
        public int multi(int a,int b)
        {
            return a * b;
        }
        public int divide(int a, int b)
        {
            return a / b;
        }
        public int subtract(int a, int b) 
        {
            Console.WriteLine($"[subtract] a={a},b={b}");
            checked { return a - b; }
        }
   }
}
