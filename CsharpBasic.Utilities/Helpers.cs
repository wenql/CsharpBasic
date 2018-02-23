using System;

namespace CsharpBasic.Utilities
{
    public static class Helpers
    {
        public static string GetProperties<T>(T t)
        {
            var tStr = string.Empty;
            if (t == null)
            {
                return tStr;
            }
            var properties = t.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return tStr;
            }
            foreach (var item in properties)
            {
                var name = item.Name;
                var value = item.GetValue(t, null);
                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    tStr += string.Format("{0}:{1},", name, value);
                }
                else
                {
                    GetProperties(value);
                }
            }
            return tStr;
        }
    }
}
