using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {

        //public const double TAX = 0.2;
        public static double TAX = 0.2;
        public string name;
        public double wage;
        public double hours;


        public void DOPLUS(ref int age)
        { 
            age++; 
        }

        public void promote(double amount) 
        {
            Console.WriteLine(amount + "poro vip"  );        
        }

        public void promote(double amount , string trip)
        {
            Console.WriteLine(amount + "poro vip" + trip +"you have got a trip ");
        }
    }
}
