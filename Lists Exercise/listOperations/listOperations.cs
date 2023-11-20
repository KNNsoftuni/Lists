namespace listOperations
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commandArgs[1]);
                        Add(nums, numberToAdd);
                        break;

                    case "Remove":
                        int indexToRemove = int.Parse(commandArgs[1]);
                        Remove(nums, indexToRemove);
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(commandArgs[1]);
                        int indexToInsert = int.Parse(commandArgs[2]);
                        Insert(nums, numberToInsert, indexToInsert);
                        break;

                    case "Shift":
                        string direction = commandArgs[1];
                        int count = int.Parse(commandArgs[2]);
                        ShiftNumbers(nums, direction, count);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        static void Add(List<int> nums, int number)
        {
            nums.Add(number);
        }

        static void Insert(List<int> nums, int number, int index)
        {
            if (index >= 0 && index <= nums.Count)
            {
                nums.Insert(index, number);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void Remove(List<int> nums, int index)
        {
            if (index >= 0 && index < nums.Count)
            {
                nums.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void ShiftNumbers(List<int> nums, string direction, int n)
        {
            n = n % nums.Count;

            if (direction == "left")
            {
                for (int i = 0; i < n; i++)
                {
                    int firstNumber = nums[0];
                    nums.RemoveAt(0);
                    nums.Add(firstNumber);
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < n; i++)
                {
                    int lastNumber = nums[nums.Count - 1];
                    nums.RemoveAt(nums.Count - 1);
                    nums.Insert(0, lastNumber);
                }
            }
        }
    }
}