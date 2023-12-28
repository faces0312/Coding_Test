//Practice
using System;

namespace Test_Prepare_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            
            int sum = int.Parse(str[0]) + int.Parse(str[1]);

            Console.WriteLine(sum);
        }
    }
}