using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class the_delegate
    {

        public delegate void WelcomeFunctionDelegate(string name);

        public void WelcomeFunction(string message)
        {
            Console.WriteLine($"{"hi"} {message}");
        }

    }
}
//the_delegate obj1 = new the_delegate();
//WelcomeFunctionDelegate objdel = new WelcomeFunctionDelegate(obj1.WelcomeFunction);
//objdel("mohamed");
