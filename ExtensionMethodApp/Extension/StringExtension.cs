using System;

namespace ExtensionMethodApp.Extension
{
    public static class StringExtension
    {
        public static String Foo(this String str)
        {
            return str;
        }

        public static String TooSnakeCase(this String str)
        {
            str = str.ToLower();
            str = str.Replace(" ", "_");
            return str;
        }
    }
}
