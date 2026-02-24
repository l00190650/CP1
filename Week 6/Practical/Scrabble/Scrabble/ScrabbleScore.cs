/*
 * Filename: Lasagna.cs
 * Description: A skeleton class for a C# practical exercise covering basic programming tasks
 * such as declaring variables, methods, returning data from methods.
 *
 * Excercise adapted from https://github.com/exercism/csharp/tree/main/exercises/practice/scrabble-score
 */

using System.Collections.Generic;

namespace Scrabble
{
    public static class ScrabbleScore
    {
        private static Dictionary<char, int> letterScore = new Dictionary<char, int>()
        {
            { 'A', 1 },
            { 'E', 1 },
            { 'I', 1 },
            { 'O', 1 },
            { 'U', 1 },
            { 'L', 1 },
            { 'N', 1 },
            { 'R', 1 },
            { 'S', 1 },
            { 'T', 1 },
            { 'D', 2 },
            { 'G', 2 },
            { 'B', 3 },
            { 'C', 3 },
            { 'M', 3 },
            { 'P', 3 },
            { 'F', 4 },
            { 'H', 4 },
            { 'V', 4 },
            { 'W', 4 },
            { 'Y', 4 },
            { 'K', 5 },
            { 'J', 8 },
            { 'X', 8 },
            { 'Q', 10 },
            { 'Z', 10 },
        };

        /// <summary>
        /// Calculates the score based on the specified input string.Each letter in the input string is scored
        /// according to the following rules:
        /// 1 point : A, E, I, O, U, L, N, R, S, T
        /// 2 points : D, G
        /// 3 points : B, C, M, P
        /// 4 points : F, H, V, W, Y
        /// 5 points : K
        /// 8 points : J, X
        /// 10 points : Q, Z
        /// For example the word "cabbage" is worth 14 points
        /// </summary>
        /// <param name="input">The input string to evaluate and compute the score. Cannot be null.</param>
        /// <returns>An integer representing the calculated score for the provided input.</returns>
        public static int Score(string input)
        {
            int score = 0;
            input = input.ToUpper();
            input = input.Replace(" ", "");
            if (
                input == ""
            ) return score; //throw new ArgumentNullException(nameof(input), "Input cannot be null or empty.");
            char[] inputChars = input.ToCharArray();

            foreach(char chara in inputChars)
            {
                try
                {
                    score += letterScore[chara];
                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine($"Couldn't find character (chara) in the dictionary; skipping it");
                }
            }

            return score;
        }

    }
}
