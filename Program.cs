using System;
using System.Linq;

namespace LINQExample
{
    class Program
    {
        static string[] names = { "Chad", "Lexi", "Matthew", "Bubbles", "Frank", "Justin", "Reuben", "Mark"};

        static void Main(string[] args)
        {
            DisplayNamesThatStartWithM();
            OrderNames();
        }
        static void DisplayNamesThatStartWithM()
        {
            var selectedNames =
                from name in names
                where name[0] == 'M'
                select name;

            foreach(var name in selectedNames)
            {
                Console.WriteLine(name);
            }
        }//end DisplayNamesThatStartWithM.


        static void OrderNames()
        {
            var orderedNames =
                from name in names
                where name.Length > 5
                where name [4] == 'a'
                orderby name ascending
                select name;

            foreach(var name in orderedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
