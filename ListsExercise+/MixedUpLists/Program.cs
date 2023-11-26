namespace MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> list2 = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            List<int> margeList = new List<int>();
            List<int> finalList1 = new List<int>();

            if (list1.Count > list2.Count)
            {
                for (int i = 0; i <= list2.Count - 1; i++)
                {
                    margeList.Add(list1[i]);
                    margeList.Add(list2[list2.Count - 1 - i]);
                }

                int max = Math.Max(list1[list1.Count - 2], list1[list1.Count - 1]);
                int min = Math.Min(list1[list1.Count - 2], list1[list1.Count - 1]);

                foreach (int item in margeList)
                {
                    if (item > min && item < max)
                    {
                        finalList1.Add(item);
                    }
                }
            }

            if (list1.Count < list2.Count)
            {
                for (int i = 0; i <= list1.Count - 1; i++)
                {
                    margeList.Add(list1[i]);
                    margeList.Add(list2[list2.Count - 1 - i]);
                }

                int max = Math.Max(list2[0], list2[1]);
                int min = Math.Min(list2[0], list2[1]);

                foreach (int item in margeList)
                    {
                       if (item > min && item < max)
                       {
                           finalList1.Add(item);
                       }
                    }
            }

            List<int> finalList2 = finalList1.OrderBy(x => x).ToList();
            Console.WriteLine(String.Join(" ", finalList2));
        }
    }
}