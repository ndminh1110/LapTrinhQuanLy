using System.Text;
using System.Text.RegularExpressions;

namespace QuanLyBanHang.Helpers
{
    public static class StringExtensions
    {
        public static string GenerateSlug(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "";

            text = text.ToLower().Trim();

            // Xóa dấu tiếng Việt
            text = RemoveDiacritics(text);

            // Thay khoảng trắng bằng dấu "-"
            text = Regex.Replace(text, @"\s+", "-");

            // Xóa ký tự đặc biệt
            text = Regex.Replace(text, @"[^a-z0-9\-]", "");

            return text;
        }

        private static string RemoveDiacritics(string text)
        {
            var normalized = text.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var c in normalized)
            {
                var unicodeCategory =
                    System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);

                if (unicodeCategory !=
                    System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
