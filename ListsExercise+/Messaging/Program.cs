namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<char> text = Console.ReadLine()
                .ToCharArray()
                .ToList();

            string result = "";

            for (int i = 0; i < nums.Count; i++)
            {
                int currentNum = nums[i];
                char[] currentDigits = currentNum.ToString().ToCharArray();

                int sum = 0;

                for (int j = 0; j < currentDigits.Length; j++)
                {
                    sum += int.Parse(currentDigits[j].ToString());
                }

                int index = sum % text.Count;

                result += text[index];
                text.RemoveAt(index);
            }
            Console.WriteLine(result);
        }
    }
}