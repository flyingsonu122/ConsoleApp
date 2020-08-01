using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string myName = "Sonu kumar kushwaha";
            int myAge = 19;
            Console.WriteLine("Hello " + myName +  "!\nYou are " + myAge + " Years old.");
            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName.Length);
            Console.WriteLine(myAge + 10);
            Console.WriteLine(5 * 2);
            Console.WriteLine(5 % 2);

            Console.ReadLine(); 
        }
    }
}
