using System.Collections.Generic;
using System.Linq;

namespace TestNinja.Fundamentals
{
    public class Alphabetize
    {
        public string FindLongestSequense(string sequence)
        {
            var gatheredSequences = new List<string>();

            string matches = "";
            for (var i = 0; i < sequence.Length - 1; i++)
            {
                // get the character
                var thisCaharcter = sequence.ToCharArray()[i];
                var nextCaharcter = sequence.ToCharArray()[i + 1];
                // picking up the next character in the alphabet
                var nextInTheAlphabet = (char)(thisCaharcter + 1);

                if (nextCaharcter == nextInTheAlphabet)
                {
                    if (matches.Length <= 0)
                        matches += $"{thisCaharcter.ToString()}{nextCaharcter.ToString()}";
                    else
                        matches += nextCaharcter.ToString();
                }
                else
                {
                    if (matches.Length > 1)
                    {
                        gatheredSequences.Add(matches);
                    }
                    matches = "";
                }
            }

            return gatheredSequences.OrderByDescending(s => s.Length).First();
        }
    }
}