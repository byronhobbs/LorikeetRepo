using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorikeet
{
    public static class StringCompareClass
    {
        public static double DiceCoefficient(this string input, string comparedTo)
        {
            var ngrams = input.ToBiGrams();
            var compareToNgrams = comparedTo.ToBiGrams();
            return ngrams.DiceCoefficient(compareToNgrams);
        }

        public static double DiceCoefficient(this string[] nGrams, string[] compareToNGrams)
        {
            int matches = 0;
            foreach (var nGram in nGrams)
            {
                if (compareToNGrams.Any(x => x == nGram)) matches++;
            }
            if (matches == 0) return 0.0d;
            double totalBigrams = nGrams.Length + compareToNGrams.Length;
            return (2 * matches) / totalBigrams;
        }

        public static string[] ToBiGrams(this string input)
        {
            input = SinglePercent + input + SinglePound;
            return ToNGrams(input, 2);
        }

        public static string[] ToTriGrams(this string input)
        {
            input = DoublePercent + input + DoublePount;
            return ToNGrams(input, 3);
        }

        private static string[] ToNGrams(string input, int nLength)
        {
            int itemsCount = input.Length - 1;
            string[] ngrams = new string[input.Length - 1];
            for (int i = 0; i < itemsCount; i++) ngrams[i] = input.Substring(i, nLength);
            return ngrams;
        }

        private const string SinglePercent = "%";
        private const string SinglePound = "#";
        private const string DoublePercent = "&&";
        private const string DoublePount = "##";
    }
}
