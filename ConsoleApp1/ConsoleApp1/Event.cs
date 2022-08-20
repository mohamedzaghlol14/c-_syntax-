using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Event_stock
    {

        private string name;
        private decimal price;

        public delegate void EventHandler(Event_stock thestock, decimal oldprice);
        public event EventHandler OnPriceChanged;

        public string Name 
        {
            get { return name; } 
        }
        public decimal Price 
        {
            get { return price; }
            set { price = value; }
        }

        public Event_stock(string stockname)
        {
          this.name = stockname;
        }
        
        public void changestokPrice(decimal no) 
        {

            decimal oldprice=this.price;
            this.price = Math.Round(price * no);

            if (OnPriceChanged != null) 
            {
              OnPriceChanged(this, oldprice);//fireing event
            }

        }



    }
}
//Event_stock.OnPriceChanged += Event_stock_OnPriceChanged;//SUBSCRIPE
//Event_stock.OnPriceChanged -= Event_stock_OnPriceChanged;//UNSUBSCRIPE

//var Event_stock = new Event_stock("amazon");
//Event_stock.Price = 90;
//Event_stock.OnPriceChanged += Event_stock_OnPriceChanged;
//Event_stock.changestokPrice(10);
//Event_stock.changestokPrice(1);
//Event_stock.changestokPrice(-10);


//    }

//    private static void Event_stock_OnPriceChanged(Event_stock thestock, decimal oldprice)
//{
//    if (oldprice < thestock.Price)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"{thestock.Name} price is {thestock.Price}");
//    }
//    else if (oldprice > thestock.Price)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine($"{thestock.Name} price is {thestock.Price}");
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Gray;
//        Console.WriteLine($"{thestock.Name} price is {thestock.Price}");
//    }
//}