using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpInterviewPrograms
{
    //static class Extension
    //{
    //    public static int Count(this string s)
    //    {
    //        int n = s.Count();
    //        return n;
    //    }
    //}
    class Linq
    {
        public void check()
        {
            string s = "rambaghpurnea";
            int res=s.Where(x => x.Equals('a') || x.Equals('e') || x.Equals('i') || x.Equals('o') || x.Equals('u')).Count();
            Console.WriteLine(res);
            s.Count();
            
        }
        public void check2() //query syntax
        {
            SortedList<string, int> sortedList = new SortedList<string, int>();
            sortedList.Add("one", 1);
            sortedList.Add("two", 2);
            sortedList.Add("three", 3);
            sortedList.Add("four", 4);
            sortedList.Add("five", 5);

            var query = from kvp in sortedList
                        where kvp.Key == "two"
                        select kvp;

            var result = query.FirstOrDefault();

            Console.WriteLine("key: {0}, value: {1}", result.Key, result.Value);
        }

        public void Display_Number_And_its_Frequency()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var res = from x in arr1
                      group x by x
                      into y
                      select y;

            foreach (var arrNo in res)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }
        }

        public void Number_And_Its_Square_More_then_20()
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            var res = from x in arr1
                      let square= x*x
                      where x * x > 20
                      select new { x, square};

            foreach (var arrNo in res)
            {
                Console.WriteLine(arrNo);
            }
        }

        public void Order_by()
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            var res = from x in arr1
                      orderby x descending
                      select x;

            foreach (var arrNo in res)
            {
                Console.WriteLine(arrNo);
            }

        }
        public void UpperCaseLetter()
        {
            string s= "asdBHBEkjEC";
            var res = s.Where(x => char.IsUpper(x) == true).Count();
            Console.WriteLine(res);
        }
        class Student
        {
            public string Name { get; set; }
            public string Regno { get; set; }
            public int Marks { get; set; }

        }

        public void Implement_Let_Condition_using_LINQ()
        {
            List<Student> objStudent = new List<Student>{
                    new Student{ Name="Tom",Regno="R001",Marks=80},
                    new Student{ Name="Bob",Regno="R002",Marks=40},
                    new Student{ Name="jerry",Regno="R003",Marks=25},
                    new Student{ Name="Syed",Regno="R004",Marks=30},
                    new Student{ Name="Mob",Regno="R005",Marks=70},
                };

            var objresult = from stu in objStudent
                            let totalMarks = objStudent.Sum(mark => mark.Marks)
                            let avgMarks = totalMarks / 5
                            where avgMarks > stu.Marks
                            select stu;
            foreach (var stu in objresult)
            {
                Console.WriteLine("Student: {0} {1}", stu.Name, stu.Regno);

            }
        }
    }
}
