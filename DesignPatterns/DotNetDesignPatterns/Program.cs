using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDesignPatternsPredicate
{
    public class Program
    {
        public static int GetTotal(int[] numbers, Predicate<int> selector) 
        { 
            int total = 0; 
            foreach (int n in numbers) 
            { 
                if (selector(n)) 
                { 
                    total += n; 
                } 
            } 
            return total; 
        }
        public static void Main(string[] args) 
        { 
            Console.WriteLine("Sum of all numbers in { 1, 2, 3, 4, 5, 6 } is : "+GetTotal(new[] { 1, 2, 3, 4, 5, 6 }, i => true)); 
            Console.WriteLine("Sum of even numbers in { 1, 2, 3, 4, 5, 6 } is : "+GetTotal(new[] { 1, 2, 3, 4, 5, 6 }, i => i % 2 == 0)); 
            Console.WriteLine("Sum of odd numbers in { 1, 2, 3, 4, 5, 6 } is : "+GetTotal(new[] { 1, 2, 3, 4, 5, 6 }, i => i % 2 != 0)); 
            Console.Read(); 
        }
    }
}
