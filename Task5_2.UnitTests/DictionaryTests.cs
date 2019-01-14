using System.Collections.Generic;
using Xunit;

namespace Task5_2.UnitTests
{
    public class DictionaryTests
    {
        [Theory]
        [MemberData(nameof(AddTestsParams))]
        public void AddTests(Dictionary dictionary, List<Word> expecetedWords)
        {
            for (int i = 0; i < expecetedWords.Count; i++)
            {
                Assert.Equal(expecetedWords[i], dictionary.Words[i]);
            }
        }

        public static IEnumerable<object[]> AddTestsParams()
        {
            yield return new object[]
            {
                new Dictionary(new List<Word>
                {
                    new Word("glas", "voice"),
                    new Word("glas", "voice"),
                    new Word("jezik", "speech"),
                    new Word("dobar", "kind"),
                    new Word("dobar", "good"),
                    new Word("jezik", "tongue"),
                    new Word("glas", "sound"),
                    new Word("glas", "vote"),
                    new Word("jezik", "language")
                }),
                new List<Word>
                {
                    new Word("dobar", "good"),
                    new Word("dobar", "kind"),
                    new Word("glas", "sound"),
                    new Word("glas", "voice"),
                    new Word("glas", "voice"),
                    new Word("glas", "vote"),
                    new Word("jezik", "language"),
                    new Word("jezik", "speech"),
                    new Word("jezik", "tongue")
                }
            };
        }

        [Theory]
        [MemberData(nameof(TranslationTestsParams))]
        public void TranslationTests(List<Word> words, string term, List<string> expecetedTranslations)
        {
            Dictionary dictionary = new Dictionary();

            foreach (Word word in words)
            {
                dictionary.Add(word);
            }

            Assert.Equal(expecetedTranslations, dictionary.Translate(term));
        }

        public static IEnumerable<object[]> TranslationTestsParams()
        {
            yield return new object[]
            {
                new List<Word>()
                {
                    new Word("glas", "voice"),                    
                    new Word("jezik", "speech"),
                    new Word("dobar", "kind"),
                    new Word("dobar", "good"),
                    new Word("jezik", "tongue"),
                    new Word("glas", "sound"),
                    new Word("glas", "vote"),
                    new Word("jezik", "language")
                },
                Term("glas"),
                new List<string>()
                {
                    "sound",
                    "voice",
                    "vote"
                }
            };

            yield return new object[]
            {
                new List<Word>()
                {
                    new Word("glas", "voice"),
                    new Word("jezik", "speech"),
                    new Word("dobar", "kind"),
                    new Word("dobar", "good"),
                    new Word("jezik", "tongue"),
                    new Word("glas", "sound"),
                    new Word("glas", "vote"),
                    new Word("jezik", "language")
                },
                Term("jezik"),
                new List<string>()
                {
                    "language",
                    "speech",
                    "tongue"
                }
            };

            yield return new object[]
            {
                new List<Word>()
                {
                    new Word("glas", "voice"),
                    new Word("jezik", "speech"),
                    new Word("dobar", "kind"),
                    new Word("dobar", "good"),
                    new Word("jezik", "tongue"),
                    new Word("glas", "sound"),
                    new Word("glas", "vote"),
                    new Word("jezik", "language")
                },
                Term("dobar"),
                new List<string>()
                {
                    "good",                    
                    "kind"
                }
            };
        }

        public static string Term(string term) => term;
    }
}
