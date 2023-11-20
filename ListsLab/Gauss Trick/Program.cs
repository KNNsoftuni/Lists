namespace Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            GaussTrick(nums);
            Console.WriteLine(string.Join(" ", nums));

        }

        static List<int> GaussTrick(List<int> nums)
        {
            int originalLength = nums.Count;
            for (int i = 0; i < originalLength/2; i++)
            {
                nums[i] += nums[nums.Count - 1];
                nums.RemoveAt(nums.Count - 1);
            }
            return (nums);
        }
    }
}