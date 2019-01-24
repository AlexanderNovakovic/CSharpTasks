using System;
using System.Collections.Generic;

namespace Task6_4
{
    public static class Shape3DExtensions
    {
        public static List<Figure3D> WithAboveAverageMass(this List<Figure3D> shapes)
        {
            List<Figure3D> shapesWithAboveAverageMass = new List<Figure3D>();

            double average = shapes.Average();

            foreach (Figure3D shape in shapes)
            {
                if (shape.Mass > average)
                {
                    shapesWithAboveAverageMass.Add(shape);
                }
            }

            return shapesWithAboveAverageMass;
        }

        private static double Average(this List<Figure3D> shapes)
        {
            double totalMass = 0;

            foreach (Figure3D shape in shapes)
            {
                totalMass += shape.Mass;
            }

            return totalMass / shapes.Count;

        }

        public static IEnumerable<Figure3D> Where(this IEnumerable<Figure3D> source, Func<Figure3D, bool> predicate)
        {
            List<Figure3D> figures = new List<Figure3D>();

            foreach (var figure3D in source)
            {
                if (predicate(figure3D))
                {
                    figures.Add(figure3D);
                }
            }

            return figures;
        }
    }
}
