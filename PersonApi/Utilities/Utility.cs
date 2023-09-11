using PersonApi.Models;

namespace PersonApi.Utilities
{
    public static class Utility
    {
        public static string ToCamelCase(this string value)
        {
            return value.ToLowerInvariant();
        }

        public static string FullName(this Person person)
        {
            return $"{person.Name} {person.Family}";
        }
    }
}

