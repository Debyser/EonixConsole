using System;
using System.ComponentModel;

namespace EonixConsole
{
    /// <summary>
    ///     Extension methods for <see cref="Enum" />.
    /// </summary>
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value) => GetDescription(value);

        #region private methods
        private static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
        #endregion 

    }
}
