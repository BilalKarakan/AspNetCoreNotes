using System;

namespace Delegates
{
    delegate void MyDelegate(int number1, int number2);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Sum);
            myDelegate += Multiplication;
            myDelegate.Invoke(1, 2);

        }

        static void Sum(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        static void Multiplication(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }
    }
}
