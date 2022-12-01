using System.Text;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Enumerable.Range(1, 1024).ToArray();
            int item = 5;
            StringBuilder sb = new($"Number {item} in collection of" +
                            $" {array.Length} items has an index" +
                            $" of {BinarySearch(item, array)}");
            Console.WriteLine(sb.ToString());
        }
        static int? BinarySearch(int item, params int[] array)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = array[mid];
                if (guess == item)
                {
                    return mid;
                }
                if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return null;
        }
    }
}