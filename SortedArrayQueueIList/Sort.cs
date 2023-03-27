namespace SortedArrayQueueStackIList
{
    internal class Sort
    {
        static void Main(string[] args)
        {
            //Sort Array
            int[] arr = { 3, 1, 4, 2 };
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + ", ");



            //Sort Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(4);
            queue.Enqueue(2);

            int[] array = queue.ToArray();
            Array.Sort(array);
            queue = new Queue<int>(array);
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + ", ");


            //Sort IList
            IList<int> list = new List<int> { 3, 1, 4, 2 };
            ((List<int>)list).Sort();
            foreach(int i in list)
                Console.Write(i + ", ");


            //Sort Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(1);
            stack.Push(4);
            stack.Push(2);

            int[] array1 = stack.ToArray();
            Array.Sort(array);
            stack = new Stack<int>(array1);
            for(int i = 0; i < array1.Length; i++)
                Console.WriteLine(array1[i]);

        }
    }
}