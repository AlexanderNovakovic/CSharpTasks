using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5_2
{
    public class Dictionary
    {
        public List<Word> Words { get; }

        public Dictionary() =>
            Words = new List<Word>();

        public Dictionary(IEnumerable<Word> words)
        {
            Words = words?.ToList() ?? throw new ArgumentNullException(nameof(words));
            Words.Sort();
        }

        public void Add(Word word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word));
            }

            Words.Add(word);

            Words.Sort();
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
    }
}
