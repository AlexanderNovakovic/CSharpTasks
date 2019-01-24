using System.Collections.Generic;

namespace Task6_6
{
    public static class LineExtensions
    {
        public static double Longest(List<Line> lines)
        {
            double max = double.MinValue;

            foreach (Line line in lines)
            {
                if (line.Length > max)
                {
                    max = line.Length;
                }
            }

            return max;
        }
    }
}
