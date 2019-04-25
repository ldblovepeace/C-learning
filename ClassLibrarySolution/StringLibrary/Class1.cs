using System;

namespace StringLibrary
{
    public static class StringLibrary
    {
        public static Boolean StartsWithUpper(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            char ch = str[0];
            return Char.IsUpper(ch);
        }
    }
}
