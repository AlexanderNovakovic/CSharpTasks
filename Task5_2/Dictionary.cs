using System;
using System.Collections.Generic;

namespace Task5_2
{
    public class Dictionary : IComparer<Word>
    {
        public List<Word> Words { get; }

        public Dictionary() =>
            Words = new List<Word>();

        public void Add(Word word)
        {
            if (word is null)
            {
                throw new ArgumentNullException(nameof(word));
            }

            Words.Add(word);

            IComparer<Word> comparer = new Dictionary();

            Words.Sort(comparer);
        }

        public List<string> Translate(string term)
        {
            List<string> translations = new List<string>();

            foreach (Word word in Words)
            {
                if (word.Term == term)
                {
                    translations.Add(word.Translation);
                }
            }

            return translations;
        }

        public int Compare(Word left, Word right)
        {
            if (left.Term.CompareTo(right.Term) != 0)
            {
                return left.Term.CompareTo(right.Term);
            }
            else if (left.Translation.CompareTo(right.Translation) != 0)
            {
                return left.Translation.CompareTo(right.Translation);
            }
            else
            {
                return 0;
            }
        }
    }
}
