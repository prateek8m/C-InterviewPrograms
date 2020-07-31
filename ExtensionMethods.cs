using System;

namespace EventHandlerDemo
{
    public static class MyExtensions
    {
        //Extension methods enable you to "add" methods to existing types without creating a new derived type,
        //recompiling, or otherwise modifying the original type. Extension methods are static methods, but they're called as if they were instance methods on the extended type
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                                StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string changefirstlettercase(this string str)
        {
            if(str==null)
            {
                return str;
            }
            else
            {
                char[] arr = str.ToCharArray();
                arr[0] = char.IsUpper(arr[0]) ? char.ToLower(arr[0]) : char.ToUpper(arr[0]);
                return arr.ToString();
            }
        }
    }
    
}
