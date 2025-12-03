using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace UzmanIzolasyon.Helpers
{
    public static class SlugHelper
    {
        // Türkçe karakterleri İngilizce eşdeğerine çevir ve güvenli slug üret
        public static string Sluggify(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";

            // Türkçe karakter dönüşümü
            var tr = new Dictionary<char, char> {
                {'ç','c'}, {'Ç','c'}, {'ğ','g'}, {'Ğ','g'}, {'ı','i'}, {'İ','i'},
                {'ö','o'}, {'Ö','o'}, {'ş','s'}, {'Ş','s'}, {'ü','u'}, {'Ü','u'}
            };

            var sb = new StringBuilder();
            foreach (var ch in text)
            {
                if (tr.ContainsKey(ch)) sb.Append(tr[ch]);
                else sb.Append(ch);
            }

            // küçük harfe çevir
            string result = sb.ToString().ToLowerInvariant();

            // harf, rakam ve tire dışındaki karakterleri çıkar
            result = Regex.Replace(result, @"[^a-z0-9\s-]", "");

            // birden fazla boşluğu tek tire yap
            result = Regex.Replace(result, @"\s+", "-").Trim('-');

            // ardışık tireleri tek tire yap
            result = Regex.Replace(result, @"-+", "-");

            return result;
        }
    }
}
