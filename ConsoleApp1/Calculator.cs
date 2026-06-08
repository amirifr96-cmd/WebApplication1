using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Calculator
   {//متد جمع
        public int sum(int a,int b)
        {
            return a + b;
        }
        //متد تقسیم دو عدد
        public int multi(int a,int b)
        {
            return a * b;
        }
        //متد تقسیم 
        public int divide(int a, int b)
        {
            return a / b;
        }
        //متد سابتراک اضافه شد 
        public int subtract(int a, int b) 
        {
            Console.WriteLine($"[subtract] a={a},b={b}");
            checked { return a - b; }
        }
   }
}
