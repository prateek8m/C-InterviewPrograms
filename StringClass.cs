using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CSharpInterviewPrograms
{
    class StringClass
    {

        public void test()
        {
            string s = "asddaedn";
            Console.WriteLine(s[0]);
            s.Contains("sda");
            s.Substring(2, 4);

            s = s + "as";

            int[] arr = new int[3];

            s = 4.ToString();

            //char
            Char.IsUpper('S');
            Char.IsLower('s');
            Char.ToLower('S');
            Char.ToUpper('s');

            char[] chararray = s.ToCharArray();
            
            string backtostring = new string(chararray);
            
        }
    }
}
