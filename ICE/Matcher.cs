using System.Collections.Generic;

namespace ICE
{
    public class Matcher
    {
        public List<int> Match(string input, string subtext)
        {
            input = input.ToUpperInvariant();
            subtext = subtext.ToUpperInvariant();

            var matchResult = new List<int>();

            var subTextLength = subtext.Length - 1;
            var maxLoopLength = input.Length - subTextLength;

            for (var i = 0; i < maxLoopLength; i++)
            {
                var j = subTextLength;
                while (j >= 0 && subtext[j] == input[i + j])
                {
                    j--;
                }

                if (j < 0)
                {
                    matchResult.Add(i+1);
                }
            }

            return matchResult;
        }
    }
}
