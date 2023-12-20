internal class Program
{
    private static void Main(string[] args)
    {
        string[] words = { "cat", "money", "pancake", "notebook", "dog", "horse", "tree", "house", "car", "apple", "banana", "orange" };
        int index = new Random().Next(words.Length - 1);
        string word = words[index];
        bool game = true;



        char[] symbols = new char[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            symbols[i] = '*';
        }
        Console.WriteLine(symbols);

        int mistakeCount = 0, guessCount = 0;
        while (game)
        {
            char guess = char.Parse(Console.ReadLine());

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == guess)
                {
                    symbols[i] = guess;
                    guessCount++;
                    Console.WriteLine(symbols);
                }
                else
                {
                    mistakeCount++;
                }
            }

            if (guessCount == word.Length)
            {
                Console.WriteLine("You win");
                game = false;
            }
            else if(mistakeCount == 5)
            {
                Console.WriteLine("You lose");
            }
        }
    }

}