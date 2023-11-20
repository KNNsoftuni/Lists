namespace Remove_negative_and_reverse
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            removeNegativesAndReverse(nums);
        }
        static void removeNegativesAndReverse(List<int> nums)
        {
            nums.RemoveAll(num => num < 0);

            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                nums.Reverse();
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}