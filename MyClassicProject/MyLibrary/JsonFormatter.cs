using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyLibrary
{
    public static class JsonFormatter
    {
        public static string Format(string json)
        {
            var token = JToken.Parse(json);
            var formattedJson = token.ToString(Formatting.Indented);
            return formattedJson;
        }
    }
}
