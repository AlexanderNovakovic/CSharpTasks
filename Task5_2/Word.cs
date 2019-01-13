using System;

namespace Task5_2
{
    public class Word : IEquatable<Word>
    {
        public string Term { get; }
        public string Translation { get; }

        public Word(string term, string translation)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                throw new ArgumentException(nameof(term));
            }

            if (string.IsNullOrWhiteSpace(translation))
            {
                throw new ArgumentException(nameof(translation));
            }

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

        public bool Equals(Word other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Term == other.Term
                   && Translation == other.Translation;
        }

        public override bool Equals(object obj) =>
            Equals(obj as Word);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Term.GetHashCode();
                hashCode = (hashCode * 397) ^ Translation.GetHashCode();
                return hashCode;
            }
        }
    }
}

