namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STACK : LIFO -Last In - First Out;
            //Stack<int> ints = new Stack<int>();
            //ints.Push(1);
            //ints.Push(2);
            //ints.Push(3);
            //Console.WriteLine("Top values in this Stack are {0}",ints.Peek());// vo ovoj del izlegvit brojot 3
            //// posleden vlegol ama prv izleguvat
            //int popped = ints.Pop();
            //Console.WriteLine("Popped value its {0}", popped);// pop go brisit taka da sekogas go brisit LIFO ili toj
            //                                                  // so posleden vlegol a izbrisan e kako prv
            //Console.WriteLine("Top values in this Stack are {0}", ints.Peek());// vo ovoj del izlegvit brojot 2 pso 3 e izbrisan
            //while (ints.Count > 0)
            //{
            //    Console.WriteLine("Popped are {0}",ints.Pop());
            //    Console.WriteLine("Current elements now are {0}",ints.Count);
            //}

            //vezba
          //  int[] nums = { 8, 5, 6, 2, 4, 1 };
            ////for (int i = nums.Length-1;i >= 0;i--)
            ////{
            ////    Console.WriteLine(nums[i]);
            ////}// ova e racno reverse na ovaa niza no ajde sega i so stack da se naprajt

            //Stack<int> stack = new Stack<int>();    
            //foreach (int x in nums)
            //{
                 
            //   stack.Push(x);
            //}
            ////Console.WriteLine("");
            //Console.WriteLine("Reverse nums");
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop() + " ");   
            //}

            // sme gi smestile vo stack so push celata niza po pravilo na LIFo posledniot da e prv
            // pa so proverka na while loop ako e pogolemo od 0 ili ako imat nesto vo nego gi printame!;

            //QUEUE :

            Queue<int> ints = new Queue<int>();// FIFo First in - First Out
            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Dequeue();
            Console.WriteLine("First in Queue is {0}",ints.Peek());


        }
    }
}