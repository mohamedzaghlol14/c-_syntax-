using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ctor
    {
        //backing
        private int _number;
        public Ctor(int number)
        {
            if (number > 0)
            {
                this._number = number;
                Console.WriteLine($"{"the no is true "}  {_number}");
            }
            else
            {
                this._number = 0;
                Console.WriteLine($"{"wrong no ***"}  {_number}");
            }

        } 

        public decimal number 
        {
            get 
            {
                return this._number;
            }
             private set 
            {
                if(value < 0)
                {
                    this._number = 1;
                    Console.WriteLine(number);
                }
                else 
                {
                    this._number = (int)value;
                    Console.WriteLine(number);

                }

            }
        }

        public void setnumber(decimal value) 
        {
            number = value;
        }

        


        //public class Date
        //{
        //    private static readonly int[] dayToMonth365 = { 0, 31, 28, 30, 31, 30, 31, 30, 31, 30, 31, 30, 31 };
        //    private static readonly int[] dayToMonth366 = { 0, 31, 29, 30, 31, 30, 31, 30, 31, 30, 31, 30, 31 };

        //    private int year;
        //    private int month;
        //    private int day;

        //    //constructor to make intializaton 
        //    public Date(int year, int month, int day)
        //    {
        //        var iskapesa = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        //        if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
        //        {
        //            int[] days = iskapesa ? dayToMonth366 : dayToMonth365;
        //            if (day >= 1 && day <= days[month])
        //            {
        //                this.year = year;
        //                this.month = month;
        //                this.day = day;

        //            }
        //            else
        //            {
        //                this.year = 0001;
        //                this.month = 01;
        //                this.day = 01;
        //            }
        //        }
        //        else
        //        {
        //            this.year = 0001;
        //            this.month = 01;
        //            this.day = 01;
        //        }

        //    }

        //    //constructure overloading
        //    public Date(int year) : this(01, 01, year)
        //    {

        //    }

        //    public string Getdate()
        //    {
        //        return $"{this.day.ToString().PadLeft(2, '0')} /{this.month.ToString().PadLeft(2, '0')} / {this.year.ToString().PadLeft(4, '0')}";
        //        //return Day.ToString().PadLeft(2, '0'); Month.ToString().PadLeft(2, '0'); Year.ToString().PadLeft(2, '0');
        //    }

        //    //public void Setvalue(int day , int month , int year) 
        //    //{
        //    //    this.Day = day;
        //    //    this.Month = month; 
        //    //    this.Year = year;
        //    //}

       
    }
}
