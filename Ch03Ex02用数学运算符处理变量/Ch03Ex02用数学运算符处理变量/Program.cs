using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex02用数学运算符处理变量
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name:");//在控制台上显示字符
            userName = Console.ReadLine();//读取输入到控制台上的字符
            Console.WriteLine($"Welcome {userName}!");
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " + $"{firstNumber + secondNumber}.");
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} " + $"is {firstNumber * secondNumber}.");
            Console.ReadKey();
        }
    }
}
