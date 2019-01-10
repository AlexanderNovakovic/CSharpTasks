using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    public class Word
    {
        public string Term { get; }
        public string Translation { get; }

        public Word(string term, string translation)
        {
            Term = term;
            Translation = translation;
        }

        public static bool operator ==(Word left, Word right) =>
            !(left is null ^ right is null) && (left is null || left.Equals(right));

        public static bool operator !=(Word left, Word right) =>
            !(left == right);

        public static bool operator <=(Word left, Word right) =>
            !(left > right);

        public static bool operator >=(Word left, Word right) =>
            !(left < right);

        public static bool operator <(Word left, Word right) =>        
            left.Term.CompareTo(right.Term) < 0 
                || left.Term.CompareTo(right.Term) == 0 
                && left.Translation.CompareTo(right.Translation) < 0;
        
        public static bool operator >(Word left, Word right) =>
            left.Term.CompareTo(right.Term) > 0 
                || left.Term.CompareTo(right.Term) == 0 
                && left.Translation.CompareTo(right.Translation) > 0;

    }
}
