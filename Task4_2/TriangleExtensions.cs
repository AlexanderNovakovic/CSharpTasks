using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    public static class TriangleExtensions
    {
        public static double[] CalculateSurfaces(Triangle[] triangles)
        {
            List<double> surfaces = new List<double>();

            Sort(triangles);

            foreach (var triangle in triangles)
            {
                surfaces.Add(triangle.Surface());
            }

            return surfaces.ToArray();
        }

        public static void Sort(Triangle[] triangles)
        {
            for (int i = 0; i < triangles.Length - 1; i++)
            {
                for (int j = i + 1; j < triangles.Length; j++)
                {
                    if (triangles[i].Surface() > triangles[j].Surface())
                    {
                        Triangle temp = triangles[i];
                        triangles[i] = triangles[j];
                        triangles[j] = temp;
                    }
                }
            }
        }
    }
}
