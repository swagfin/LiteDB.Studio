using System.IO;

namespace LiteDB.Studio
{
    public static class StringExtensions
    {
        public static string CharacterTrimEllipsis(this string input, int length) => (input.Length <= length) ? input : input.Substring(0, length - 3) + "...";
        public static string FormatFilePath(this string filePath, int maxLength)
        {
            if (!File.Exists(filePath))
                return string.Empty;
            string fileName = Path.GetFileName(filePath);
            string fullPathTrimmed = filePath.CharacterTrimEllipsis(maxLength);
            return $"{fileName}::{fullPathTrimmed}";
        }
    }
}
