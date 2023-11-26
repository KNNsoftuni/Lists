namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double racerOneTime = 0;
            double racerTwoTime = 0;

            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Calculate(racerOneTime, racerTwoTime, nums);
        }

        static void Calculate(double racerOneTime, double racerTwoTime, List<int> nums)
        {
            for (int i = 0; i < nums.Count / 2; i++)
            {
                if (nums[i] == 0)
                {
                    racerOneTime *= 0.8;
                }
                if (nums[nums.Count - 1 - i] == 0)
                {
                    racerTwoTime *= 0.8;
                }

                racerOneTime += nums[i];
                racerTwoTime += nums[nums.Count - 1 - i];
            }

            if (racerOneTime < racerTwoTime && Math.Floor(racerOneTime) == racerOneTime)
            {
                Console.WriteLine($"The winner is left with total time: {racerOneTime}");
            }
            if (racerOneTime < racerTwoTime && Math.Floor(racerOneTime) != racerOneTime)
            {
                Console.WriteLine($"The winner is left with total time: {racerOneTime:F1}");
            }
            if (racerOneTime > racerTwoTime && Math.Floor(racerTwoTime) != racerTwoTime)
            {
                Console.WriteLine($"The winner is right with total time: {racerTwoTime:F1}");
            }
            if (racerOneTime > racerTwoTime && Math.Floor(racerTwoTime) == racerTwoTime)
            {
                Console.WriteLine($"The winner is right with total time: {racerTwoTime}");
            }
        }
    }
}