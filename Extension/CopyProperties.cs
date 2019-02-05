using System.Linq;

namespace LeagueClientApi.Extension
{
    internal static class Reflection
    {
        public static void CopyPropertiesTo<T>(this T source, T destination) =>
            typeof(T).GetProperties().ToList().ForEach(property =>
            {
                if (property.GetGetMethod(true) != null && property.GetSetMethod(true) != null)
                    property.SetValue(destination, property.GetValue(source, null), null);
            });
    }
}