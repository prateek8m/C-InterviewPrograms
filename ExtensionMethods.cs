using System;

namespace EventHandlerDemo
{
    public static class MyExtensions
    {
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
