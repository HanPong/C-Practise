using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex01使用布尔运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //该例与书上略有不同，不可缺少Console，Convert等
            Console.WriteLine("Enter an integer:");
            int myInt =Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);

            Console.WriteLine($"Integer less than 10? {isLessThan10}");
            Console.WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Exactly one of the above is true? {isLessThan10 ^ isBetween0And5}");
            //^是异或操作，当两者一true一false时为True

            Console.ReadKey();
        }
    }
}
