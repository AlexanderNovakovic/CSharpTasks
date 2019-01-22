using System;
using System.Collections.Generic;

namespace Task6_4
{
    public static class ObjectExtensions
    {
        public static List<Object> AboveAverage(List<Object> objects)
        {
            List<Object> aboveAverage = new List<Object>();

            double average = Average(objects);

            foreach (Object obj in objects)
            {
                if (obj.Mass > average)
                {
                    aboveAverage.Add(obj);
                }
            }

            return aboveAverage;
        }

        private static double Average(List<Object> objects)
        {
            if (objects == null)
            {
                throw new ArgumentNullException(nameof(objects));
            }

            double totalMass = 0;

            foreach (Object obj in objects)
            {
                totalMass += obj.Mass;
            }

            return totalMass / objects.Count;
        }
    }
}
