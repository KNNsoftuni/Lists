namespace Cards_Game
{
    internal class Program
    {
        static void Main()
        {
            List<int> firstPlayerCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                int playerOne = firstPlayerCards[0];
                int playerTwo = secondPlayerCards[0];

                if (playerOne > playerTwo)
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);

                    firstPlayerCards.Add(playerOne);
                    firstPlayerCards.Add(playerTwo);
                }
                else if (playerOne < playerTwo)
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);

                    secondPlayerCards.Add(playerTwo);
                    secondPlayerCards.Add(playerOne);
                }
                else
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
            }

            if (firstPlayerCards.Count > secondPlayerCards.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
            }
            else if (firstPlayerCards.Count < secondPlayerCards.Count)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}