using System;
using System.Collections.Generic;

namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 1 };
            Console.WriteLine("Digite um numero para a quantidade da Sequência de Fibonacci: ");
            int amount = int.Parse(Console.ReadLine());

            while (list.Count < amount)
            {
                var previous = list[list.Count - 1];
                var previous2 = list[list.Count - 2];

                list.Add(previous + previous2);
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
