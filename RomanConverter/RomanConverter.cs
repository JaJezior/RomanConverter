using System.Collections.Generic;
using System.Linq;

namespace RomanConverter
{
    public class RomanConverter
    {
        public int ConvertToArabic(string romanInput)
        {
            List<char> listOfRoman = SplitIntoRomanChars(romanInput);
            List<int> arabicEquivalents = GetArabicEquivalents(listOfRoman);
            return CalculateSum(arabicEquivalents);
        }
        /// <summary>
        /// Returns sum of arabic numbers from arabic equivalents of roman chars
        /// </summary>
        /// <param name="listOfArabic"></param>
        /// <returns>simple number in int format</returns>
        private int CalculateSum(List<int> listOfArabic)
        {
            int arabicSum = listOfArabic[0];
            for (int i = 1; i < listOfArabic.Count(); i++)
            {
                bool isSubstractionNeeded = (listOfArabic[i - 1] > listOfArabic[i]);
                if (isSubstractionNeeded)
                {
                    arabicSum -= listOfArabic[i];
                }
                else
                {
                    arabicSum += listOfArabic[i];
                }
            }
            return arabicSum;
        }

        private List<int> GetArabicEquivalents(List<char> listOfRoman)
        {
            var listOfArabic = new List<int>();
            foreach (char romanLetter in listOfRoman)
            {
                int arabicEquivalent;
                switch (romanLetter)
                {
                    case 'I':
                        arabicEquivalent = 1;
                        break;
                    case 'V':
                        arabicEquivalent = 5;
                        break;
                    case 'X':
                        arabicEquivalent = 10;
                        break;
                    case 'L':
                        arabicEquivalent = 50;
                        break;
                    case 'C':
                        arabicEquivalent = 100;
                        break;
                    case 'D':
                        arabicEquivalent = 500;
                        break;
                    case 'M':
                        arabicEquivalent = 1000;
                        break;
                    default:
                        arabicEquivalent = 0;
                        break;
                }
                listOfArabic.Add(arabicEquivalent);
            }

            return listOfArabic;
        }

        private List<char> SplitIntoRomanChars(string romanInput)
        {
            return romanInput.ToCharArray().Reverse().ToList();
        }
    }
}
