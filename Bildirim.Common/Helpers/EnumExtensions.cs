using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Bildirim.Common.Helpers
{
    public static class EnumExtensions
    {
        // This extension method is broken out so you can use a similar pattern with
        // other MetaData elements in the future. This is your base method for each.
        public static T GetAttribute<T>(this System.Enum value) where T : Attribute
        {

            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            if (memberInfo.Length == 0)
            {
                return null;
            }
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);

            return (T)attributes[0];
        }

        // This method creates a specific call to the above method, requesting the
        // Description MetaData attribute.
        public static string ToName(this System.Enum value)
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();

            return attribute == null ? "" : attribute.Description;
        }

        public static string GetDescriptionFromEnumValue(System.Enum value)
        {
            DescriptionAttribute attribute = value.GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .SingleOrDefault() as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static T GetEnumValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum)
                throw new ArgumentException();
            FieldInfo[] fields = type.GetFields();
            var field = fields
                .SelectMany(f => f.GetCustomAttributes(
                    typeof(DescriptionAttribute), false), (
                    f, a) => new { Field = f, Att = a })
                .Where(a => ((DescriptionAttribute)a.Att)
                            .Description == description).SingleOrDefault();
            return field == null ? default(T) : (T)field.Field.GetRawConstantValue();
        }
    }
}
