using System;

namespace EmojiUID
{
    public class EmojiUID
    {
        public static string Generate()
        {
            string unicodeCodePoint = "U+1F493";
            int codePoint = int.Parse(unicodeCodePoint.Substring(2), System.Globalization.NumberStyles.HexNumber);
            string emoji = Char.ConvertFromUtf32(codePoint);

            return emoji; // Output: 💓
        }
    }
}

