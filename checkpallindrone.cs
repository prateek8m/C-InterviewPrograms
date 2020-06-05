using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpInterviewPrograms
{
    /*
     * Given a string, write a function to find out if it’s characters can be rearranged to form a palindrome. For example:
For inputString = "aabb", the output should be
palindromeRearranging(inputString) = true.
     */
   
    class checkpallindrone
    {
       string s="aabbcd";
        public void check()
        {
            // List<char> chararray = new List<char> { 'a', 'e', 'i', 'o', 'a', 'o', 'p' };
            int n = s.Count();
            int numberofodds=s.Count(delegate (char ch){
                int count = 0;
                for(int i=0;i<n;i++)
                {
                    if (s[i] == ch)
                        count++;
                }
                if (count % 2 != 0)
                    return true;
                return false;
            });

            if(numberofodds>1)
            {
                Console.WriteLine("not pallimdrome");
            }
            else
            {
                Console.WriteLine("pallindrome");
            }

            Console.WriteLine(s);
            char[] chararray = s.ToCharArray();
            chararray[0] = 'x';
            string st = new string(chararray);
            Console.WriteLine(st);
                 
        }
    }
}
