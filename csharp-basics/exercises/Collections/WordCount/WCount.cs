using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class WCount
    {
        public int LineCount(List<string> text)
        {
            int lines = text.Count;
            return lines;
        }

        public int WordCount(List<string> text)
        {
            string wordStr = "";
            for (int i = 0; i < text.Count; i++)
            {
                wordStr += text[i] + " ";
            }
            string[] wordList = Regex.Replace(wordStr, @"\s+", " ").Trim().Split(' ', '\'');
            int words = wordList.Length;
            return words;
        }

        public int CharCount(List<string> text)
        {
            List<char> charList = new List<char>();
            for (int i = 0; i < text.Count; i++)
            {
                char[] charStr = text[i].ToCharArray();
                foreach (char c in charStr)
                {
                    charList.Add(c);
                }
            }
            int chars = charList.Count;
            return chars;
        }
    }
}
