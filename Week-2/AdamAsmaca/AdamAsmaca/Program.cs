using System;

namespace AdamAsmaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Stages:
             * 1. Choose a word with randomly from array
             * 2. Convert the letters of the selected word to *.
             * 3. Show the puzzle on the screen.
             * 4. Request letter from player.
             * 5. Does the entered letter exist in the selected word? Check it!
             * 6. a.If true, convert its location to letter.
             *    b.If false, reduce the number of predictions by one.
             * 7.Ask the player to guess the word.
             *    a.If he/she knows, finish the game!
             *    b.If he/she does not know, go to step 3 again.
             * 
             */

            bool isGameOver = false;
            string[] words = new string[] { "ayna", "masa", "tarantula", "endoplazmikretikulum", "kamikaze" };


            while (!isGameOver)
            {
                string selectedWord = chooseWord(words);
                string puzzle = replaceToStar(selectedWord);

                Console.WriteLine(puzzle);
                bool isWordFinding = false;
                int life = 2;
                while (!isWordFinding && life>0)
                {
                    
                    do
                    {
                        Console.WriteLine("Enter a letter: ");
                        string letter = Console.ReadLine();
                        bool isLetterExistInWord = checkLetterInWord(selectedWord, letter);
                        if (isLetterExistInWord)
                        {
                            puzzle = replaceStarToLetter(selectedWord, puzzle, letter);
                            Console.WriteLine(puzzle);
                        }

                        Console.WriteLine("Do you want to guess the word? (Y/N) ");
                        string answerForGuess = Console.ReadLine();
                        if (answerForGuess.ToUpper() == "Y")
                        {
                            Console.WriteLine("What do you think about this word dude? : ");
                            string guess = Console.ReadLine();

                            if (compareGuessSelectedWord(guess, selectedWord))
                            {
                                isWordFinding = true;
                                Console.WriteLine("Congratz!");
                            }
                            else
                            {
                                life--;
                                Console.WriteLine("Oops! Try again dude");
                                Console.WriteLine($"Your life = {life}");
                                
                            }
                            
                        } 
                    } while (isWordFinding);
                }
                Console.WriteLine("********GAME OVER********");

                Console.WriteLine("Do you want to play smart boy/girl? (Y/N)");
                isGameOver = Console.ReadLine().ToUpper() == "N";

            }

        }

        private static bool compareGuessSelectedWord(string guess, string selectedWord)
        {
            return guess == selectedWord;
        }

        static string chooseWord(string[] words)
        {
            Random random = new Random();
            string word = words[random.Next(0,words.Length)];
            return word;
        }

        static string replaceToStar(string selectedWord)
        {
            string puzzleResult= string.Empty;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                puzzleResult += "*";
            }
            return puzzleResult;
        }

        static bool checkLetterInWord(string selectedWord, string letter)
        {
            return selectedWord.Contains(letter);
        }

        static string replaceStarToLetter(string selectedWord, string puzzle, string letter)
        {
            int startIndex = 0;
            char[] puzzleStars = puzzle.ToCharArray();
            while(selectedWord.IndexOf(letter,startIndex) != -1)
            {
                int findingIndex = selectedWord.IndexOf(letter,startIndex);
                puzzleStars[findingIndex] = Convert.ToChar(letter);
                startIndex = findingIndex + 1;
            }

            string result = string.Empty;
            foreach (var item in puzzleStars)
            {
                result += item.ToString();
            }

            return result;
        }
    }
}
