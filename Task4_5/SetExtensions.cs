using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_5
{
    public static class SetExtensions
    {
        public static Set Union(Set s1, Set s2) => 
            new Set((RemoveDoubles(Merge(s1, s2))));

        public static Set Complement(Set s1, Set s2)
        {
            Set s3 = Intersection(s1, s2);
            List<double> s1List = s1.Arr.ToList();

            for (int i = 0; i < s3.Arr.Length; i++)
            {
                for (int j = 0; j < s1List.Count; j++)
                {
                    if (s3.Arr[i] == s1List[j])
                    {
                        s1List.RemoveAt(j);
                    }
                }
            }

            return new Set(RemoveDoubles(s1List));
        }

        public static Set Intersection(Set s1, Set s2)
        {
            List<double> intersectionOfTwoSets = new List<double>();

            for (int i = 0; i < s1.Arr.Length; i++)
            {
                for (int j = 0; j < s2.Arr.Length; j++)
                {
                    if (s1.Arr[i] == s2.Arr[j])
                    {
                        intersectionOfTwoSets.Add(s1.Arr[i]);
                    }
                }
            }

            return new Set(intersectionOfTwoSets.ToArray());
        }

        private static List<double> Merge(Set s1, Set s2)
        {
            List<double> merged = new List<double>();
            int s1Index = 0;
            int s2Index = 0;

            while (s1Index < s1.Arr.Length && s2Index < s2.Arr.Length)
            {
                if (s1.Arr[s1Index] <= s2.Arr[s2Index])
                {
                    merged.Add(s1.Arr[s1Index++]);
                }
                else
                {
                    merged.Add(s2.Arr[s2Index++]);
                }
            }

            if (s1Index < s1.Arr.Length)
            {
                for (int i = s1Index; i < s1.Arr.Length; i++)
                {
                    merged.Add(s1.Arr[i]);
                }
            }
            else
            {
                for (int j = s2Index; j < s2.Arr.Length; j++)
                {
                    merged.Add(s2.Arr[j]);
                }
            }

            return merged;
        }

        private static double[] RemoveDoubles(List<double> numbers)
        {            
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers.RemoveAt(j);
                    }
                }
            }

            return numbers.ToArray();
        }
    }
}
