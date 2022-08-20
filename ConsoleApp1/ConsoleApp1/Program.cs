using ConsoleApp1;
using System;
using static ConsoleApp1.the_delegate;



internal class Program
{

    static void Main(string[] args)
    {
        //Console.WriteLine("Enter the name ");
        //String UserName = Console.ReadLine();
        //Console.WriteLine("hi " + UserName);
        //Console.WriteLine("hi {0}" , UserName);//place holder syntax {0} , {1}  ....


        ////data types 
        //bool a = true;
        //bool b = false;
        //int c = 50;
        //String name = "\"zaglol\"";

        //var x = 10;
        //var y = 20;
        //var z = x >= y ? 1 : 2;
        //Console.WriteLine (z);

        //string[] friends = new string[5] ;
        //friends[0] = "mo";
        //friends[1] = "moo";
        //friends[2] = "mooo";
        //friends[3] = "moooo";
        //friends[4] = "mooooo";

        //var slice1 = friends[..2];
        //foreach (var item in slice1)
        //{
        //    Console.WriteLine(item);
        //}


        //int[,] multidimintion =
        //{
        //    {1,2,3,4,5 },
        //    {1,2,3,4,5 },
        //    {1,2,3,4,5 },
        //    {1,2,3,4,5 }

        //};

        //var Jagged = new int[][] 
        //{

        //  new int[] {1},
        //  new int[] {1,2,3},
        //  new int[] {1,2}

        //int counter = 0;
        //while(counter < 10) 
        //{
        //    Console.WriteLine(counter);
        //    counter++;
        //}

        //for (int i = 0; i < args.Length; i++) 
        //{
        //    Console.WriteLine(args[i]);
        //}

        //for (int i = 0; i < 10; i++) 
        //{
        //    if (i % 2 == 0)
        //        continue;//not !
        //    Console.WriteLine(i);

        //}

        // implevit type changing from big to small
        //int noint = 10;
        //long nolo = noint;


        //EXPLECIT CASTIING from small to big
        //long nolo = 500;
        //int noint = (int)nolo;

        //int x = 10;//data type
        //object obj;//ref type 
        //obj = x;//conversion done implicitly (bosing)
        //int y = (int)obj;//unboxing

        //string s1 = "100";
        //if(int.TryParse(s1, out int result)) 
        //{
        //    Console.WriteLine(result);
        //}
        //else { Console.WriteLine("error")}

        //string s1 = "mohamed";
        //char[] letters = s1.ToCharArray();
        //foreach (char c in letters) 
        //{
        //    int asci =  Convert.ToInt32(c);
        //    Console.WriteLine(asci);
        //}



        //string[] hexvalue = { "34", "2f", "3a", "10" };
        //foreach (string hex in hexvalue) 
        //{
        //    int value = Convert.ToInt32(hex,16);
        //    var stringvalue = char.ConvertFromUtf32(value);
        //    Console.WriteLine(stringvalue); 
        //}

        //var hex = "2Adc";
        //int no = Int32.Parse(hex,System.Globalization.NumberStyles.HexNumber);
        //Console.WriteLine(no);

        //const double TAX = 0.2;
        //Console.WriteLine( "enter  name");
        //var n1 = Console.ReadLine();
        //Console.WriteLine("enter  wage");
        //var w = double.Parse(Console.ReadLine());
        //var t = double.Parse(Console.ReadLine());
        //var s = w * t *TAX;
        //Console.WriteLine(n1+s );

        //Employee[] emp = new Employee[1];
        //Employee e1 = new Employee();
        //Console.WriteLine("enter  name");
        //e1.name = Console.ReadLine();

        //Console.WriteLine("enter  wage");
        //e1.wage=Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("enter  wage");
        //e1.hours = Convert.ToDouble(Console.ReadLine());


        //Console.WriteLine("enter tax");
        //Employee.TAX=Convert.ToDouble(Console.ReadLine());

        //emp[0] = e1;

        //foreach (var e in emp)
        //{
        //    var salary = e1.wage * e1.hours * Employee.TAX;
        //    Console.WriteLine(e1.name + salary);
        //}

        //Employee e1 = new Employee();
        //var age = 10;
        //e1.DOPLUS(ref age);
        //Console.WriteLine(age);

        //string numstring = "1234";
        //int num;
        //if (int.TryParse(numstring, out num)) 
        //{
        //    Console.WriteLine("vaild");
        //}

        //Employee employee = new Employee();
        //employee.promote(10);

        //Ctor o1 = new Ctor(10);
        //o1.setnumber(5);


        //string str = "hello";
        //var x = str[0];//indexer
        //indexer ip1 = new indexer(192, 168, 1, 1);
        //Console.WriteLine(ip1.adress());
        //var firstseg = ip1[0];
        //Console.WriteLine(firstseg);

        //the_delegate obj1 = new the_delegate();
        //WelcomeFunctionDelegate objdel = new WelcomeFunctionDelegate(obj1.WelcomeFunction);
        //objdel("mohamed");

        //    var Event_stock = new Event_stock("amazon");
        //    Event_stock.Price = 90;
        //    Event_stock.OnPriceChanged += Event_stock_OnPriceChanged;
        //    Event_stock.changestokPrice(10);
        //    Event_stock.changestokPrice(1);
        //    Event_stock.changestokPrice(-10);


        Money m1 = new Money(50);
        Money m2 = new Money(60);
        Money m3 = m1 + m2;
        Console.WriteLine(m3.Amount );







    }

    //private static void Event_stock_OnPriceChanged(Event_stock thestock, decimal oldprice)
    //{
    //    if(oldprice < thestock.Price) 
    //    {
    //       Console.ForegroundColor= ConsoleColor.Green;
    //       Console.WriteLine($"{thestock.Name} price is {thestock.Price}");
    //    }
    //    else if(oldprice > thestock.Price) 
    //    {
    //        Console.ForegroundColor = ConsoleColor.Red;
    //        Console.WriteLine($"{thestock.Name} price is {thestock.Price}");
    //    }
    //    else 
    //    {
    //        Console.ForegroundColor = ConsoleColor.Gray ;
    //        Console.WriteLine($"{thestock.Name} price is {thestock.Price}");
    //    }
    //}
}