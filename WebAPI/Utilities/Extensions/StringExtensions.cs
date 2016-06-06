using Newtonsoft.Json;

namespace Utilities.Extensions
{
    public static class StringExtensions
    {
        public static T DeserializeObject<T> (this string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
