using System.Collections.Generic;

namespace Task4_2
{
    public static class TriangleExtensions
    {
        public static double[] SortedAreas(this Triangle[] triangles)
        {
            List<double> areas = new List<double>();

            foreach (var triangle in triangles)
            {
                areas.Add(triangle.Area);
            }

            areas.Sort();
            return areas.ToArray();
        }
    }
}
