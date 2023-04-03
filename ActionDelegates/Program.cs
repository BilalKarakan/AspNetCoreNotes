using System;

namespace ActionDelegates
{
    internal class Program
    {
        // func, action, predicate
        static void Main(string[] args)
        {
            //Action action = new Action(Greeting);
            Action action = new Action(() =>
            {
                Console.WriteLine("Hello World.");
            });
            action.Invoke();

            //Action<string> action2 = new Action<string>(Greeting2);
            //action2 += Greeting3;
            //action2.Invoke("Bilal");

            Action<string> action2 = new Action<string>(name =>
            {
                Console.WriteLine("Hello " + name );
            });
            action2.Invoke("Bilal");


        }

        //private static void Greeting()
        //{
        //    Console.WriteLine("Hello Bilal");
        //}

        //private static void Greeting2(string name)
        //{
        //    Console.WriteLine($"Hello My Name is {name}.");
        //}

        //private static void Greeting3(string name)
        //{
        //    Console.WriteLine($"Hello {name}. How are you today?");
        //}
    }
}
