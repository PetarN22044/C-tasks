using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Getting
    {

        public static void SumCollection(IEnumerable<int> anyCollection)
        {
            int sum = 0; 
            foreach (int item in anyCollection)
            {
                sum += item;
            }

            Console.WriteLine("The sum is {0}",sum);
        }
    public static IEnumerable<int> GetNumber (int option)
        {
            List<int> result = new List<int>() { 1,2,3,4,5};

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);

            if (option == 1)
            {
                return result;
            }else if (option == 2)
            {
                return queue;
            }
            else
            {
                return new List<int>() { 11, 12, 13, 14, 15 };
            }
        }

    }
}
