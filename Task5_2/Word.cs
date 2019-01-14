using System;
using System.Collections.Generic;

namespace Task5_2
{
    public class Word : IEquatable<Word>, IComparer<Word>, IComparable<Word>
    {
        public string Term { get; }
        public string Translation { get; }

        public Word(string term, string translation)
        {
            if (string.IsNullOrEmpty(term?.Trim()))
            {
                throw new ArgumentException(nameof(term));
            }

            if (string.IsNullOrEmpty(translation?.Trim()))
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

        public int Compare(Word left, Word right)
        {
            if (left == null && right == null)
            {
                return 0;
            }

            if (left == null)
            {
                return -1;
            }

            if (right == null)
            {
                return 1;
            }

            if (left.Equals(right))
            {
                return 0;
            }

            if (string.Compare(left.Term, right.Term, StringComparison.Ordinal) < 0)
            {
                return -1;
            }

            if (string.Compare(left.Term, right.Term, StringComparison.Ordinal) == 0)
            {
                return string.Compare(left.Translation, right.Translation, StringComparison.Ordinal);
            }

            return 1;
        }

        public int CompareTo(Word other)
        {
            return Compare(this, other);
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

