using System.Collections.Generic;

namespace Task6_6
{
    public static class LineExtensions
    {
        public static ILine Longest(this List<ILine> lines)
        {
            ILine longest = lines[0];

            foreach (ILine line in lines)
            {
                if (line.Length > longest.Length)
                {
                    longest = line;
                }
            }

            return longest;
        }
    }
}
