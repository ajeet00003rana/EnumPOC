using System.ComponentModel;
using static EnumPOC.CommonEnum;

namespace EnumPOC.Extension
{
    public static class EnumExtension
    {
        public static int ToInt(this Enum enumValue)
        {
            return Convert.ToInt32(enumValue);
        }

        public static string ToDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }
            throw new ArgumentException("Item not found.", nameof(enumValue));
        }

        public static List<string> GetNameListOfEnum<T>()
        {
            return Enum.GetNames(typeof(T)).ToList();
        }

        public static List<string> GetDescriptionListOfEnum<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<Role>().Select(x => x.ToDescription()).ToList();
        }

        public static T GetEnum<T>(this object value)
        {
            if (value is int intValue)
            {
                return (T)Enum.ToObject(typeof(T), intValue);
            }
            else if (value is string stringValue)
            {
                return (T)Enum.Parse(typeof(T), stringValue);
            }
            else
            {
                throw new ArgumentException("Invalid value type. Only int and string are supported.");
            }
        }

        public static bool isEnunExist<T>(this object value)
        {
            return Enum.IsDefined(typeof(T), value);
        }



    }
}
