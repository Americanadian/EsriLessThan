namespace LessThan
{
    internal class Program
    {
    
        public static int getLessThanCount(int[] sortedArray, int lessThan)
        {
            try
            {
                if (sortedArray.Length == 0)
                    return 0;

                List<int> sortedList = sortedArray.ToList();

                for (int i = 0; i < sortedList.Count; i++)
                {
                    if (sortedList[i] >= lessThan)
                    {
                        sortedList.Remove(sortedList[i]);
                        i = i - 1;
                    }
                    else if (sortedList[i] == sortedList[i + 1])
                    {
                        sortedList.Remove(sortedList[i]);
                        i = i - 1;
                    }
                }

                return sortedList.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught the following Exception: " + e.Message);
                Console.ReadKey();
                return -1;
            }
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("The total count is: {0}", getLessThanCount(new int[] { 1, 2, 2, 3, 3, 4, 4, 4, 5}, 4));
            Console.ReadKey();
        }
    }
}