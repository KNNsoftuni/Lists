namespace Bomb_Numbers
{
internal class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> bombData = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int bombNum = bombData[0];
        int power = bombData[1];

        DetonateBombNumbers(nums, bombNum, power);

        int sum = nums.Sum();
        Console.WriteLine(sum);
    }

    static void DetonateBombNumbers(List<int> nums, int bombNum, int power)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == bombNum)
            {
                int leftBoundary = Math.Max(0, i - power);
                int rightBoundary = Math.Min(nums.Count - 1, i + power);

                int elementsToRemove = rightBoundary - leftBoundary + 1;
                nums.RemoveRange(leftBoundary, elementsToRemove);

                i = Math.Max(-1, i - power - 1);
            }
        }
    }
}
}